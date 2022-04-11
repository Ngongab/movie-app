    using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using serverside.Models;

namespace serverside.Models {

    public class SpokenLanguage
    {
        [JsonProperty("english_name")]
        public string EnglishName { get; set; }
        [JsonProperty("iso_639_1")]
        public string Iso639_1 { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}