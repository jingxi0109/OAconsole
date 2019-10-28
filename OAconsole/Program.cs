using Newtonsoft.Json;
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

  
}
