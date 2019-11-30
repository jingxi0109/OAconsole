using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace OAconsole
{
    public class Access_OA
    {

        static string jsid = "";
        static string token = "";
        //static string loginID = "chenjx@chinasupercloud.com";
        //static string passcode = "Winsows200";
        static string loginID = "quxy@chinasupercloud.com";
        static string passcode = "14524968";
        public static string Jsid { get => jsid; }
        public static string Token { get => token; }
        public static string LoginID { get => loginID; set => loginID = value; }
        public static string Passcode { get => passcode; set => passcode = value; }
        

        public static void Test_index()
        {
            Get_verycode();
            Console.WriteLine("input the verify code.");
            Request_Login(Console.ReadLine());

            FSI_Test();
            //   var respo = get_ConfigData("38659", Jsid);
            //      Console.WriteLine(respo.ToJson());
            // var res = 
            ////////////var list=     GetConfigList(2);
            ////////////foreach (var res in list.Result.List)
            //////////// {
            ////////////     Console.WriteLine(res.ProductName);
            ////////////     Console.WriteLine(res.ProductConfigId);
            ////////////     Get_Config_details(res.ProductConfigId.ToString(), jsid);
            //////////// //    Console.WriteLine(res.ProductDesc );
            //////////// }
            //  Console.WriteLine(res.Result.Count);
        }
        public static void FSI_Test()
        {
         //   string a = FsiData("24381");
         // //    Console.WriteLine(a );
         //   Fsi_BatAppapproval(a);

         //   string b = FsiData("22432");
         ////   Console.WriteLine(b);
         //   Fsi_BatAppapproval(b);

         //   string c = FsiData("24360");
         // //  Console.WriteLine(c);
         //   Fsi_BatAppapproval(c);

         //   string d = FsiData("24270");
         ////   Console.WriteLine(d);
         //   Fsi_BatAppapproval(d);
            //       Console.WriteLine(FsiData("24655"));
            //     Console.WriteLine(FsiData("24111"));
            //     Console.WriteLine(FsiData("23732"));
            //    Console.WriteLine(FsiData("20549"));
            //Fsi_BatAppapproval("24883.");
            //Fsi_BatAppapproval("24655");
            //Fsi_BatAppapproval("24111");
            //Fsi_BatAppapproval("23732");
            //Fsi_BatAppapproval("20549");
        }
        public static string AutoAppoval(string id)
        {
            string ss = "";
            string tmp = FsiData(id);
            ss=Fsi_BatAppapproval(tmp);

            return ss;
        }

        public static Bitmap Get_verycode()
        {
            DateTime startDt = new DateTime(1970, 1, 1);
            TimeSpan timeSpan = DateTime.UtcNow - startDt;
            long millis = (long)timeSpan.TotalMilliseconds;
            // Console.WriteLine(“Hello World!”);
            string a = millis.ToString();

            var client = new RestClient("https://oa.chinasupercloud.com/api/verifycode/generate?timestamp=" + a);
            var request = new RestRequest(Method.GET);
            //   var resp = await client.PostAsync(request,);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Accept-Encoding", "gzip, deflate");
            request.AddHeader("Host", "oa.chinasupercloud.com");
            request.AddHeader("Postman-Token", "fb3cfede-e0a0-44b5-aeac-2e9604187900,e7812152-5ae5-4287-b621-10f06828b6f0");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Accept", "*/*");
            request.AddHeader("User-Agent", "PostmanRuntime/7.18.0");
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            //   request.AddCookie("JSESSIONID", "");
            request.AddCookie("path", "/api/");
            request.AddCookie("domain", "oa.chinasupercloud.com");
            //   request.AddHeader("Cookie", "JSESSIONID=75666D11AC9ECB4FA72E966459FC6382");
            IRestResponse response = client.Execute(request);
            MemoryStream ms = new MemoryStream(response.RawBytes);
            Bitmap bitmap = new Bitmap(ms);
            if (bitmap != null)
            {
                bitmap.Save("code.png", ImageFormat.Png);
            }
            ms.Flush();
            ms.Close();

            //client.CookieContainer.Add(new Cookie("JSESSIONID", "75666D11AC9ECB4FA72E966459FC6382"));
            Console.WriteLine("verify code done.");
            // Console.WriteLine(client.CookieContainer.GetCookieHeader(client.BaseUrl));
            Console.WriteLine(response.Cookies[0].Value);
            jsid = response.Cookies[0].Value;

           

            //foreach (var s in response.Cookies)
            //{
            //    Console.Write(s.Name+"\t");

            //    Console.WriteLine (s.Value);
            //}
            //  Console.WriteLine(request.Parameters );//client.CookieContainer.GetCookies(client.BaseUrl)[0].Name);
            //  Console.WriteLine(client.CookieContainer.GetCookies(client.BaseUrl)[0].Value);
            return bitmap;
        }
        public static bool Request_Login(string verycode)
        {
            var client = new RestClient("https://oa.chinasupercloud.com/api/login");
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Accept-Encoding", "gzip, deflate");
            request.AddHeader("Host", "oa.chinasupercloud.com");
            request.AddHeader("Postman-Token", "fb3cfede-e0a0-44b5-aeac-2e9604187900,e7812152-5ae5-4287-b621-10f06828b6f0");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Accept", "*/*");
            request.AddHeader("User-Agent", "PostmanRuntime/7.18.0");
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddCookie("JSESSIONID", Jsid);
            request.AddCookie("path", "/api/");
            request.AddCookie("domain", "oa.chinasupercloud.com");
            //  request.AddHeader("Cookie", "JSESSIONID=75666D11AC9ECB4FA72E966459FC6382");

            //client.CookieContainer.Add(new Cookie("JSESSIONID", "75666D11AC9ECB4FA72E966459FC6382"));
            Console.WriteLine();
            //    Console.WriteLine(client.CookieContainer.GetCookies(client.BaseUrl)[0].Name);
            //  Console.WriteLine(client.CookieContainer.GetCookies(client.BaseUrl)[0].Value);
            Console.WriteLine("input code.");
            string code = verycode;//Console.ReadLine();

            Console.WriteLine(code);
            request.AddParameter("undefined", "email=" + LoginID + "&password=" + Passcode + "&verycode=" + code, ParameterType.RequestBody);
            IRestResponse responselogin = client.Execute(request);
        //    QuickType_login.Login login = QuickType_login.Login.FromJson(responselogin.Content);
            QT_logon.Logon logon = QT_logon.Logon.FromJson(responselogin.Content);
            token = logon.Token;
            Console.WriteLine(responselogin.Content);

            return responselogin.Content.Contains("SUCCESS");

        }
        public static OAconsole.Model.Srv_Config Get_Config_details(string config_code, string jstemp)
        {
            string code = Convert_Configid(config_code);
            var client = new RestClient("https://oa.chinasupercloud.com/api/productConfig/get?token="+token);
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Cookie", "JSESSIONID=" + jstemp + "; loginName=\"" + LoginID + "\"");
            request.AddHeader("Content-Length", "27");
            request.AddHeader("Accept-Encoding", "gzip, deflate");
            request.AddHeader("Host", "oa.chinasupercloud.com");
            request.AddHeader("Postman-Token", "6a9c2334-a84e-4273-94b4-e08d175736b3,59765b29-c665-4b9e-8946-6746e5aac65c");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Accept", "*/*");
            request.AddHeader("User-Agent", "PostmanRuntime/7.18.0");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined", "{\"product_config_id\":" + code + "}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

           // OAconsole.ConfigList cflist = ConfigList.FromJson(response.Content);
           // QT_Config.ConfigData cdlist = QT_Config.ConfigData.FromJson(response.Content);
            QT_configbuilder.Configbuilder cgf = QT_configbuilder.Configbuilder.FromJson(response.Content);
            //Console.WriteLine(cflist.Result.ProductConfigCode);
            //foreach(var res in cflist.Result.ProductConfigDataList)
            //{
            //    Console.WriteLine(res.PartName+"\t"+res.Quantity.ToString()+"\t"+res.PartCode);
            //}
            //foreach (var res in cflist.Result.PlatformPartList)
            //{
            //    Console.WriteLine(res.PartName + "\t" + res.Quantity.ToString() + "\t" + res.PartCode);
            //}

            OAconsole.Model.Srv_Config sc = new Model.Srv_Config();
            sc.ProductPlatform = cgf.Result.ProductName;
            sc.Token = cgf.Token;
            sc.Part_List = new System.Collections.Generic.List<Model.PartList>();

            foreach(var r in cgf.Result.ProductConfigDataList)
            {
                OAconsole.Model.PartList list = new Model.PartList();
                list.Notes = r.Notes;
                list.PartCode = r.PartCode;
                list.PartId = r.PartId;
                list.PartName = r.PartName;
                list.PartTypeName = r.PartTypeName;
                list.ProductId = r.ProductId.ToString();
                list.SupplierModel = r.SupplierModel;
                list.Quantity = r.Quantity;
                sc.Part_List.Add(list);
                   
            }
            foreach(var s in cgf.Result.PlatformPartList)
            {
                OAconsole.Model.PartList list = new Model.PartList();
                list.Notes = s.Notes;
                list.PartCode = s.PartCode;
                list.PartId = s.PartId ;
                list.PartName = s.PartName;
                list.PartTypeName = s.PartTypeName;
                list.ProductId = s.ProductPlatformId;
                list.Quantity = s.Quantity;
                list.SupplierModel = s.SupplierModel;
                sc.Part_List.Add(list);
            }
            
            return sc;

        }
        public static QT_configbuilder.Configbuilder Get_Config_full(string config_code, string jstemp)
        {
            string code = Convert_Configid(config_code);
            var client = new RestClient("https://oa.chinasupercloud.com/api/productConfig/get?token=" + token);
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Cookie", "JSESSIONID=" + jstemp + "; loginName=\"" + LoginID + "\"");
            request.AddHeader("Content-Length", "27");
            request.AddHeader("Accept-Encoding", "gzip, deflate");
            request.AddHeader("Host", "oa.chinasupercloud.com");
            request.AddHeader("Postman-Token", "6a9c2334-a84e-4273-94b4-e08d175736b3,59765b29-c665-4b9e-8946-6746e5aac65c");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Accept", "*/*");
            request.AddHeader("User-Agent", "PostmanRuntime/7.18.0");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined", "{\"product_config_id\":" + code + "}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            // OAconsole.ConfigList cflist = ConfigList.FromJson(response.Content);
            // QT_Config.ConfigData cdlist = QT_Config.ConfigData.FromJson(response.Content);
            QT_configbuilder.Configbuilder cgf = QT_configbuilder.Configbuilder.FromJson(response.Content);
            //Console.WriteLine(cflist.Result.ProductConfigCode);
            //foreach(var res in cflist.Result.ProductConfigDataList)
            //{
            //    Console.WriteLine(res.PartName+"\t"+res.Quantity.ToString()+"\t"+res.PartCode);
            //}
            //foreach (var res in cflist.Result.PlatformPartList)
            //{
            //    Console.WriteLine(res.PartName + "\t" + res.Quantity.ToString() + "\t" + res.PartCode);
            //}

            //OAconsole.Model.Srv_Config sc = new Model.Srv_Config();
            //sc.ProductPlatform = cgf.Result.ProductName;
            //sc.Token = cgf.Token;
            //sc.Part_List = new System.Collections.Generic.List<Model.PartList>();

            //foreach (var r in cgf.Result.ProductConfigDataList)
            //{
            //    OAconsole.Model.PartList list = new Model.PartList();
            //    list.Notes = r.Notes;
            //    list.PartCode = r.PartCode;
            //    list.PartId = r.PartId;
            //    list.PartName = r.PartName;
            //    list.PartTypeName = r.PartTypeName;
            //    list.ProductId = r.ProductId.ToString();
            //    list.SupplierModel = r.SupplierModel;
            //    list.Quantity = r.Quantity;
            //    sc.Part_List.Add(list);

            //}
            //foreach (var s in cgf.Result.PlatformPartList)
            //{
            //    OAconsole.Model.PartList list = new Model.PartList();
            //    list.Notes = s.Notes;
            //    list.PartCode = s.PartCode;
            //    list.PartId = s.PartId;
            //    list.PartName = s.PartName;
            //    list.PartTypeName = s.PartTypeName;
            //    list.ProductId = s.ProductPlatformId;
            //    list.Quantity = s.Quantity;
            //    list.SupplierModel = s.SupplierModel;
            //    sc.Part_List.Add(list);
            //}

            return cgf;

        }
        static string Convert_Configid(string id)
        {

            //Console.WriteLine(  id.LastIndexOf('N'));

            string res = id.Substring(id.LastIndexOf('N') + 1);
            int ss = Int32.Parse(res);
            return ss.ToString();
        }

        public   static QT_Quotaion.QuotationData Get_quotation_details(string quota_code)
        {
          string code=  Convert_Configid(quota_code);
            var client = new RestClient("https://oa.chinasupercloud.com/api/quotation/get?token="+token);
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Cookie", "JSESSIONID=" + Jsid + "; loginName=\"" + LoginID + "\"");
            request.AddHeader("Content-Length", "21");
            request.AddHeader("Accept-Encoding", "gzip, deflate");
            request.AddHeader("Host", "oa.chinasupercloud.com");
            request.AddHeader("Postman-Token", "c1d8e2d5-d650-4566-a34e-d7a138429f24,ad00a64d-cb49-4341-930e-35638279c7c0");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Accept", "*/*");
            request.AddHeader("User-Agent", "PostmanRuntime/7.19.0");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined", "{\"quotation_id\": " + code + "}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

          //  QuickType.Quotation quota = QuickType.Quotation.FromJson(response.Content);
            QT_Quotaion.QuotationData quotation = QT_Quotaion.QuotationData.FromJson(response.Content);

            return quotation;

        }
        public static QT_configlist.Configlist GetConfigList(int page)
        {

            var client = new RestClient("https://oa.chinasupercloud.com/api/productConfig/page?token="+token);
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            //request.AddHeader("Cookie", "JSESSIONID=0E4B91133F74D631E898008614F829CB; //loginName="chenjx@chinasupercloud.com"");
            request.AddHeader("Cookie", "JSESSIONID=" + Jsid + "; loginName=\"" + LoginID + "\"; token=" + token);
            request.AddHeader("Content-Length", "44");
            request.AddHeader("Accept-Encoding", "gzip, deflate");
            request.AddHeader("Host", "oa.chinasupercloud.com");
           // request.AddHeader("Postman-Token", "d48a4ffd-3297-44d7-9d85-00b37454874e,54a0c7dc-f259-415f-8812-3550161514fb");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Accept", "*/*");
            request.AddHeader("User-Agent", "PostmanRuntime/7.19.0");
           request.AddHeader("Content-Type", "application/json;charset=UTF-8");
          //  request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("undefined", "{\"page_index\":" + page.ToString() + ",\"page_size\":10,\"keyword\":\"\"}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            //
       //     IRestResponse response = client.Execute(request);
          //  Console.WriteLine(response.Content);
            //QuickType.ProductConfigList pcl=QuickType.ProductConfigList
           // QuickType_configlist.TopLevel top = QuickType_configlist.TopLevel.FromJson(response.Content);
            //ConfigList cflist = JsonConvert.DeserializeObject<ConfigList>(response.Content);
            QT_configlist.Configlist configlist = QT_configlist.Configlist.FromJson(response.Content);
            return configlist;
        }

        public static string FsiData(string code)
        {
          //  var client = new RestClient("https://oa.chinasupercloud.com/api/productConfig/page?token=" + token);
            var client = new RestClient("https://oa.chinasupercloud.com/api/approval/get?token=" + token);
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            //request.AddHeader("Cookie", "JSESSIONID=0E4B91133F74D631E898008614F829CB; //loginName="chenjx@chinasupercloud.com"");
            request.AddHeader("Cookie", "JSESSIONID=" + Jsid + "; loginName=\"" + LoginID + "\"; token=" + token);
            request.AddHeader("Content-Length", "43");
            request.AddHeader("Accept-Encoding", "gzip, deflate");
            request.AddHeader("Host", "oa.chinasupercloud.com");
            // request.AddHeader("Postman-Token", "d48a4ffd-3297-44d7-9d85-00b37454874e,54a0c7dc-f259-415f-8812-3550161514fb");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Accept", "*/*");
            request.AddHeader("User-Agent", "PostmanRuntime/7.19.0");
            request.AddHeader("Content-Type", "application/json");
            //  request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
         //   request.AddParameter("undefined", "{\"application_type\":" + code + ",\"record_id\":10,\"keyword\":\"\"}", ParameterType.RequestBody);
        //    request.AddParameter("undefined", "{\"application_type\":\"5\",\"record_id\":\""+code+"\"}", ParameterType.RequestBody);
            request.AddParameter("undefined", "{\"approval_id\":"+code+"}", ParameterType.RequestBody);
         
            //{"application_type":"5","record_id":"4967"}
            IRestResponse response = client.Execute(request);
          //  Console.WriteLine(response.Content);

            QuickType.Fsi fsi = QuickType.Fsi.FromJson(response.Content);
          
            //Console.WriteLine(fsi.Result.Record.PaymentItemList.Count);
            
            //foreach( var res in fsi.Result.Record.PaymentItemList)
            //{
                
            //    Console.Write(res.CreatorName + "\t" +res.OwnerOrgName +"\t"+ res.Amount + "\t" + res.PaymentItemTypeName+"\n");
            //}
            //
        //    foreach(var res in fsi.Result.Logs)
        //    {
        //        Console.WriteLine(res.ApprovalComments + "\t" + res.ApprovalUser.UserName);
        //    }
        //    Console.WriteLine("========"+ fsi.Result.Record.ExpenseBillName + "======");
        //foreach (var res in   fsi.Result.Record.PaymentItemList)
        //    {
        //        Console.WriteLine(res.PaymentItemName);
        //    }
           
            //foreach(var rs in sent.PaymentItemList)
            //{
            //    Console.WriteLine("-------------"+rs.PaymentItemName);
            //}

            FsiSent.Sent sent = Covert_From_fsi(fsi);


            return FsiSent.Serialize.ToJson(sent);//sent.PaymentItemList.Count.ToString();// FsiSent.Serialize.ToJson(new FsiSent.Sent());

        }
        static string isNullString(object tmp)
        {
            if(tmp==null)
            {
                return "";
            }
            else
            {
                return tmp.ToString();
            }
          
        }
        public static FsiSent.Sent Covert_From_fsi(QuickType.Fsi fsi)
        {
            FsiSent.Sent s = new FsiSent.Sent();

            s.OrgName = fsi.Result.Record.OrgName;
            s.OwnerName = fsi.Result.Record.OwnerName;
            s.ExpenseAmount = fsi.Result.Record.ExpenseAmount;
            s.ExpenseType = fsi.Result.Record.ExpenseType;
            s.OperatorId = fsi.Result.Record.OperatorId;//long.Parse("160");
            s.OwnerOrgName = fsi.Result.Record.OwnerOrgName;
            s.ExpenseNotes = "";// isNullString(fsi.Result.Record.ExpenseNotes);
            s.BeforehandId = fsi.Result.Record.BeforehandId;
            s.CurrentApprovalUserName = fsi.Result.Record.CurrentApprovalUserName;
            s.OwnerMobile = fsi.Result.Record.OwnerMobile;
            s.Corporation = fsi.Result.Record.Corporation;
            s.PaymentStatus = fsi.Result.Record.PaymentStatus;
            s.OwnerEmail = fsi.Result.Record.OwnerEmail;
            s.ExpenseBillName = fsi.Result.Record.ExpenseBillName;
            s.OwnerOpenId = fsi.Result.Record.OwnerOpenId;
            s.CreatorOpenId = fsi.Result.Record.CreatorOpenId;
            s.BillNo = fsi.Result.Record.BillNo;
            s.BeforehandName = fsi.Result.Record.BeforehandName;
            s.ApplicationTime = fsi.Result.Record.ApplicationTime.ToString();
            s.ApplicationContents = fsi.Result.Record.ApplicationContents;
            s.ReceiveStatus = fsi.Result.Record.ReceiveStatus;
            s.BeforehandBillNo = fsi.Result.Record.BeforehandBillNo;
            s.ApprovalStatus = long.Parse("2");//fsi.Result.Record.ApprovalStatus;

            s.PaymentItemList = JsonConvert.DeserializeObject<List<FsiSent.PaymentItemList>>(JsonConvert.SerializeObject(fsi.Result.Record.PaymentItemList));


            s.CreatorEmail = fsi.Result.Record.CreatorEmail;
            s.InvoiceNumber = fsi.Result.Record.InvoiceNumber;
            s.ApprovalId = fsi.Result.Record.ApprovalId;
            s.CreatorId = fsi.Result.Record.CreatorId;
            s.OrgId = fsi.Result.Record.OrgId;
            s.IsDeleted = fsi.Result.Record.IsDeleted;
            s.UpdateTime = fsi.Result.Record.UpdateTime.ToString();
            s.CreateTime = fsi.Result.Record.CreateTime.ToString();
            s.OwnerId = fsi.Result.Record.OwnerId;
            s.CreatorId = fsi.Result.Record.CreatorId;
            s.ExpenseBillId = fsi.Result.Record.ExpenseBillId;
            s.CreatorMobile = fsi.Result.Record.CreatorMobile;
            s.ApprovalComments = ".同意.";// fsi.Result.ApprovalComments;
            s.ApplicationType = fsi.Result.ApplicationType;



            s.Logs = JsonConvert.DeserializeObject<List<FsiSent.Log>>(JsonConvert.SerializeObject(fsi.Result.Logs));

          //  s.ApplicationUser = fsi.Result.ApplicationUser;
            s.ApplicationUser= JsonConvert.DeserializeObject<FsiSent.User>(JsonConvert.SerializeObject(fsi.Result.ApplicationUser));
            s.IsFinanceFlg = fsi.Result.IsFinanceFlg;
            s.CurrentApplicationTime = fsi.Result.CurrentApplicationTime.ToString();
            s.RecordId = fsi.Result.RecordId;


            s.Record = JsonConvert.DeserializeObject<FsiSent.Record>(JsonConvert.SerializeObject(fsi.Result.Record));
 
            s.CurrentApprovalUser= JsonConvert.DeserializeObject<FsiSent.User>(JsonConvert.SerializeObject(fsi.Result.CurrentApprovalUser));
            s.ApplicationUserName = fsi.Result.ApplicationUserName;
            s.CurrentApprovalUserId = long.Parse("160");
            s.ApprovalTimes = fsi.Result.ApprovalTimes;
            s.ApplicationUserId = fsi.Result.ApplicationUserId;
            s.PageMode = "approval_detail";
            s.InputRisk = "";
            s.InputRiskControlAction = "";
            s.RiskControlActions = "";
            s.IdentifiedRisks = "";


            return s;
        }
        public static QuickType.Record FsiData_Frm(string code)
        {
            //  var client = new RestClient("https://oa.chinasupercloud.com/api/productConfig/page?token=" + token);
            var client = new RestClient("https://oa.chinasupercloud.com/api/approval/get?token=" + token);
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            //request.AddHeader("Cookie", "JSESSIONID=0E4B91133F74D631E898008614F829CB; //loginName="chenjx@chinasupercloud.com"");
            request.AddHeader("Cookie", "JSESSIONID=" + Jsid + "; loginName=\"" + LoginID + "\"; token=" + token);
            request.AddHeader("Content-Length", "43");
            request.AddHeader("Accept-Encoding", "gzip, deflate");
            request.AddHeader("Host", "oa.chinasupercloud.com");
            // request.AddHeader("Postman-Token", "d48a4ffd-3297-44d7-9d85-00b37454874e,54a0c7dc-f259-415f-8812-3550161514fb");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Accept", "*/*");
            request.AddHeader("User-Agent", "PostmanRuntime/7.19.0");
            request.AddHeader("Content-Type", "application/json");
            //  request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            //   request.AddParameter("undefined", "{\"application_type\":" + code + ",\"record_id\":10,\"keyword\":\"\"}", ParameterType.RequestBody);
            //    request.AddParameter("undefined", "{\"application_type\":\"5\",\"record_id\":\""+code+"\"}", ParameterType.RequestBody);
            request.AddParameter("undefined", "{\"approval_id\":" + code + "}", ParameterType.RequestBody);

            //{"application_type":"5","record_id":"4967"}
            IRestResponse response = client.Execute(request);
            //  Console.WriteLine(response.Content);

            QuickType.Fsi fsi = QuickType.Fsi.FromJson(response.Content);

            return fsi.Result.Record;
       //     Console.WriteLine(fsi.Result.Record.PaymentItemList.Count);

            //foreach (var res in fsi.Result.Record.PaymentItemList)
            //{

            //    Console.Write(res.CreatorName + "\t" + res.OwnerOrgName + "\t" + res.Amount + "\t" + res.PaymentItemTypeName + "\n");
            //}
            //

        }


          public static string   Fsi_BatAppapproval(string Json_code)
        {
            //  var client = new RestClient("https://oa.chinasupercloud.com/api/productConfig/page?token=" + token);
            // var client = new RestClient("https://oa.chinasupercloud.com/api/approval/get?token=" + token);
            var client = new RestClient("https://oa.chinasupercloud.com/api/approval/save?token=" + "undefined");//token);
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            //request.AddHeader("Cookie", "JSESSIONID=0E4B91133F74D631E898008614F829CB; //loginName="chenjx@chinasupercloud.com"");
            request.AddHeader("Cookie", "JSESSIONID=" + Jsid + "; loginName=\"" + LoginID + "\"; token=" + token);
            //request.AddHeader("Content-Length", "7059");
            request.AddHeader("Accept-Encoding", "gzip, deflate");
            request.AddHeader("Host", "oa.chinasupercloud.com");
            // request.AddHeader("Postman-Token", "d48a4ffd-3297-44d7-9d85-00b37454874e,54a0c7dc-f259-415f-8812-3550161514fb");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Accept", "*/*");
            request.AddHeader("User-Agent", "PostmanRuntime/7.19.0");
            request.AddHeader("Content-Type", "application/json");
            //  request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            //   request.AddParameter("undefined", "{\"application_type\":" + code + ",\"record_id\":10,\"keyword\":\"\"}", ParameterType.RequestBody);
            //    request.AddParameter("undefined", "{\"application_type\":\"5\",\"record_id\":\""+code+"\"}", ParameterType.RequestBody);
     //       request.AddParameter("undefined", "{\"approval_id\":" + code + "}", ParameterType.RequestBody);
            request.AddParameter("undefined", Json_code, ParameterType.RequestBody);
            //{"application_type":"5","record_id":"4967"}
            IRestResponse response = client.Execute(request);

           QuickTypeRes .Res re= QuickTypeRes.Res.FromJson(response.Content);

            return re.ResultType +"\t"+re.Result.ApprovalId +"\t"+re.Result.ApplicationContents+"\t"+re.Result.ApplicationUserName ;
        }
        public static string Payed(string code)
        {
            //  var client = new RestClient("https://oa.chinasupercloud.com/api/productConfig/page?token=" + token);
            // var client = new RestClient("https://oa.chinasupercloud.com/api/approval/get?token=" + token);
         //   var client = new RestClient("https://oa.chinasupercloud.com/api/approval/save?token=" + "undefined");//token);
            var client = new RestClient("https://oa.chinasupercloud.com/api/expenseBill/payed?token=undefined");//token);
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            //request.AddHeader("Cookie", "JSESSIONID=0E4B91133F74D631E898008614F829CB; //loginName="chenjx@chinasupercloud.com"");
            request.AddHeader("Cookie", "JSESSIONID=" + Jsid + "; loginName=\"" + LoginID + "\"; token=" + token);
            //request.AddHeader("Content-Length", "7059");
            request.AddHeader("Accept-Encoding", "gzip, deflate");
            request.AddHeader("Host", "oa.chinasupercloud.com");
            // request.AddHeader("Postman-Token", "d48a4ffd-3297-44d7-9d85-00b37454874e,54a0c7dc-f259-415f-8812-3550161514fb");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Accept", "*/*");
            request.AddHeader("User-Agent", "PostmanRuntime/7.19.0");
            request.AddHeader("Content-Type", "application/json");
            //  request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            //   request.AddParameter("undefined", "{\"application_type\":" + code + ",\"record_id\":10,\"keyword\":\"\"}", ParameterType.RequestBody);
            //    request.AddParameter("undefined", "{\"application_type\":\"5\",\"record_id\":\""+code+"\"}", ParameterType.RequestBody);
            //       request.AddParameter("undefined", "{\"approval_id\":" + code + "}", ParameterType.RequestBody);
            request.AddParameter("undefined", "{\"expense_bill_id\":"+code+"}", ParameterType.RequestBody);
            //{"application_type":"5","record_id":"4967"}
            IRestResponse response = client.Execute(request);

            //QuickTypeRes.Res re = QuickTypeRes.Res.FromJson(response.Content);
           QuickType_pay.Pay pay= QuickType_pay.Pay.FromJson(response.Content);
            //   return re.ResultType + "\t" + re.Result.ApprovalId + "\t" + re.Result.ApplicationContents + "\t" + re.Result.ApplicationUserName;
            return pay.ResultType +"\t"+pay.Result.BillNo+"\t"+pay.Result.CreatorName ;
        }
    }


}
