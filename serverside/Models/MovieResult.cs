using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using serverside.Models;


namespace serverside.Models
{
    public partial class MovieResult
    {
        [JsonProperty("page")]
        public long Page { get; set; }

        [JsonProperty("results")]
        public Result[] Results { get; set; }

        [JsonProperty("total_pages")]
        public long TotalPages { get; set; }

        [JsonProperty("total_results")]
        public long TotalResults { get; set; }
    }

    public partial class Result
    {
        [JsonProperty("adult")]
        public bool Adult { get; set; }

        [JsonProperty("backdrop_path")]
        public string BackdropPath { get; set; }

        [JsonProperty("genre_ids")]
        public long[] GenreIds { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("original_language")]
        public string OriginalLanguage { get; set; }

        [JsonProperty("original_title")]
        public string OriginalTitle { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("popularity")]
        public double Popularity { get; set; }

        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("video")]
        public bool Video { get; set; }

        [JsonProperty("vote_average")]
        public double VoteAverage { get; set; }

        [JsonProperty("vote_count")]
        public long VoteCount { get; set; }
    }

    // public enum OriginalLanguage { En, Es, Fr, Sv };

    // public partial class Movie
    // {
    //     public static Movie FromJson(string json) => JsonConvert.DeserializeObject<Movie>(json, serverside.Models.Converter.Settings);
    // }

    // public static class Serialize
    // {
    //     public static string ToJson(this Movie self) => JsonConvert.SerializeObject(self, serverside.Models.Converter.Settings);
    // }

    // internal static class Converter
    // {
    //     public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
    //     {
    //         MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
    //         DateParseHandling = DateParseHandling.None,
    //         Converters =
    //         {
    //             OriginalLanguageConverter.Singleton,
    //             new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
    //         },
    //     };
    // }

    // internal class OriginalLanguageConverter : JsonConverter
    // {
    //     public override bool CanConvert(Type t) => t == typeof(OriginalLanguage) || t == typeof(OriginalLanguage?);

    //     public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    //     {
    //         if (reader.TokenType == JsonToken.Null) return null;
    //         var value = serializer.Deserialize<string>(reader);
    //         switch (value)
    //         {
    //             case "en":
    //                 return OriginalLanguage.En;
    //             case "es":
    //                 return OriginalLanguage.Es;
    //             case "fr":
    //                 return OriginalLanguage.Fr;
    //             case "sv":
    //                 return OriginalLanguage.Sv;
    //         }
    //         throw new Exception("Cannot unmarshal type OriginalLanguage");
    //     }

    //     public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    //     {
    //         if (untypedValue == null)
    //         {
    //             serializer.Serialize(writer, null);
    //             return;
    //         }
    //         var value = (OriginalLanguage)untypedValue;
    //         switch (value)
    //         {
    //             case OriginalLanguage.En:
    //                 serializer.Serialize(writer, "en");
    //                 return;
    //             case OriginalLanguage.Es:
    //                 serializer.Serialize(writer, "es");
    //                 return;
    //             case OriginalLanguage.Fr:
    //                 serializer.Serialize(writer, "fr");
    //                 return;
    //             case OriginalLanguage.Sv:
    //                 serializer.Serialize(writer, "sv");
    //                 return;
    //         }
    //         throw new Exception("Cannot marshal type OriginalLanguage");
    //     }

    //     public static readonly OriginalLanguageConverter Singleton = new OriginalLanguageConverter();
    // }
}
