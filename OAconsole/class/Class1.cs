﻿// Generated by https://quicktype.io

namespace QuickType
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Quotation
    {
        [JsonProperty("result")]
        public Result Result { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("resultType")]
        public string ResultType { get; set; }

        [JsonProperty("resultMessage")]
        public object ResultMessage { get; set; }
    }

    public partial class Result
    {
        [JsonProperty("quotation_serial_number")]
        public string QuotationSerialNumber { get; set; }

        [JsonProperty("quotation_id")]
        public long QuotationId { get; set; }

        [JsonProperty("discounted_product_config_price")]
        public double DiscountedProductConfigPrice { get; set; }

        [JsonProperty("opportunity_name")]
        public object OpportunityName { get; set; }

        [JsonProperty("contains_all_product_type")]
        public bool ContainsAllProductType { get; set; }

        [JsonProperty("owner_name")]
        public RName OwnerName { get; set; }

        [JsonProperty("contract_approval_id")]
        public object ContractApprovalId { get; set; }

        [JsonProperty("operator_id")]
        public long OperatorId { get; set; }

        [JsonProperty("total_cost_price")]
        public double TotalCostPrice { get; set; }

        [JsonProperty("current_approval_user_name")]
        public RName CurrentApprovalUserName { get; set; }

        [JsonProperty("quotation_name")]
        public string QuotationName { get; set; }

        [JsonProperty("opportunity_owner_id")]
        public object OpportunityOwnerId { get; set; }

        [JsonProperty("creator")]
        public Creator Creator { get; set; }

        [JsonProperty("quotation_notes")]
        public object QuotationNotes { get; set; }

        [JsonProperty("discount_price")]
        public double DiscountPrice { get; set; }

        [JsonProperty("product_config_list")]
        public ProductConfigList[] ProductConfigList { get; set; }

        [JsonProperty("quotation_status")]
        public long QuotationStatus { get; set; }

        [JsonProperty("spare_part_config_data_list")]
        public object[] SparePartConfigDataList { get; set; }

        [JsonProperty("contract_code")]
        public object ContractCode { get; set; }

        [JsonProperty("operator_name")]
        public RName OperatorName { get; set; }

        [JsonProperty("discount_rate")]
        public double DiscountRate { get; set; }

        [JsonProperty("opportunity_id")]
        public object OpportunityId { get; set; }

        [JsonProperty("third_party_product_list")]
        public object[] ThirdPartyProductList { get; set; }

        [JsonProperty("discounted_third_price")]
        public double DiscountedThirdPrice { get; set; }

        [JsonProperty("approval_status")]
        public long ApprovalStatus { get; set; }

        [JsonProperty("contract_approval_status")]
        public object ContractApprovalStatus { get; set; }

        [JsonProperty("customer_name")]
        public object CustomerName { get; set; }

        [JsonProperty("contract_id")]
        public object ContractId { get; set; }

        [JsonProperty("approval_id")]
        public long ApprovalId { get; set; }

        [JsonProperty("total_price")]
        public double TotalPrice { get; set; }

        [JsonProperty("operator")]
        public Creator Operator { get; set; }

        [JsonProperty("creator_id")]
        public long CreatorId { get; set; }

        [JsonProperty("spare_part_service_list")]
        public object[] SparePartServiceList { get; set; }

        [JsonProperty("is_deleted")]
        public long IsDeleted { get; set; }

        [JsonProperty("update_time")]
        public DateTimeOffset UpdateTime { get; set; }

        [JsonProperty("approval_need_user_type")]
        public long ApprovalNeedUserType { get; set; }

        [JsonProperty("owner")]
        public Creator Owner { get; set; }

        [JsonProperty("create_time")]
        public DateTimeOffset CreateTime { get; set; }

        [JsonProperty("owner_id")]
        public long OwnerId { get; set; }

        [JsonProperty("creator_name")]
        public RName CreatorName { get; set; }

        [JsonProperty("discounted_spare_price")]
        public double DiscountedSparePrice { get; set; }
    }

    public partial class Creator
    {
        [JsonProperty("user_name")]
        public RName UserName { get; set; }

        [JsonProperty("user_id")]
        public long UserId { get; set; }
    }

    public partial class ProductConfigList
    {
        [JsonProperty("quotation_serial_number")]
        public string QuotationSerialNumber { get; set; }

        [JsonProperty("sn_code")]
        public object SnCode { get; set; }

        [JsonProperty("service_price_company")]
        public double ServicePriceCompany { get; set; }

        [JsonProperty("cal_from")]
        public string CalFrom { get; set; }

        [JsonProperty("work_order_code")]
        public object WorkOrderCode { get; set; }

        [JsonProperty("owner_name")]
        public RName OwnerName { get; set; }

        [JsonProperty("product_id")]
        public long ProductId { get; set; }

        [JsonProperty("trial_test_id")]
        public object TrialTestId { get; set; }

        [JsonProperty("current_approval_user_name")]
        public RName CurrentApprovalUserName { get; set; }

        [JsonProperty("unit_price")]
        public double UnitPrice { get; set; }

        [JsonProperty("quotation_current_approval_user_name")]
        public RName QuotationCurrentApprovalUserName { get; set; }

        [JsonProperty("stock_approval_id")]
        public object StockApprovalId { get; set; }

        [JsonProperty("service_price_public")]
        public double ServicePricePublic { get; set; }

        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        [JsonProperty("product_type_id")]
        public long ProductTypeId { get; set; }

        [JsonProperty("service_price_material")]
        public double ServicePriceMaterial { get; set; }

        [JsonProperty("discounted_total_price")]
        public double DiscountedTotalPrice { get; set; }

        [JsonProperty("unit_price_public")]
        public double UnitPricePublic { get; set; }

        [JsonProperty("opportunity_id")]
        public object OpportunityId { get; set; }

        [JsonProperty("discount_rate")]
        public double DiscountRate { get; set; }

        [JsonProperty("discounted_total_price_part")]
        public double DiscountedTotalPricePart { get; set; }

        [JsonProperty("trial_test_unit_price")]
        public object TrialTestUnitPrice { get; set; }

        [JsonProperty("stock_current_approval_user_name")]
        public string StockCurrentApprovalUserName { get; set; }

        [JsonProperty("product_platform_id")]
        public ProductPlatformId ProductPlatformId { get; set; }

        [JsonProperty("approval_status")]
        public long ApprovalStatus { get; set; }

        [JsonProperty("product_config_name")]
        public string ProductConfigName { get; set; }

        [JsonProperty("approval_id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long ApprovalId { get; set; }

        [JsonProperty("total_price")]
        public double TotalPrice { get; set; }

        [JsonProperty("sale_status")]
        public long SaleStatus { get; set; }

        [JsonProperty("creator_id")]
        public long CreatorId { get; set; }

        [JsonProperty("product_type_name")]
        public string ProductTypeName { get; set; }

        [JsonProperty("update_time")]
        public DateTimeOffset UpdateTime { get; set; }

        [JsonProperty("optional_part_list")]
        public OptionalPartList[] OptionalPartList { get; set; }

        [JsonProperty("unit_price_service")]
        public object UnitPriceService { get; set; }

        [JsonProperty("unit_price_company")]
        public double UnitPriceCompany { get; set; }

        [JsonProperty("stock_quantity")]
        public object StockQuantity { get; set; }

        [JsonProperty("product_notes")]
        public string ProductNotes { get; set; }

        [JsonProperty("approval_need_user_type")]
        public long ApprovalNeedUserType { get; set; }

        [JsonProperty("discounted_unit_price_part")]
        public double DiscountedUnitPricePart { get; set; }

        [JsonProperty("owner")]
        public Creator Owner { get; set; }

        [JsonProperty("create_time")]
        public DateTimeOffset CreateTime { get; set; }

        [JsonProperty("creator_name")]
        public RName CreatorName { get; set; }

        [JsonProperty("trial_test_total_price")]
        public object TrialTestTotalPrice { get; set; }

        [JsonProperty("special_requirement_id")]
        public object SpecialRequirementId { get; set; }

        [JsonProperty("quotation_id")]
        public long QuotationId { get; set; }

        [JsonProperty("operator_id")]
        public long OperatorId { get; set; }

        [JsonProperty("product_name")]
        public string ProductName { get; set; }

        [JsonProperty("product_desc")]
        public string ProductDesc { get; set; }

        [JsonProperty("stock_code")]
        public object StockCode { get; set; }

        [JsonProperty("trial_test_code")]
        public object TrialTestCode { get; set; }

        [JsonProperty("creator")]
        public Creator Creator { get; set; }

        [JsonProperty("product_config_service_data_list")]
        public object[] ProductConfigServiceDataList { get; set; }

        [JsonProperty("unit_price_sale")]
        public double UnitPriceSale { get; set; }

        [JsonProperty("product_type_path")]
        public string ProductTypePath { get; set; }

        [JsonProperty("product_config_id")]
        public long ProductConfigId { get; set; }

        [JsonProperty("unit_price_manager")]
        public double UnitPriceManager { get; set; }

        [JsonProperty("quotation_approval_status")]
        public long QuotationApprovalStatus { get; set; }

        [JsonProperty("part_price_manager")]
        public double PartPriceManager { get; set; }

        [JsonProperty("quotation_status")]
        public long QuotationStatus { get; set; }

        [JsonProperty("part_price_public")]
        public double PartPricePublic { get; set; }

        [JsonProperty("operator_name")]
        public RName OperatorName { get; set; }

        [JsonProperty("part_price_company")]
        public double PartPriceCompany { get; set; }

        [JsonProperty("stock_approval_status")]
        public object StockApprovalStatus { get; set; }

        [JsonProperty("part_price_sale")]
        public double PartPriceSale { get; set; }

        [JsonProperty("service_price_manager")]
        public double ServicePriceManager { get; set; }

        [JsonProperty("trial_test_approval_status")]
        public object TrialTestApprovalStatus { get; set; }

        [JsonProperty("product_config_data_list")]
        public ProductConfigDataList[] ProductConfigDataList { get; set; }

        [JsonProperty("stock_id")]
        public object StockId { get; set; }

        [JsonProperty("trial_test_current_approval_user_name")]
        public string TrialTestCurrentApprovalUserName { get; set; }

        [JsonProperty("trial_test_approval_id")]
        public object TrialTestApprovalId { get; set; }

        [JsonProperty("operator")]
        public Creator Operator { get; set; }

        [JsonProperty("service_price_sale")]
        public double ServicePriceSale { get; set; }

        [JsonProperty("is_deleted")]
        public long IsDeleted { get; set; }

        [JsonProperty("discounted_unit_price")]
        public double DiscountedUnitPrice { get; set; }

        [JsonProperty("quotation_approval_id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long QuotationApprovalId { get; set; }

        [JsonProperty("trial_test_quantity")]
        public object TrialTestQuantity { get; set; }

        [JsonProperty("owner_id")]
        public long OwnerId { get; set; }

        [JsonProperty("product_config_code")]
        public string ProductConfigCode { get; set; }

        [JsonProperty("platform_part_list")]
        public PlatformPartList[] PlatformPartList { get; set; }
    }

    public partial class OptionalPartList
    {
        [JsonProperty("default_quantity")]
        public long DefaultQuantity { get; set; }

        [JsonProperty("part_type_name")]
        public string PartTypeName { get; set; }

        [JsonProperty("part_type_id")]
        public long PartTypeId { get; set; }

        [JsonProperty("part_category_id")]
        public long? PartCategoryId { get; set; }

        [JsonProperty("part_type_notes")]
        public string PartTypeNotes { get; set; }

        [JsonProperty("product_id")]
        public long ProductId { get; set; }

        [JsonProperty("part_list")]
        public PartList[] PartList { get; set; }

        [JsonProperty("is_optional")]
        public long IsOptional { get; set; }

        [JsonProperty("hint")]
        public string Hint { get; set; }

        [JsonProperty("optional_quantity_array")]
        public string OptionalQuantityArray { get; set; }

        [JsonProperty("is_mandatory")]
        public long IsMandatory { get; set; }
    }

    public partial class PartList
    {
        [JsonProperty("part_name")]
        public string PartName { get; set; }

        [JsonProperty("part_id")]
        public long PartId { get; set; }

        [JsonProperty("part_type_id")]
        public long PartTypeId { get; set; }

        [JsonProperty("product_id")]
        public long ProductId { get; set; }

        [JsonProperty("material_part_price")]
        public double MaterialPartPrice { get; set; }

        [JsonProperty("part_is_deleted")]
        public long PartIsDeleted { get; set; }

        [JsonProperty("sale_part_price")]
        public double SalePartPrice { get; set; }

        [JsonProperty("is_default")]
        public long IsDefault { get; set; }

        [JsonProperty("part_code")]
        public string PartCode { get; set; }

        [JsonProperty("sale_status")]
        public long SaleStatus { get; set; }
    }

    public partial class PlatformPartList
    {
        [JsonProperty("part_name")]
        public PartName PartName { get; set; }

        [JsonProperty("part_id")]
        public long PartId { get; set; }

        [JsonProperty("supplier_model")]
        public SupplierModel SupplierModel { get; set; }

        [JsonProperty("part_category_id")]
        public object PartCategoryId { get; set; }

        [JsonProperty("operator_id")]
        public long OperatorId { get; set; }

        [JsonProperty("sale_part_price")]
        public double SalePartPrice { get; set; }

        [JsonProperty("part_type_name")]
        public PartTypeName PartTypeName { get; set; }

        [JsonProperty("material_part_price")]
        public double MaterialPartPrice { get; set; }

        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        [JsonProperty("backlog_flg")]
        public long BacklogFlg { get; set; }

        [JsonProperty("product_type_id")]
        public long ProductTypeId { get; set; }

        [JsonProperty("shelf_life")]
        public long? ShelfLife { get; set; }

        [JsonProperty("part_type_id")]
        public long PartTypeId { get; set; }

        [JsonProperty("part_type_notes")]
        public string PartTypeNotes { get; set; }

        [JsonProperty("part_is_deleted")]
        public long PartIsDeleted { get; set; }

        [JsonProperty("is_promotional")]
        public long IsPromotional { get; set; }

        [JsonProperty("product_platform_id")]
        public ProductPlatformId ProductPlatformId { get; set; }

        [JsonProperty("part_type_type")]
        public long PartTypeType { get; set; }

        [JsonProperty("whole_sale_flg")]
        public long WholeSaleFlg { get; set; }

        [JsonProperty("creator_id")]
        public long CreatorId { get; set; }

        [JsonProperty("sale_status")]
        public long SaleStatus { get; set; }

        [JsonProperty("is_deleted")]
        public long IsDeleted { get; set; }

        [JsonProperty("update_time")]
        public DateTimeOffset UpdateTime { get; set; }

        [JsonProperty("bulk_sale_flg")]
        public long BulkSaleFlg { get; set; }

        [JsonProperty("create_time")]
        public DateTimeOffset CreateTime { get; set; }

        [JsonProperty("part_code")]
        public PartCode PartCode { get; set; }

        [JsonProperty("notes")]
        public Notes Notes { get; set; }
    }

    public partial class ProductConfigDataList
    {
        [JsonProperty("part_name")]
        public string PartName { get; set; }

        [JsonProperty("part_id")]
        public long PartId { get; set; }

        [JsonProperty("supplier_model")]
        public string SupplierModel { get; set; }

        [JsonProperty("part_type_name")]
        public string PartTypeName { get; set; }

        [JsonProperty("part_type_notes")]
        public string PartTypeNotes { get; set; }

        [JsonProperty("product_id")]
        public long ProductId { get; set; }

        [JsonProperty("material_part_price")]
        public double MaterialPartPrice { get; set; }

        [JsonProperty("product_config_id")]
        public long ProductConfigId { get; set; }

        [JsonProperty("sale_part_price")]
        public double SalePartPrice { get; set; }

        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        [JsonProperty("part_code")]
        public string PartCode { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("sale_status")]
        public long SaleStatus { get; set; }
    }

    public enum RName { 陈敬熙 };

    public enum Notes { Empty, 泰硕酷冷可选默认包含散热片底座 };

    public enum PartCode { Cdrcscxxxxxsvr0001, Ctngen089506750250, NA, Snktsl2Ubp20110001, Snktsl2Ubp36470001 };

    public enum PartName { SocketSp33647Pin2U被动散热片, The2011Pin2U被动散热片, The2U8盘12盘服务器包装, 服务器NrE费用, 服务器随机光盘 };

    public enum PartTypeName { N01服务器Nre, N04服务器散热片, N09服务器包装箱, N15服务器光盘 };

    public enum ProductPlatformId { Ia521, Ib521 };

    public enum SupplierModel { NA, 原包装, 泰硕, 泰硕1A07425700960, 自制 };

    public partial class Quotation
    {
        public static Quotation FromJson(string json) => JsonConvert.DeserializeObject<Quotation>(json, QuickType.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Quotation self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                RNameConverter.Singleton,
                NotesConverter.Singleton,
                PartCodeConverter.Singleton,
                PartNameConverter.Singleton,
                PartTypeNameConverter.Singleton,
                ProductPlatformIdConverter.Singleton,
                SupplierModelConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class RNameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RName) || t == typeof(RName?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "陈敬熙")
            {
                return RName.陈敬熙;
            }
            throw new Exception("Cannot unmarshal type RName");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (RName)untypedValue;
            if (value == RName.陈敬熙)
            {
                serializer.Serialize(writer, "陈敬熙");
                return;
            }
            throw new Exception("Cannot marshal type RName");
        }

        public static readonly RNameConverter Singleton = new RNameConverter();
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

    internal class NotesConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Notes) || t == typeof(Notes?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "":
                    return Notes.Empty;
                case "泰硕、酷冷可选；\n默认包含散热片底座；":
                    return Notes.泰硕酷冷可选默认包含散热片底座;
            }
            throw new Exception("Cannot unmarshal type Notes");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Notes)untypedValue;
            switch (value)
            {
                case Notes.Empty:
                    serializer.Serialize(writer, "");
                    return;
                case Notes.泰硕酷冷可选默认包含散热片底座:
                    serializer.Serialize(writer, "泰硕、酷冷可选；\n默认包含散热片底座；");
                    return;
            }
            throw new Exception("Cannot marshal type Notes");
        }

        public static readonly NotesConverter Singleton = new NotesConverter();
    }

    internal class PartCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PartCode) || t == typeof(PartCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "CDRCSCXXXXXSVR0001":
                    return PartCode.Cdrcscxxxxxsvr0001;
                case "CTNGEN089506750250":
                    return PartCode.Ctngen089506750250;
                case "N/A":
                    return PartCode.NA;
                case "SNKTSL2UBP20110001":
                    return PartCode.Snktsl2Ubp20110001;
                case "SNKTSL2UBP36470001":
                    return PartCode.Snktsl2Ubp36470001;
            }
            throw new Exception("Cannot unmarshal type PartCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PartCode)untypedValue;
            switch (value)
            {
                case PartCode.Cdrcscxxxxxsvr0001:
                    serializer.Serialize(writer, "CDRCSCXXXXXSVR0001");
                    return;
                case PartCode.Ctngen089506750250:
                    serializer.Serialize(writer, "CTNGEN089506750250");
                    return;
                case PartCode.NA:
                    serializer.Serialize(writer, "N/A");
                    return;
                case PartCode.Snktsl2Ubp20110001:
                    serializer.Serialize(writer, "SNKTSL2UBP20110001");
                    return;
                case PartCode.Snktsl2Ubp36470001:
                    serializer.Serialize(writer, "SNKTSL2UBP36470001");
                    return;
            }
            throw new Exception("Cannot marshal type PartCode");
        }

        public static readonly PartCodeConverter Singleton = new PartCodeConverter();
    }

    internal class PartNameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PartName) || t == typeof(PartName?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "2011pin 2U被动散热片":
                    return PartName.The2011Pin2U被动散热片;
                case "2U 8盘/12盘服务器包装":
                    return PartName.The2U8盘12盘服务器包装;
                case "Socket SP3 3647pin 2U被动散热片":
                    return PartName.SocketSp33647Pin2U被动散热片;
                case "服务器NRE费用":
                    return PartName.服务器NrE费用;
                case "服务器随机光盘":
                    return PartName.服务器随机光盘;
            }
            throw new Exception("Cannot unmarshal type PartName");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PartName)untypedValue;
            switch (value)
            {
                case PartName.The2011Pin2U被动散热片:
                    serializer.Serialize(writer, "2011pin 2U被动散热片");
                    return;
                case PartName.The2U8盘12盘服务器包装:
                    serializer.Serialize(writer, "2U 8盘/12盘服务器包装");
                    return;
                case PartName.SocketSp33647Pin2U被动散热片:
                    serializer.Serialize(writer, "Socket SP3 3647pin 2U被动散热片");
                    return;
                case PartName.服务器NrE费用:
                    serializer.Serialize(writer, "服务器NRE费用");
                    return;
                case PartName.服务器随机光盘:
                    serializer.Serialize(writer, "服务器随机光盘");
                    return;
            }
            throw new Exception("Cannot marshal type PartName");
        }

        public static readonly PartNameConverter Singleton = new PartNameConverter();
    }

    internal class PartTypeNameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PartTypeName) || t == typeof(PartTypeName?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "N01 服务器NRE":
                    return PartTypeName.N01服务器Nre;
                case "N04 服务器散热片":
                    return PartTypeName.N04服务器散热片;
                case "N09 服务器包装箱":
                    return PartTypeName.N09服务器包装箱;
                case "N15 服务器光盘":
                    return PartTypeName.N15服务器光盘;
            }
            throw new Exception("Cannot unmarshal type PartTypeName");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PartTypeName)untypedValue;
            switch (value)
            {
                case PartTypeName.N01服务器Nre:
                    serializer.Serialize(writer, "N01 服务器NRE");
                    return;
                case PartTypeName.N04服务器散热片:
                    serializer.Serialize(writer, "N04 服务器散热片");
                    return;
                case PartTypeName.N09服务器包装箱:
                    serializer.Serialize(writer, "N09 服务器包装箱");
                    return;
                case PartTypeName.N15服务器光盘:
                    serializer.Serialize(writer, "N15 服务器光盘");
                    return;
            }
            throw new Exception("Cannot marshal type PartTypeName");
        }

        public static readonly PartTypeNameConverter Singleton = new PartTypeNameConverter();
    }

    internal class ProductPlatformIdConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ProductPlatformId) || t == typeof(ProductPlatformId?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "IA521":
                    return ProductPlatformId.Ia521;
                case "IB521":
                    return ProductPlatformId.Ib521;
            }
            throw new Exception("Cannot unmarshal type ProductPlatformId");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ProductPlatformId)untypedValue;
            switch (value)
            {
                case ProductPlatformId.Ia521:
                    serializer.Serialize(writer, "IA521");
                    return;
                case ProductPlatformId.Ib521:
                    serializer.Serialize(writer, "IB521");
                    return;
            }
            throw new Exception("Cannot marshal type ProductPlatformId");
        }

        public static readonly ProductPlatformIdConverter Singleton = new ProductPlatformIdConverter();
    }

    internal class SupplierModelConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SupplierModel) || t == typeof(SupplierModel?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "N/A":
                    return SupplierModel.NA;
                case "原包装":
                    return SupplierModel.原包装;
                case "泰硕":
                    return SupplierModel.泰硕;
                case "泰硕1A0-7425700960":
                    return SupplierModel.泰硕1A07425700960;
                case "自制":
                    return SupplierModel.自制;
            }
            throw new Exception("Cannot unmarshal type SupplierModel");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (SupplierModel)untypedValue;
            switch (value)
            {
                case SupplierModel.NA:
                    serializer.Serialize(writer, "N/A");
                    return;
                case SupplierModel.原包装:
                    serializer.Serialize(writer, "原包装");
                    return;
                case SupplierModel.泰硕:
                    serializer.Serialize(writer, "泰硕");
                    return;
                case SupplierModel.泰硕1A07425700960:
                    serializer.Serialize(writer, "泰硕1A0-7425700960");
                    return;
                case SupplierModel.自制:
                    serializer.Serialize(writer, "自制");
                    return;
            }
            throw new Exception("Cannot marshal type SupplierModel");
        }

        public static readonly SupplierModelConverter Singleton = new SupplierModelConverter();
    }
}
