  using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using serverside.Models;

namespace serverside.Models{
  public class ProductionCountry
    {
        [JsonProperty("iso_3166_1")]
        public string Iso3166_1 { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}