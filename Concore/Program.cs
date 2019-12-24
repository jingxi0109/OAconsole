using System;
using System.Collections.Generic;
using System.Text;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;
using System.Linq;
using System.IO;
using NPOI.HSSF.UserModel;
using System.Net;
using Newtonsoft.Json;
using System.Collections;
using System.Data;

namespace Concore
{
  public  class Program
    {

        static void Main(string[] args)
        {
            read_workbook();

            initial_DB();
            Build_DataSet();
            //build_workbook();
            Console.WriteLine(t_Departments.Count);
            Console.WriteLine(t_Emps.Count);
            SaveFile();

            Console.WriteLine( Check_dataset("本地交通费"));

            Console.WriteLine("app is done.");
            Console.ReadLine();
        }
       static  System.Data.DataSet dataSet;
        static void Build_DataSet()
        {
            dataSet = new System.Data.DataSet();
            dataSet.ReadXml("FsiCode.xml");
            foreach(DataColumn dataColumn in dataSet.Tables[0].Columns)
            {
                Console.WriteLine(dataColumn.ColumnName);
            }

            foreach (System.Data.DataRow aas in dataSet.Tables[0].Rows)
            {

                Console.WriteLine();
                foreach (var res in aas.ItemArray)
                {
                    Console.Write(res.ToString() + "\t");
                }
            }
            Console.WriteLine(dataSet.Tables[0].Rows.Count);

        }
        static string  Check_dataset( string code)
        {
           var res= dataSet.Tables[0].AsEnumerable();
          var row=  res.Where(x => x.Field<string>("Item-type") ==code);
            DataRow r = row.FirstOrDefault();
            

            return r.ItemArray[1].ToString();
        }
        public static void Test_interface(List<QuickType.PaymentItemList> records)
        {
            read_workbook();
            Build_DataSet();
            initial_DB();

            build_workbook(records);
          //  Console.WriteLine(t_Departments.Count);
           // Console.WriteLine(t_Emps.Count);
        //    SaveFile();
      //      Console.WriteLine("app is done.");
      //      Console.ReadLine();
        }
        static IRow r;
        static NPOI.HSSF.UserModel.HSSFWorkbook workbook;
        static void build_workbook(List<QuickType.PaymentItemList> records)
        {
            workbook = new NPOI.HSSF.UserModel.HSSFWorkbook();

            ISheet tb = workbook.CreateSheet("Page1");

           
            IRow r0 = tb.CreateRow(0);

            for (int i = 0; i < r.Cells.Count; i++)
            {
                string strr = r.GetCell(i).StringCellValue;
                ICell cell = r0.CreateCell(i);
                cell.SetCellValue(strr);
            }

            //foreach (var res in r0.Cells)
            //{
            //    Console.WriteLine(res.StringCellValue);
            //}

            // List<QuickType.PaymentItemList> records = new List<QuickType.PaymentItemList>();
            //foreach (var res in records)
            //{

            //}
          //  IRow cl = tb.CreateRow(1);

        //    build_static_Row(cl);

            for (int i=0; i<records.Count;i++)
            {
                IRow row = tb.CreateRow(i+1);
                Add_Row(row, records[i]);
            }
          
            //   build_Dynamic_Row(row);

            //for (int i = 0; i < 20; i++)
            //{
            //    ICell cell = row.CreateCell(i);  //在第二行中创建单元格
            //    cell.SetCellValue(i);//循环往第二行的单元格中添加数据
            //}

            FileStream sw = File.Create("Exports"+DateTime.Now.ToString("d")+".xls");
            workbook.Write(sw);
            sw.Close();


        }
        static void Add_Row(IRow cells,QuickType.PaymentItemList list )
        {
            build_static_Row(cells);
            build_Dynamic_Row(cells,list);
            
        }
        static void SaveFile ()
            {
           
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
             //   Console.WriteLine(wk.GetSheetAt(0).SheetName);
               
            }
         //   Console.WriteLine(sbr.ToString());
        }
        static string Fsi_Code(string typename)
        {
            var s = dataSet.Tables[0].AsEnumerable();
       //     s.Select(x=>x.ItemArray[] )

            return "";
        }
        static void build_Dynamic_Row(IRow cells, QuickType.PaymentItemList list)
        {

    

            cells.CreateCell(5).SetCellValue(Check_dataset(list.PaymentItemTypeName) );//Fsi data科目代码
            cells.CreateCell(6).SetCellValue(list.PaymentItemTypeName );//科目名称

            cells.CreateCell(9).SetCellValue(list.Amount.ToString());//原币金额
            cells.CreateCell(10).SetCellValue(list.Amount.ToString());//借方？？？

            cells.CreateCell(19).SetCellValue(list.PaymentItemName ); //item description 描述
            cells.CreateCell(32).SetCellValue("1");//id  分录序号
            cells.CreateCell(33).SetCellValue("部门--"+Org_name (list.OwnerOrgName )+"--"+list.OwnerOrgName  +"||职员---"+Emp_name(list.CreatorName )+"---"+list.CreatorName);//org info 部门，员工，creater name
            Console.WriteLine(cells.Sheet.SheetName);
        }
        static string Org_name(string org)
        {
            //  t_Departments
        string res=    t_Departments.Find(x => x.FName == org).FNumber ;
            return res;
        }
        static string Emp_name(string emp)
        {
            string res = t_Emps.Find(x => x.FName == emp).FNumber;
            return res;
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
                json = wc.DownloadString("http://192.168.7.10:8080/api/emp"); //http://eyqkj3.natappfree.cc/api/dep
           //     json = wc.DownloadString("http://eyqkj3.natappfree.cc/api/emp");
                var table = JsonConvert.DeserializeObject<List<ConsoleApp1.t_Emp>>(json);
                t_Emps = table;
            }
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = System.Text.Encoding.UTF8;
               json = wc.DownloadString("http://192.168.7.10:8080/api/dep");
               // json = wc.DownloadString("http://eyqkj3.natappfree.cc/api/dep");
                var table = JsonConvert.DeserializeObject<List<ConsoleApp1.t_Department>>(json);
                t_Departments = table;
            }
        }
       static List<ConsoleApp1.t_Emp> t_Emps;
        static List<ConsoleApp1.t_Department> t_Departments;
    }
}
