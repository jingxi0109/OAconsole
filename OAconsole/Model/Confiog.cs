namespace OAconsole.Model
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    public partial class Srv_Config
    {
        //[JsonProperty("result")]
        //public Result Result { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }


        [JsonProperty("ProductPlatform")]
        public string ProductPlatform { get; set; }

        [JsonProperty("part_list")]
        public List<PartList> Part_List { get; set; }
    }

    public partial class PartList
    {
        [JsonProperty("part_name")]
        public string PartName { get; set; }

        [JsonProperty("part_id")]
        public long PartId { get; set; }

        [JsonProperty("part_type_name")]
        public string  PartTypeName{ get; set; }

        [JsonProperty("product_id")]
        public string ProductId { get; set; }

        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        [JsonProperty("SupplierModel")]
        public string  SupplierModel { get; set; }

        [JsonProperty("part_code")]
        public string PartCode { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

    }

}