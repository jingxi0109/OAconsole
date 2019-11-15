using System;
using System.Collections.Generic;

public partial class ConfigList
{
    public Result Result { get; set; }
    public object PageSize { get; set; }
    public long Count { get; set; }
    public object PageIndex { get; set; }
    public string Token { get; set; }
    public Extra Extra { get; set; }
    public string ResultType { get; set; }
    public object ResultMessage { get; set; }
    public object SEcho { get; set; }
}

public partial class Extra
{
    public long AcceptedCount { get; set; }
}

public partial class Result
{
    public long LastIdInPreviousPage { get; set; }
    public long Count { get; set; }
    public Extra Extra { get; set; }
    public double SerialVersionUid { get; set; }
    public List<List> List { get; set; }
    public object SEcho { get; set; }
}

public partial class List
{
    public string QuotationSerialNumber { get; set; }
    public object SnCode { get; set; }
    public long ServicePriceCompany { get; set; }
    public string CalFrom { get; set; }
    public object WorkOrderCode { get; set; }
    public string OwnerName { get; set; }
    public long ProductId { get; set; }
    public object TrialTestId { get; set; }
    public string CurrentApprovalUserName { get; set; }
    public double UnitPrice { get; set; }
    public string QuotationCurrentApprovalUserName { get; set; }
    public object StockApprovalId { get; set; }
    public long ServicePricePublic { get; set; }
    public long Quantity { get; set; }
    public long UnitPriceMaterial { get; set; }
    public long ProductTypeId { get; set; }
    public long PartPriceMaterial { get; set; }
    public long ServicePriceMaterial { get; set; }
    public double DiscountedTotalPrice { get; set; }
    public double UnitPricePublic { get; set; }
    public object OpportunityId { get; set; }
    public long DiscountRate { get; set; }
    public double DiscountedTotalPricePart { get; set; }
    public object TrialTestUnitPrice { get; set; }
    public string StockCurrentApprovalUserName { get; set; }
    public string ProductPlatformId { get; set; }
    public long ApprovalStatus { get; set; }
    public string ProductConfigName { get; set; }
    public string ApprovalId { get; set; }
    public double TotalPrice { get; set; }
    public long SaleStatus { get; set; }
    public long CreatorId { get; set; }
    public string ProductTypeName { get; set; }
    public DateTimeOffset UpdateTime { get; set; }
    public object UnitPriceService { get; set; }
    public double UnitPriceCompany { get; set; }
    public object StockQuantity { get; set; }
    public string ProductNotes { get; set; }
    public long ApprovalNeedUserType { get; set; }
    public double DiscountedUnitPricePart { get; set; }
    public Creator Owner { get; set; }
    public DateTimeOffset CreateTime { get; set; }
    public string CreatorName { get; set; }
    public object TrialTestTotalPrice { get; set; }
    public object SpecialRequirementId { get; set; }
    public long? QuotationId { get; set; }
    public long OperatorId { get; set; }
    public string ProductName { get; set; }
    public string ProductDesc { get; set; }
    public object StockCode { get; set; }
    public object TrialTestCode { get; set; }
    public Creator Creator { get; set; }
    public double UnitPriceSale { get; set; }
    public string ProductTypePath { get; set; }
    public long ProductConfigId { get; set; }
    public double UnitPriceManager { get; set; }
    public long? QuotationApprovalStatus { get; set; }
    public double PartPriceManager { get; set; }
    public long? QuotationStatus { get; set; }
    public double PartPricePublic { get; set; }
    public string OperatorName { get; set; }
    public double PartPriceCompany { get; set; }
    public object StockApprovalStatus { get; set; }
    public double PartPriceSale { get; set; }
    public long ServicePriceManager { get; set; }
    public object TrialTestApprovalStatus { get; set; }
    public object StockId { get; set; }
    public string TrialTestCurrentApprovalUserName { get; set; }
    public object TrialTestApprovalId { get; set; }
    public Creator Operator { get; set; }
    public long ServicePriceSale { get; set; }
    public long IsDeleted { get; set; }
    public double DiscountedUnitPrice { get; set; }
    public string QuotationApprovalId { get; set; }
    public object TrialTestQuantity { get; set; }
    public long OwnerId { get; set; }
    public string ProductConfigCode { get; set; }
}

public partial class Creator
{
    public string UserName { get; set; }
    public long UserId { get; set; }
}

