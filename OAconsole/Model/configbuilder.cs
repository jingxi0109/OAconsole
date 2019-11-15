﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QT_configbuilder;
//
//    var configbuilder = Configbuilder.FromJson(jsonString);

namespace QT_configbuilder
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Configbuilder
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
        public object QuotationSerialNumber { get; set; }

        [JsonProperty("sn_code")]
        public object SnCode { get; set; }

        [JsonProperty("service_price_company")]
        public long ServicePriceCompany { get; set; }

        [JsonProperty("cal_from")]
        public object CalFrom { get; set; }

        [JsonProperty("work_order_code")]
        public object WorkOrderCode { get; set; }

        [JsonProperty("owner_name")]
        public string OwnerName { get; set; }

        [JsonProperty("product_id")]
        public long ProductId { get; set; }

        [JsonProperty("trial_test_id")]
        public object TrialTestId { get; set; }

        [JsonProperty("current_approval_user_name")]
        public string CurrentApprovalUserName { get; set; }

        [JsonProperty("unit_price")]
        public double UnitPrice { get; set; }

        [JsonProperty("quotation_current_approval_user_name")]
        public string QuotationCurrentApprovalUserName { get; set; }

        [JsonProperty("stock_approval_id")]
        public object StockApprovalId { get; set; }

        [JsonProperty("service_price_public")]
        public long ServicePricePublic { get; set; }

        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        [JsonProperty("unit_price_material")]
        public double UnitPriceMaterial { get; set; }

        [JsonProperty("product_type_id")]
        public long ProductTypeId { get; set; }

        [JsonProperty("part_price_material")]
        public double PartPriceMaterial { get; set; }

        [JsonProperty("service_price_material")]
        public long ServicePriceMaterial { get; set; }

        [JsonProperty("discounted_total_price")]
        public long DiscountedTotalPrice { get; set; }

        [JsonProperty("unit_price_public")]
        public double UnitPricePublic { get; set; }

        [JsonProperty("opportunity_id")]
        public object OpportunityId { get; set; }

        [JsonProperty("discount_rate")]
        public long DiscountRate { get; set; }

        [JsonProperty("discounted_total_price_part")]
        public long DiscountedTotalPricePart { get; set; }

        [JsonProperty("trial_test_unit_price")]
        public object TrialTestUnitPrice { get; set; }

        [JsonProperty("stock_current_approval_user_name")]
        public string StockCurrentApprovalUserName { get; set; }

        [JsonProperty("product_platform_id")]
        public string ProductPlatformId { get; set; }

        [JsonProperty("approval_status")]
        public long ApprovalStatus { get; set; }

        [JsonProperty("product_config_name")]
        public string ProductConfigName { get; set; }

        [JsonProperty("approval_id")]
        public string ApprovalId { get; set; }

        [JsonProperty("total_price")]
        public long TotalPrice { get; set; }

        [JsonProperty("sale_status")]
        public long SaleStatus { get; set; }

        [JsonProperty("creator_id")]
        public long CreatorId { get; set; }

        [JsonProperty("is_on_sale")]
        public long IsOnSale { get; set; }

        [JsonProperty("product_type_name")]
        public string ProductTypeName { get; set; }

        [JsonProperty("update_time")]
        public DateTimeOffset UpdateTime { get; set; }

        [JsonProperty("optional_part_list")]
        public List<OptionalPartList> OptionalPartList { get; set; }

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
        public long DiscountedUnitPricePart { get; set; }

        [JsonProperty("owner")]
        public Creator Owner { get; set; }

        [JsonProperty("create_time")]
        public DateTimeOffset CreateTime { get; set; }

        [JsonProperty("creator_name")]
        public string CreatorName { get; set; }

        [JsonProperty("trial_test_total_price")]
        public object TrialTestTotalPrice { get; set; }

        [JsonProperty("special_requirement_id")]
        public object SpecialRequirementId { get; set; }

        [JsonProperty("quotation_id")]
        public object QuotationId { get; set; }

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
        public List<object> ProductConfigServiceDataList { get; set; }

        [JsonProperty("unit_price_sale")]
        public double UnitPriceSale { get; set; }

        [JsonProperty("product_type_path")]
        public string ProductTypePath { get; set; }

        [JsonProperty("product_config_id")]
        public long ProductConfigId { get; set; }

        [JsonProperty("unit_price_manager")]
        public double UnitPriceManager { get; set; }

        [JsonProperty("quotation_approval_status")]
        public object QuotationApprovalStatus { get; set; }

        [JsonProperty("part_price_manager")]
        public double PartPriceManager { get; set; }

        [JsonProperty("quotation_status")]
        public object QuotationStatus { get; set; }

        [JsonProperty("part_price_public")]
        public double PartPricePublic { get; set; }

        [JsonProperty("operator_name")]
        public string OperatorName { get; set; }

        [JsonProperty("part_price_company")]
        public double PartPriceCompany { get; set; }

        [JsonProperty("stock_approval_status")]
        public object StockApprovalStatus { get; set; }

        [JsonProperty("part_price_sale")]
        public double PartPriceSale { get; set; }

        [JsonProperty("service_price_manager")]
        public long ServicePriceManager { get; set; }

        [JsonProperty("trial_test_approval_status")]
        public object TrialTestApprovalStatus { get; set; }

        [JsonProperty("product_config_data_list")]
        public List<ProductConfigDataList> ProductConfigDataList { get; set; }

        [JsonProperty("stock_id")]
        public object StockId { get; set; }

        [JsonProperty("trial_test_current_approval_user_name")]
        public string TrialTestCurrentApprovalUserName { get; set; }

        [JsonProperty("trial_test_approval_id")]
        public object TrialTestApprovalId { get; set; }

        [JsonProperty("operator")]
        public Creator Operator { get; set; }

        [JsonProperty("service_price_sale")]
        public long ServicePriceSale { get; set; }

        [JsonProperty("is_deleted")]
        public long IsDeleted { get; set; }

        [JsonProperty("discounted_unit_price")]
        public long DiscountedUnitPrice { get; set; }

        [JsonProperty("quotation_approval_id")]
        public string QuotationApprovalId { get; set; }

        [JsonProperty("trial_test_quantity")]
        public object TrialTestQuantity { get; set; }

        [JsonProperty("owner_id")]
        public long OwnerId { get; set; }

        [JsonProperty("product_config_code")]
        public string ProductConfigCode { get; set; }

        [JsonProperty("platform_part_list")]
        public List<PlatformPartList> PlatformPartList { get; set; }
    }

    public partial class Creator
    {
        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("user_id")]
        public long UserId { get; set; }
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
        public List<PartList> PartList { get; set; }

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
        public string PartName { get; set; }

        [JsonProperty("part_id")]
        public long PartId { get; set; }

        [JsonProperty("supplier_model")]
        public string SupplierModel { get; set; }

        [JsonProperty("part_category_id")]
        public object PartCategoryId { get; set; }

        [JsonProperty("operator_id")]
        public long OperatorId { get; set; }

        [JsonProperty("sale_part_price")]
        public double SalePartPrice { get; set; }

        [JsonProperty("part_type_name")]
        public string PartTypeName { get; set; }

        [JsonProperty("material_part_price")]
        public long MaterialPartPrice { get; set; }

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
        public string ProductPlatformId { get; set; }

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
        public string PartCode { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
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

    public partial class Configbuilder
    {
        public static Configbuilder FromJson(string json) => JsonConvert.DeserializeObject<Configbuilder>(json, QT_configbuilder.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Configbuilder self) => JsonConvert.SerializeObject(self, QT_configbuilder.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
