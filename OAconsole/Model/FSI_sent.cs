﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var sent = Sent.FromJson(jsonString);

namespace FsiSent
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Sent
    {
        [JsonProperty("org_name")]
        public object OrgName { get; set; }

        [JsonProperty("owner_name")]
        public string OwnerName { get; set; }

        [JsonProperty("expense_amount")]
        public double ExpenseAmount { get; set; }

        [JsonProperty("expense_type")]
        public long ExpenseType { get; set; }

        [JsonProperty("operator_id")]
        public long OperatorId { get; set; }

        [JsonProperty("owner_org_name")]
        public string OwnerOrgName { get; set; }

        [JsonProperty("expense_notes")]
        public string ExpenseNotes { get; set; }

        [JsonProperty("beforehand_id")]
        public object BeforehandId { get; set; }

        [JsonProperty("current_approval_user_name")]
        public string CurrentApprovalUserName { get; set; }

        [JsonProperty("owner_mobile")]
        public string OwnerMobile { get; set; }

        [JsonProperty("corporation")]
        public long Corporation { get; set; }

        [JsonProperty("payment_status")]
        public long PaymentStatus { get; set; }

        [JsonProperty("owner_email")]
        public string OwnerEmail { get; set; }

        [JsonProperty("expense_bill_name")]
        public string ExpenseBillName { get; set; }

        [JsonProperty("owner_open_id")]
        public string OwnerOpenId { get; set; }

        [JsonProperty("creator_open_id")]
        public string CreatorOpenId { get; set; }

        [JsonProperty("bill_no")]
        public string BillNo { get; set; }

        [JsonProperty("beforehand_name")]
        public object BeforehandName { get; set; }

        [JsonProperty("application_time")]
        public string ApplicationTime { get; set; }

        [JsonProperty("application_contents")]
        public string ApplicationContents { get; set; }

        [JsonProperty("receive_status")]
        public long ReceiveStatus { get; set; }

        [JsonProperty("beforehand_bill_no")]
        public object BeforehandBillNo { get; set; }

        [JsonProperty("approval_status")]
        public long ApprovalStatus { get; set; }

        [JsonProperty("paymentItemList")]
        public List<PaymentItemList> PaymentItemList { get; set; }

        [JsonProperty("creator_email")]
        public string CreatorEmail { get; set; }

        [JsonProperty("invoice_number")]
        public long InvoiceNumber { get; set; }

        [JsonProperty("approval_id")]
        public long ApprovalId { get; set; }

        [JsonProperty("creator_id")]
        public long CreatorId { get; set; }

        [JsonProperty("org_id")]
        public object OrgId { get; set; }

        [JsonProperty("is_deleted")]
        public long IsDeleted { get; set; }

        [JsonProperty("update_time")]
        public string UpdateTime { get; set; }

        [JsonProperty("create_time")]
        public string CreateTime { get; set; }

        [JsonProperty("owner_id")]
        public long OwnerId { get; set; }

        [JsonProperty("creator_name")]
        public string CreatorName { get; set; }

        [JsonProperty("expense_bill_id")]
        public long ExpenseBillId { get; set; }

        [JsonProperty("creator_mobile")]
        public string CreatorMobile { get; set; }

        [JsonProperty("approval_comments")]
        public string ApprovalComments { get; set; }

        [JsonProperty("application_type")]
        public long ApplicationType { get; set; }

        [JsonProperty("logs")]
        public List<Log> Logs { get; set; }

        [JsonProperty("application_user")]
        public User ApplicationUser { get; set; }

        [JsonProperty("is_finance_flg")]
        public long IsFinanceFlg { get; set; }

        [JsonProperty("current_application_time")]
        public string CurrentApplicationTime { get; set; }

        [JsonProperty("record_id")]
        public long RecordId { get; set; }

        [JsonProperty("record")]
        public Record Record { get; set; }

        [JsonProperty("current_approval_user")]
        public User CurrentApprovalUser { get; set; }

        [JsonProperty("application_user_name")]
        public string ApplicationUserName { get; set; }

        [JsonProperty("current_approval_user_id")]
        public long CurrentApprovalUserId { get; set; }

        [JsonProperty("approval_times")]
        public long ApprovalTimes { get; set; }

        [JsonProperty("application_user_id")]
        public long ApplicationUserId { get; set; }

        [JsonProperty("page_mode")]
        public string PageMode { get; set; }

        [JsonProperty("input_risk")]
        public string InputRisk { get; set; }

        [JsonProperty("input_risk_control_action")]
        public string InputRiskControlAction { get; set; }

        [JsonProperty("risk_control_actions")]
        public string RiskControlActions { get; set; }

        [JsonProperty("identified_risks")]
        public string IdentifiedRisks { get; set; }
    }

    public partial class User
    {
        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("user_id")]
        public long UserId { get; set; }
    }

    public partial class Log
    {
        [JsonProperty("approval_comments")]
        public string ApprovalComments { get; set; }

        [JsonProperty("approval_user_id")]
        public long ApprovalUserId { get; set; }

        [JsonProperty("business_user_type")]
        public long BusinessUserType { get; set; }

        [JsonProperty("approval_status")]
        public long ApprovalStatus { get; set; }

        [JsonProperty("approval_id")]
        public long ApprovalId { get; set; }

        [JsonProperty("expense_bill_approval_id")]
        public long ExpenseBillApprovalId { get; set; }

        [JsonProperty("sale_user_type")]
        public long SaleUserType { get; set; }

        [JsonProperty("approval_user")]
        public User ApprovalUser { get; set; }

        [JsonProperty("approval_level")]
        public object ApprovalLevel { get; set; }

        [JsonProperty("approval_time")]
        public string? ApprovalTime { get; set; }

        [JsonProperty("approval_user_name")]
        public string ApprovalUserName { get; set; }

        [JsonProperty("expense_bill_id")]
        public long ExpenseBillId { get; set; }

        [JsonProperty("finance_user_type")]
        public long FinanceUserType { get; set; }

        [JsonProperty("application_time")]
        public string ApplicationTime { get; set; }
    }

    public partial class PaymentItemList
    {
        [JsonProperty("payment_item_type_id")]
        public long PaymentItemTypeId { get; set; }

        [JsonProperty("owner_name")]
        public string OwnerName { get; set; }

        [JsonProperty("payment_item_id")]
        public long PaymentItemId { get; set; }

        [JsonProperty("operator_id")]
        public long OperatorId { get; set; }

        [JsonProperty("owner_org_name")]
        public string OwnerOrgName { get; set; }

        [JsonProperty("generation_date")]
        public string GenerationDate { get; set; }

        [JsonProperty("creator_email")]
        public string CreatorEmail { get; set; }

        [JsonProperty("remarks")]
        public object Remarks { get; set; }

        [JsonProperty("owner_mobile")]
        public string OwnerMobile { get; set; }

        [JsonProperty("payment_item_type_name")]
        public string PaymentItemTypeName { get; set; }

        [JsonProperty("creator_id")]
        public long CreatorId { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("owner_email")]
        public string OwnerEmail { get; set; }

        [JsonProperty("is_deleted")]
        public long IsDeleted { get; set; }

        [JsonProperty("payment_item_name")]
        public string PaymentItemName { get; set; }

        [JsonProperty("update_time")]
        public string UpdateTime { get; set; }

        [JsonProperty("create_time")]
        public string CreateTime { get; set; }

        [JsonProperty("owner_id")]
        public long OwnerId { get; set; }

        [JsonProperty("creator_name")]
        public string CreatorName { get; set; }

        [JsonProperty("expense_bill_id")]
        public long ExpenseBillId { get; set; }

        [JsonProperty("owner_open_id")]
        public string OwnerOpenId { get; set; }

        [JsonProperty("creator_open_id")]
        public string CreatorOpenId { get; set; }

        [JsonProperty("invoice_no")]
        public object InvoiceNo { get; set; }

        [JsonProperty("creator_mobile")]
        public string CreatorMobile { get; set; }
    }

    public partial class Record
    {
        [JsonProperty("org_name")]
        public object OrgName { get; set; }

        [JsonProperty("owner_name")]
        public string OwnerName { get; set; }

        [JsonProperty("expense_amount")]
        public double ExpenseAmount { get; set; }

        [JsonProperty("expense_type")]
        public long ExpenseType { get; set; }

        [JsonProperty("operator_id")]
        public long OperatorId { get; set; }

        [JsonProperty("owner_org_name")]
        public string OwnerOrgName { get; set; }

        [JsonProperty("expense_notes")]
        public string ExpenseNotes { get; set; }

        [JsonProperty("beforehand_id")]
        public object BeforehandId { get; set; }

        [JsonProperty("current_approval_user_name")]
        public string CurrentApprovalUserName { get; set; }

        [JsonProperty("owner_mobile")]
        public string OwnerMobile { get; set; }

        [JsonProperty("corporation")]
        public long Corporation { get; set; }

        [JsonProperty("payment_status")]
        public long PaymentStatus { get; set; }

        [JsonProperty("owner_email")]
        public string OwnerEmail { get; set; }

        [JsonProperty("expense_bill_name")]
        public string ExpenseBillName { get; set; }

        [JsonProperty("owner_open_id")]
        public string OwnerOpenId { get; set; }

        [JsonProperty("creator_open_id")]
        public string CreatorOpenId { get; set; }

        [JsonProperty("bill_no")]
        public string BillNo { get; set; }

        [JsonProperty("beforehand_name")]
        public object BeforehandName { get; set; }

        [JsonProperty("application_time")]
        public string ApplicationTime { get; set; }

        [JsonProperty("application_contents")]
        public string ApplicationContents { get; set; }

        [JsonProperty("receive_status")]
        public long ReceiveStatus { get; set; }

        [JsonProperty("beforehand_bill_no")]
        public object BeforehandBillNo { get; set; }

        [JsonProperty("approval_status")]
        public long ApprovalStatus { get; set; }

        [JsonProperty("paymentItemList")]
        public List<PaymentItemList> PaymentItemList { get; set; }

        [JsonProperty("creator_email")]
        public string CreatorEmail { get; set; }

        [JsonProperty("invoice_number")]
        public long InvoiceNumber { get; set; }

        [JsonProperty("approval_id")]
        public long ApprovalId { get; set; }

        [JsonProperty("creator_id")]
        public long CreatorId { get; set; }

        [JsonProperty("org_id")]
        public object OrgId { get; set; }

        [JsonProperty("is_deleted")]
        public long IsDeleted { get; set; }

        [JsonProperty("update_time")]
        public string UpdateTime { get; set; }

        [JsonProperty("create_time")]
        public string CreateTime { get; set; }

        [JsonProperty("owner_id")]
        public long OwnerId { get; set; }

        [JsonProperty("creator_name")]
        public string CreatorName { get; set; }

        [JsonProperty("expense_bill_id")]
        public long ExpenseBillId { get; set; }

        [JsonProperty("creator_mobile")]
        public string CreatorMobile { get; set; }
    }

    public partial class Sent
    {
        public static Sent FromJson(string json) => JsonConvert.DeserializeObject<Sent>(json, QuickType.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Sent self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
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
