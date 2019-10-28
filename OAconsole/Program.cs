using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace OAconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //     WebClient_test();
            //update to github
            // Reqest_Test();
            // Request_Login();
            //  Console.WriteLine("config id input");
            // string s = Console.ReadLine();
            //  get_Data("38695");
            //  get_Data("38694");
            Access_OA.Test_index();

            //   Test_index();

            Console.WriteLine("app is done!");
            Console.ReadLine();
        }

        static void WebClient_test()
        {
            web_commit("img.png", ImageFormat.Png);
        }

        protected static void web_commit(string filename, ImageFormat format)
        {
            using (var client = new WebClient())
            {

                client.Headers[HttpRequestHeader.Accept] = "*/*";
                // client.Headers[HttpRequestHeader.UserAgent] = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.102 Safari/537.36 Edge/18.18362";
                // client.Headers[HttpRequestHeader.AcceptLanguage] = "zh-Hans-CN, zh-Hans; q=0.8, en-US; q=0.5, en; q=0.3";
                // client.Headers[HttpRequestHeader.ContentType] = "application/json; charset=UTF-8";
                // client.Headers[HttpRequestHeader.ContentEncoding] = "gzip, deflate, br";
                client.Headers[HttpRequestHeader.Cookie] = "JSESSIONID=CA3D895ED79C8D9433F102E469AD8FB3";
                // client.Headers[HttpRequestHeader.Accept] = "*/*";
                client.Headers[HttpRequestHeader.Host] = "oa.chinasupercloud.com";
                // client.Headers[HttpRequestHeader.CacheControl] = "no-cache";








                Stream stream = client.OpenRead("https://oa.chinasupercloud.com/api/verifycode/generate?rand=123");
                Bitmap bitmap; bitmap = new Bitmap(stream);

                if (bitmap != null)
                {
                    bitmap.Save(filename, format);
                }

                stream.Flush();
                stream.Close();
                // client.Dispose();
                Console.WriteLine("get there image");

                client.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                //      client.Headers[HttpRequestHeader.Accept ] = "*/*";
                //     client.Headers[HttpRequestHeader.ContentLength] = "68";
                //client.Headers[HttpRequestHeader.Cookie] = "loginName=\"chenjx @chinasupercloud.com\"; loginName=chenjx@chinasupercloud.com; JSESSIONID=C4BCB32E27C87F6B1A49127644B228CE; token=286744344783\"";
                //    client.Headers[HttpRequestHeader.Connection] = "keep-alive";
                // client.Headers[HttpRequestHeader.Host] = "oa.chinasupercloud.com";
                //  client.Headers[HttpRequestHeader.] = "gzip,deflate";

                // client.Headers[HttpResponseHeader.CacheControl] = "no-cache";
                //    client.Headers[HttpResponseHeader.Connection] = "keep-alive";
                //    client.Headers[HttpResponseHeader.ContentEncoding] = "gzip";
                //      client.Headers[HttpResponseHeader.ContentType] = "application/json; charset=UTF-8";
                //    client.Headers[HttpResponseHeader.Pragma] = "no-cache";
                //  client.Headers[HttpRequestHeader.Server] = "nginx/1.10.2";
                //      client.Headers[HttpResponseHeader.TransferEncoding] = "chunked";
                //  client.Headers[HttpResponseHeader.Vary] = "Accept-Encoding";
                var values = new NameValueCollection();
                string code = Console.ReadLine();
                Console.WriteLine(code);
                values["verycode"] = code;
                values["email"] = "chenjx@chinasupercloud.com";
                values["password"] = "Winsows200";

                var response = client.UploadValues("https://oa.chinasupercloud.com/api/login", "POST", values);

                var responseString = Encoding.Default.GetString(response);
                Console.WriteLine(responseString);

                //  string restr= client.DownloadString("https://oa.chinasupercloud.com/api/product/list");
                // Console.WriteLine(restr);
            }
            //using(var client =new WebClient())
            //{

            //}
        }


    }

    public class Access_OA
    {
        static string jsid = "";
        public static void Test_index()
        {
            get_verycode();
            Request_Login(Console.ReadLine());
            get_Data("38659");
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


            //  client.BaseUrl = new Uri("https://oa.chinasupercloud.com/api/login");

            //   Console.WriteLine(client.CookieContainer.Count);
            //   Console.WriteLine(client.CookieContainer.GetCookies(client.BaseUrl)[0].Name);
            //   Console.WriteLine(client.CookieContainer.GetCookies(client.BaseUrl)[0].Value);

            //request.Method = Method.POST;//= new RestRequest(Method.POST);
            //request.AddHeader("cache-control", "no-cache");
            //request.AddHeader("Connection", "keep-alive");

            //request.AddHeader("Content-Length", "68");
            //request.AddHeader("Accept-Encoding", "gzip, deflate");
            //request.AddHeader("Host", "oa.chinasupercloud.com");
            //request.AddHeader("Postman-Token", "6d2da704-6eb7-4f70-bdee-6e0aad0a3c15,118125fa-a609-426c-badd-4c075fe1ff94");
            //request.AddHeader("Cache-Control", "no-cache");
            //request.AddHeader("Accept", "*/*");
            //request.AddHeader("User-Agent", "PostmanRuntime/7.18.0");
            //request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            Console.WriteLine(code);
            request.AddParameter("undefined", "email=chenjx@chinasupercloud.com&password=Winsows200&verycode=" + code, ParameterType.RequestBody);
            IRestResponse responselogin = client.Execute(request);

            Console.WriteLine(responselogin.Content);

            //  Console.WriteLine("......");
            // Console.ReadLine();
            //client.BaseUrl = new Uri("https://oa.chinasupercloud.com/api/productConfig/get?token=undefined");
            //           request.Method = Method.POST;
            //           request.AddHeader("cache-control", "no-cache");
            //          request.AddHeader("Connection", "keep-alive");
            //           request.AddHeader("Cookie", "JSESSIONID=75666D11AC9ECB4FA72E966459FC6382; loginName=\"chenjx@chinasupercloud.com\"");
            //              request.AddHeader("Content-Length", "27");
            //                request.AddHeader("Accept-Encoding", "gzip, deflate");
            //             request.AddHeader("Host", "oa.chinasupercloud.com");
            //          //   request.AddHeader("Postman-Token", "6a9c2334-a84e-4273-94b4-e08d175736b3,236e9162-d0d3-4050-8770-efeeccd98edb");
            //                 request.AddHeader("Cache-Control", "no-cache");
            //                   request.AddHeader("Accept", "*/*");
            //                   request.AddHeader("User-Agent", "PostmanRuntime/7.18.0");
            //           //   request.AddHeader("Content-Type", "application/json");

            //           request.AddParameter("undefined", "{\"product_config_id\":40944}", ParameterType.RequestBody);
            //           IRestResponse responseres = client.Execute(request
            //  Console.WriteLine("config id input");
            //   string s = Console.ReadLine();
            //  get_Data(s);
            return responselogin.Content.Contains("SUCCESS");

        }
        static void get_Data(string config_code)
        {
            var client = new RestClient("https://oa.chinasupercloud.com/api/productConfig/get?token=undefined");
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Cookie", "JSESSIONID=" + jsid + "; loginName=\"chenjx@chinasupercloud.com\"");
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
            //Console.WriteLine(response.Content);
            ////  File.WriteAllText(config_code + "config.json", response.Content);
            //   Newtonsoft.Json.JsonTextReader reader = new Newtonsoft.Json.JsonTextReader(new StringReader(response.Content));

            ////    XNode xn = JsonConvert.DeserializeXNode(response.Content, "result");
            //XmlDocument xnn = JsonConvert.DeserializeXmlNode(response.Content, "result");
            ////  Console.WriteLine(xnn.ChildNodes[0].ChildNodes.Count);
            //foreach (XmlNode node in xnn.ChildNodes[0].ChildNodes[0].ChildNodes)
            //{
            //    Console.WriteLine(node.Name + "-\t" + node.Value + "--\t" + node.InnerXml);
            //}


            OAconsole.ConfigList cflist = ConfigList.FromJson(response.Content);
            Console.WriteLine(cflist.Result.ProductConfigCode);
            foreach(var res in cflist.Result.ProductConfigDataList)
            {
                Console.WriteLine(res.PartName+"\t"+res.Quantity.ToString()+"\t"+res.PartCode);
            }
            foreach (var res in cflist.Result.PlatformPartList)
            {
                Console.WriteLine(res.PartName + "\t" + res.Quantity.ToString() + "\t" + res.PartCode);
            }
            //Newtonsoft.Json.JsonNameTable jt= reader.PropertyNameTable;


            //  Console.WriteLine(  xm.ToString());
            // XmlNode nd=   xnn.SelectSingleNode("platform_part_list");
            //     XmlNode ndc = xnn.SelectSingleNode("product_config_data_list");
            //     Console.WriteLine(nd.OuterXml);

            //     Console.WriteLine("-----------------");
            //    Console.WriteLine(ndc.OuterXml);
            //    xnn.Save("abc.xml");




            //  List<srv_config> UserList = JsonConvert.DeserializeObject<List<srv_config>>(response.Content);
            //while (reader.Read())
            //{
            //    if (reader.Value != null)
            //    {
            //        Console.WriteLine("Token: {0}, Value: {1}", reader.TokenType, reader.Value);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Token: {0}", reader.TokenType);
            //    }
            //}


            // string result = JsonConvert.SerializeObject(DatatableToDictionary(queryResult, "Title"), Newtonsoft.Json.Formatting.Indented)
        }
    }

  
}
