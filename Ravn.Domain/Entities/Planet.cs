using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Ravn.Domain.Utilities;

namespace Ravn.Domain.Entities
{
    public class Planet
    {
        public Planet()
        {
            Residents = new List<string>();
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
        [JsonPropertyName("rotation_period")]
        public string RotationPeriod { get; set; }
        [JsonPropertyName("orbital_period")]
        public string orbital_period { get; set; }
        public string Diameter { get; set; }
        public string Climate { get; set; }
        public string Gravity { get; set; }
        public string Terrain { get; set; }
        [JsonPropertyName("surface_water")]
        public string SurfaceWater { get; set; }
        public string Population { get; set; }
        public List<string> Residents { get; set; }
        public List<string> Films { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public string Url { get; set; }
    }
}
