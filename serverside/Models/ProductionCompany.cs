using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace serverside.Models {
public class ProductionCompany
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("logo_path")]
        public string LogoPath { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("origin_country")]
        public string OriginCountry { get; set; }
    }
}