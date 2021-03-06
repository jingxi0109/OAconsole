﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var pay = Pay.FromJson(jsonString);

namespace QuickType_pay
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Pay
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
        [JsonProperty("org_name")]
        public object OrgName { get; set; }

        [JsonProperty("owner_name")]
        public string OwnerName { get; set; }

        [JsonProperty("expense_amount")]
        public long ExpenseAmount { get; set; }

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
        public object OwnerOpenId { get; set; }

        [JsonProperty("creator_open_id")]
        public object CreatorOpenId { get; set; }

        [JsonProperty("bill_no")]
        public string BillNo { get; set; }

        [JsonProperty("beforehand_name")]
        public object BeforehandName { get; set; }

        [JsonProperty("application_time")]
        public DateTimeOffset ApplicationTime { get; set; }

        [JsonProperty("application_contents")]
        public string ApplicationContents { get; set; }

        [JsonProperty("receive_status")]
        public long ReceiveStatus { get; set; }

        [JsonProperty("beforehand_bill_no")]
        public object BeforehandBillNo { get; set; }

        [JsonProperty("approval_status")]
        public long ApprovalStatus { get; set; }

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
        public DateTimeOffset UpdateTime { get; set; }

        [JsonProperty("create_time")]
        public DateTimeOffset CreateTime { get; set; }

        [JsonProperty("owner_id")]
        public long OwnerId { get; set; }

        [JsonProperty("creator_name")]
        public string CreatorName { get; set; }

        [JsonProperty("expense_bill_id")]
        public long ExpenseBillId { get; set; }

        [JsonProperty("creator_mobile")]
        public string CreatorMobile { get; set; }
    }

    public partial class Pay
    {
        public static Pay FromJson(string json) => JsonConvert.DeserializeObject<Pay>(json, QuickType.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Pay self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
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
