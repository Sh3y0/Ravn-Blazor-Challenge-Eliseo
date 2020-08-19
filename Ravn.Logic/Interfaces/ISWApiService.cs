using System;
using System.Threading.Tasks;
using Ravn.Logic.Utilities;
using Ravn.Domain.Entities;

namespace Ravn.Logic.Interfaces
{
    public interface ISWApiService
    {
        Task<BasePagination<Person>> GetPeople(int page = 1);
        Task<Person> getPerson(int personId);
        Task<Planet> getHomeWorld(int WorldId = 1);
        Task<Film> getFilm(int filmId);
        Task<Specie> GetSpecie(int speciaId = 1);
        Task<Vehicle> GetVehicle(int vehicleId);
        Task<Spaceship> GetSpaceship(int spaceShipId);
    } 
}
 