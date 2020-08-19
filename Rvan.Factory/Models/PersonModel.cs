using System.Collections.Generic;
using Ravn.Domain.Entities;

namespace Ravn.Factory.Models
{
    public class PersonModel
    {
        public PersonModel()
        {
            Films = new List<Film>();
            Species = new List<Specie>();
            Vehicles = new List<Vehicle>();
            Startships = new List<Spaceship>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Height { get; set; }
        public string Mass { get; set; }
        public string HairColor { get; set; }
        public string SkinColor { get; set; }
        public string EyeColor { get; set; }
        public string BirthYear { get; set; }
        public string Gender { get; set; }
        public Planet Homeworld { get; set; }
        public List<Film> Films { get; set; }
        public List<Specie> Species { get; set; }
        public List<Vehicle> Vehicles { get; set; }
        public List<Spaceship> Startships { get; set; }
    }
}
