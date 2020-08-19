using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Ravn.Factory.Interfaces;
using Ravn.Factory.Models;
using Ravn.Logic.Interfaces;
using Ravn.Logic.Utilities;
using Ravn.Domain.Utilities;
using Ravn.Domain.Entities;
using System.Web;

namespace Ravn.Factory.Loaders
{
    public class PersonLoader: IPersonLoader
    {
        private readonly ISWApiService sWApiService;

        public PersonLoader(ISWApiService _sWApiService)
        {
            sWApiService = _sWApiService;
        }

        public async Task<BasePagination<PersonModel>> LoadPerson(string page = null)
        {
            var currentPage = 1;
            if (!string.IsNullOrEmpty(page))
            {
                var uri = new Uri(page);
                currentPage = int.Parse(HttpUtility.ParseQueryString(uri.Query)["page"]);
            }

            var response = await sWApiService.GetPeople(currentPage).ConfigureAwait(false);
            if (!response.Results.Any()) return new BasePagination<PersonModel>();

            var result = new BasePagination<PersonModel>();

            foreach (var person in response.Results)
            {
                result.Results.Add( await buildPersonObject(person));
            }

            result.Count = response.Count;
            result.Next = response.Next;
            response.Previous = response.Previous;

            return result;
        }

        private async Task<PersonModel> buildPersonObject(Person person)
        {
            var personModel = new PersonModel()
            {
                Id = person.Id,
                Name = person.Name,
                Height = person.Height,
                Mass = person.Mass,
                HairColor = person.HairColor,
                SkinColor = person.SkinColor,
                EyeColor = person.EyeColor,
                BirthYear = person.BirthYear,
                Gender = person.Gender
            };

            var worldId = Utils.getId(person.Homeworld);
            personModel.Homeworld = await sWApiService.getHomeWorld(worldId);

            personModel.Films = await LoadAssociatedData(person.Films, sWApiService.getFilm);
            personModel.Species = await LoadAssociatedData(person.Species, sWApiService.GetSpecie);
            personModel.Vehicles = await LoadAssociatedData(person.Vehicles, sWApiService.GetVehicle);
            personModel.Startships = await LoadAssociatedData(person.Starships, sWApiService.GetSpaceship);

            return personModel;
        }

        private async Task<List<TModel>> LoadAssociatedData<TModel>(List<string> uris, Func<int, Task<TModel>> apiMethod)
        {
            var data = new List<TModel>();
            foreach (var uri in uris)
            {
                var id = Utils.getId(uri);
                var entity = await apiMethod(id).ConfigureAwait(false);
                data.Add(entity);
            }

            return data;
        }
    }
}
