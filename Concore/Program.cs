using System;
using System.Collections.Generic;
using System.Text;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;

using System.IO;
using NPOI.HSSF.UserModel;
using System.Net;
using Newtonsoft.Json;

namespace Concore
{
    class Program
    {
    
        static void Main(string[] args)
        {
  read_workbook();
             build_workbook();
            initial_DB();
            Console.WriteLine(t_Departments.Count);
            Console.WriteLine(t_Emps.Count);
            Console.WriteLine("app is done.");
            Console.ReadLine();
        }
        static IRow r;
        static void build_workbook()
        {
            NPOI.HSSF.UserModel.HSSFWorkbook workbook = new NPOI.HSSF.UserModel.HSSFWorkbook();

          ISheet tb=  workbook.CreateSheet("Page1");

            IRow row = tb.CreateRow(1);
            IRow r0 = tb.CreateRow(0);
          
            for( int i=0; i<r.Cells.Count;i++)
            {
                string strr = r.GetCell(i).StringCellValue;
                ICell cell = r0.CreateCell(i);
                cell.SetCellValue(strr);
            }
            
          foreach(var res in r0.Cells)
            {
                Console.WriteLine(res.StringCellValue);
            }
            
            build_static_Row(row);
            build_Dynamic_Row(row);
            //for (int i = 0; i < 20; i++)
            //{
            //    ICell cell = row.CreateCell(i);  //在第二行中创建单元格
            //    cell.SetCellValue(i);//循环往第二行的单元格中添加数据
            //}



            FileStream sw = File.Create("Export.xls");
            workbook.Write(sw);
            sw.Close();
        }

        static void read_workbook()
        {
         //   StringBuilder sbr = new StringBuilder();
            using (FileStream fs = File.OpenRead("invoice.xls"))   //打开myxls.xls文件
            {
                HSSFWorkbook wk = new HSSFWorkbook(fs);   //把xls文件中的数据写入wk中
                ISheet sheet = wk.GetSheetAt(0);
                r = sheet.GetRow(0);
                //for (int i = 0; i < wk.NumberOfSheets; i++)  //NumberOfSheets是myxls.xls中总共的表数
                //{
                //    ISheet sheet = wk.GetSheetAt(i);   //读取当前表数据
                //    for (int j = 0; j <= sheet.LastRowNum; j++)  //LastRowNum 是当前表的总行数
                //    {
                //        IRow row = sheet.GetRow(j);  //读取当前行数据
                //        if (row != null)
                //        {
                //            sbr.Append("-------------------------------------\r\n"); //读取行与行之间的提示界限
                //            for (int k = 0; k <= row.LastCellNum; k++)  //LastCellNum 是当前行的总列数
                //            {
                //                ICell cell = row.GetCell(k);  //当前表格
                //                if (cell != null)
                //                {
                //                    sbr.Append(cell.ToString());   //获取表格中的数据并转换为字符串类型
                //                }
                //            }
                //        }
                //    }
                //}
                Console.WriteLine(wk.GetSheetAt(0).SheetName);
               
            }
         //   Console.WriteLine(sbr.ToString());
        }
        static void build_Dynamic_Row(IRow cells)
        {
            cells.CreateCell(5).SetCellValue("6601.018");//Fsi data
            cells.CreateCell(6).SetCellValue("服务费");

            cells.CreateCell(9).SetCellValue("1232");
            cells.CreateCell(10).SetCellValue("112");

            cells.CreateCell(19).SetCellValue("招待费"); //item description
            cells.CreateCell(32).SetCellValue("1");//id
            cells.CreateCell(33).SetCellValue("部门--023--湖南办事处||职员---130-0006---name");//org info
        }

        static void build_static_Row(IRow Row)
        {
            Row.CreateCell(0).SetCellValue(DateTime.Now.ToString("d"));
            Row.CreateCell(1).SetCellValue(DateTime.Now.Year.ToString());
            Row.CreateCell(2).SetCellValue(DateTime.Now.Month.ToString());
            Row.CreateCell(3).SetCellValue("记");

            Row.CreateCell(4).SetCellValue("");
            Row.CreateCell(5).SetCellValue("");
            Row.CreateCell(6).SetCellValue("");
            
            Row.CreateCell(7).SetCellValue("RMB");
            Row.CreateCell(8).SetCellValue("人民币");

          
            Row.CreateCell(9).SetCellValue("");
            Row.CreateCell(10).SetCellValue("");



            Row.CreateCell(11).SetCellValue("0");
            Row.CreateCell(12).SetCellValue("柴淼");
            Row.CreateCell(13).SetCellValue("曲晓阳");
            Row.CreateCell(14).SetCellValue("NONE");
            Row.CreateCell(15).SetCellValue("NONE");
            Row.CreateCell(16).SetCellValue("");
            Row.CreateCell(17).SetCellValue("*");
            Row.CreateCell(18).SetCellValue("");
            Row.CreateCell(19).SetCellValue("");
            Row.CreateCell(20).SetCellValue("0");
            Row.CreateCell(21).SetCellValue("*");
            Row.CreateCell(22).SetCellValue("0");
            Row.CreateCell(23).SetCellValue("");
            Row.CreateCell(24).SetCellValue(DateTime.Now.ToString("d"));
            Row.CreateCell(25).SetCellValue("");
            Row.CreateCell(26).SetCellValue("0");
            Row.CreateCell(27).SetCellValue("");
            Row.CreateCell(28).SetCellValue("");
            Row.CreateCell(29).SetCellValue("");
            Row.CreateCell(30).SetCellValue("公司汇率");

            Row.CreateCell(31).SetCellValue("1");
            Row.CreateCell(32).SetCellValue("");
            Row.CreateCell(33).SetCellValue("");
            Row.CreateCell(34).SetCellValue("0");
            Row.CreateCell(35).SetCellValue("");
            Row.CreateCell(36).SetCellValue("");
        }

        static string info_builder(string f_1, string f_2, string f_3, string f_4)
        {

            return "'部门---"+f_1+"---"+f_2+"||职员---"+f_3+"---"+f_4;
        }

        static void initial_DB()
        {
            string json = "";
            using (WebClient wc=new WebClient())
            {
                wc.Encoding = System.Text.Encoding.UTF8;
                json = wc.DownloadString("http://192.168.7.10:8080/api/emp");
                var table = JsonConvert.DeserializeObject<List<ConsoleApp1.t_Emp>>(json);
                t_Emps = table;
            }
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = System.Text.Encoding.UTF8;
                json = wc.DownloadString("http://192.168.7.10:8080/api/dep");
                var table = JsonConvert.DeserializeObject<List<ConsoleApp1.t_Department>>(json);
                t_Departments = table;
            }
        }
       static List<ConsoleApp1.t_Emp> t_Emps;
        static List<ConsoleApp1.t_Department> t_Departments;
    }
}
