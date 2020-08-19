using System;
using System.Net.Http;
using System.Threading.Tasks;
using Ravn.Domain.Entities;
using Ravn.Domain.Utilities;
using Ravn.Logic.Interfaces;
using Ravn.Logic.Utilities;
using Ravn.Logic.Extentions;

namespace Ravn.Logic.Services
{
    public class SWApiService : ISWApiService
    {
        readonly HttpClient httpClient;

        public SWApiService(HttpClient _httpClient)
        {
            _httpClient.BaseAddress = new Uri("https://swapi.dev/api/");
            httpClient = _httpClient;
        }

        public Task<Film> getFilm(int filmId)
        {
            return httpClient.GetDataAsync<Film>($"films/{filmId}/");

        }

        public Task<Planet> getHomeWorld(int WorldId = 1)
        {
            return httpClient.GetDataAsync<Planet>($"planets/{WorldId}/");
        }

        public Task<BasePagination<Person>> GetPeople(int page = 1)
        {
            return httpClient.GetDataAsync<BasePagination<Person>>($"people/?page={page}");
        }

        public Task<Person> getPerson(int personId)
        {
            return httpClient.GetDataAsync<Person>($"people/{personId}/");
        }

        public Task<Spaceship> GetSpaceship(int spaceShipId)
        {
            return httpClient.GetDataAsync<Spaceship>($"starships/{spaceShipId}/");
        }

        public Task<Specie> GetSpecie(int speciaId = 1)
        {
            return httpClient.GetDataAsync<Specie>($"species/{speciaId}/");

        }

        public Task<Vehicle> GetVehicle(int vehicleId)
        {
            return httpClient.GetDataAsync<Vehicle>($"vehicles/{vehicleId}/");

        }
    }
}
