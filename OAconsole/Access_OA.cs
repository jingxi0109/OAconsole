using RestSharp;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace OAconsole
{
    public class Access_OA
    {
        static string jsid = "";
        static string loginID = "chenjx@chinasupercloud.com";
        static string passcode = "Winsows200";
        public static void Test_index()
        {
            get_verycode();
            Request_Login(Console.ReadLine());
            get_ConfigData("38659");
        }

        static void get_verycode()
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

        }
        static bool Request_Login(string verycode)
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
            request.AddCookie("JSESSIONID", jsid);
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
            request.AddParameter("undefined", "email="+loginID+"&password="+passcode+"&verycode=" + code, ParameterType.RequestBody);
            IRestResponse responselogin = client.Execute(request);

            Console.WriteLine(responselogin.Content);

            return responselogin.Content.Contains("SUCCESS");

        }
        static ConfigList get_ConfigData(string config_code)
        {
            var client = new RestClient("https://oa.chinasupercloud.com/api/productConfig/get?token=undefined");
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Cookie", "JSESSIONID=" + jsid + "; loginName=\""+loginID+"\"");
            request.AddHeader("Content-Length", "27");
            request.AddHeader("Accept-Encoding", "gzip, deflate");
            request.AddHeader("Host", "oa.chinasupercloud.com");
            request.AddHeader("Postman-Token", "6a9c2334-a84e-4273-94b4-e08d175736b3,59765b29-c665-4b9e-8946-6746e5aac65c");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Accept", "*/*");
            request.AddHeader("User-Agent", "PostmanRuntime/7.18.0");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined", "{\"product_config_id\":" + config_code + "}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            OAconsole.ConfigList cflist = ConfigList.FromJson(response.Content);
            //Console.WriteLine(cflist.Result.ProductConfigCode);
            //foreach(var res in cflist.Result.ProductConfigDataList)
            //{
            //    Console.WriteLine(res.PartName+"\t"+res.Quantity.ToString()+"\t"+res.PartCode);
            //}
            //foreach (var res in cflist.Result.PlatformPartList)
            //{
            //    Console.WriteLine(res.PartName + "\t" + res.Quantity.ToString() + "\t" + res.PartCode);
            //}
            return cflist;
         
        }
        public static ConfigList GetData ()
        {
            OAconsole.ConfigList cflist = ConfigList.FromJson(File.ReadAllText("38659config.json"));

            return cflist;
        }
        static QuickType.Quotation get_quotationData(string quota_code)
        {
            var client = new RestClient("https://oa.chinasupercloud.com/api/quotation/get?token=undefined&=");
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Cookie", "JSESSIONID=" + jsid + "; loginName=\""+loginID+"\"");
            request.AddHeader("Content-Length", "21");
            request.AddHeader("Accept-Encoding", "gzip, deflate");
            request.AddHeader("Host", "oa.chinasupercloud.com");
            request.AddHeader("Postman-Token", "c1d8e2d5-d650-4566-a34e-d7a138429f24,ad00a64d-cb49-4341-930e-35638279c7c0");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Accept", "*/*");
            request.AddHeader("User-Agent", "PostmanRuntime/7.19.0");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined", "{\"quotation_id\": "+ quota_code + "}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            QuickType.Quotation quota = QuickType.Quotation.FromJson(response.Content);

            return quota;

        }
    }

  
}
