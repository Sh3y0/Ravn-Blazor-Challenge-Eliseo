﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Ravn.Domain.Utilities;

namespace Ravn.Domain.Entities
{
    public class Film
    {
        public Film()
        {
            Characters = new List<string>();
            Planets = new List<string>();
            Starships = new List<string>();
            Vehicles = new List<string>();
            Species = new List<string>();
        }
        public int Id
        {
            get
            {
                return Utils.getId(Url);
            }
        }
        public string Title { get; set; }
        [JsonPropertyName("episode_id")]
        public int EpisodeId { get; set; }
        [JsonPropertyName("opening_crawl")]
        public string OpeningCrawl { get; set; }
        public string Director { get; set; }
        public string Producer { get; set; }
        [JsonPropertyName("release_date")]
        public string ReleaseDate { get; set; }
        public List<string> Characters { get; set; }
        public List<string> Planets { get; set; }
        public List<string> Starships { get; set; }
        public List<string> Vehicles { get; set; }
        public List<string> Species { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public string Url { get; set; }
    }
}