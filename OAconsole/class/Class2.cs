// Generated by https://quicktype.io
namespace QuickType_login
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    public partial class Login
    {
        [JsonProperty("result")]
        public string Result { get; set; }
        [JsonProperty("token")]
        public string Token { get; set; }
        [JsonProperty("resultType")]
        public string ResultType { get; set; }
        [JsonProperty("resultMessage")]
        public object ResultMessage { get; set; }
    }
    public partial class Login
    {
        public static Login FromJson(string json) => JsonConvert.DeserializeObject<Login>(json, QuickType.Converter.Settings);
    }
    public static class Serialize
    {
        public static string ToJson(this Login self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    }
    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters ={
new IsoDateTimeConverter{DateTimeStyles=DateTimeStyles.AssumeUniversal}
},
        };
    }
}
