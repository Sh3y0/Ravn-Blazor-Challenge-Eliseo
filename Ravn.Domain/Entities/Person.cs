using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Ravn.Domain.Utilities;

namespace Ravn.Domain.Entities
{
    public class Person
    {
        public Person()
        {
            Starships = new List<string>();
            Vehicles = new List<string>();
            Species = new List<string>();
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
        public string Height { get; set; }
        public string Mass { get; set; }
        [JsonPropertyName("hair_color")]
        public string HairColor { get; set; }
        [JsonPropertyName("skin_color")]
        public string SkinColor { get; set; }
        [JsonPropertyName("eye_color")]
        public string EyeColor { get; set; }
        [JsonPropertyName("birth_year")]
        public string BirthYear { get; set; }
        public string Gender { get; set; }
        public string Homeworld { get; set; }
        public List<string> Films { get; set; }
        public List<string> Species { get; set; }
        public List<string> Vehicles { get; set; }
        public List<string> Starships { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public string Url { get; set; }
    }
}
