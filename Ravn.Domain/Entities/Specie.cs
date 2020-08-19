using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Ravn.Domain.Utilities;

namespace Ravn.Domain.Entities
{
    public class Specie
    {
        public Specie()
        {
            People = new List<string>();
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
        public string Classification { get; set; }
        public string Designation { get; set; }
        public string AverageHeight { get; set; }
        [JsonPropertyName("skin_colors")]
        public string SkinColors { get; set; }
        [JsonPropertyName("hair_colors")]
        public string HairColors { get; set; }
        [JsonPropertyName("eye_colors")]
        public string EyeColors { get; set; }
        [JsonPropertyName("average_lifespan")]
        public string AverageLifespan { get; set; }
        public string Homeworld { get; set; }
        public string Language { get; set; }
        public List<string> People { get; set; }
        public List<string> Films { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public string Url { get; set; }
    }
}
