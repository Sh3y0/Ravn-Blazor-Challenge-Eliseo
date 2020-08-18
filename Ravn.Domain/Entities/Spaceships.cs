using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Ravn.Domain.Utilities;

namespace Ravn.Domain.Entities
{
    public class Spaceships
    {
        public Spaceships()
        {
            Pilots = new List<string>();
            Films = new List<string>();
        }
        public int Id
        {
            get
            {
                return Utils.getId(Url);
            }
        }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        [JsonPropertyName("cost_in_credits")]
        public string CostInCredits { get; set; }
        public string Length { get; set; }
        [JsonPropertyName("max_atmosphering_speed")]
        public string MaxAtmospheringSpeed { get; set; }
        public string Crew { get; set; }
        public string Passengers { get; set; }
        [JsonPropertyName("cargo_capacity")]
        public string CargoCapacity { get; set; }
        public string Consumables { get; set; }
        [JsonPropertyName("hyperdrive_rating")]
        public string HyperdriveRating { get; set; }
        [JsonPropertyName("starship_class")]
        public string StarshipClass { get; set; }
        public List<string> Pilots { get; set; }
        public List<string> Films { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public string Url { get; set; }
    }
}
