using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FsiApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.lbcount.Content = "共" + this.TxtRow.LineCount.ToString() + "行";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            verycode.Source =BitmapToImageSource(OAconsole.Access_OA.Get_verycode());
        }
        BitmapImage BitmapToImageSource(Bitmap bitmap)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                bitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Bmp);
                memory.Position = 0;
                BitmapImage bitmapimage = new BitmapImage();
                bitmapimage.BeginInit();
                bitmapimage.StreamSource = memory;
                bitmapimage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapimage.EndInit();

                return bitmapimage;
            }
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            this.check_Logon.IsChecked = bool.Parse(OAconsole.Access_OA.Request_Login(this.txtverycode.Text).ToString());
            this.Title = OAconsole.Access_OA.Jsid;

        }

        private void refVeryCode_Click(object sender, RoutedEventArgs e)
        {
            Window_Loaded(sender, e);
        }

        private void btnFill_Click(object sender, RoutedEventArgs e)
        {
            List<QuickType.Record> records = new List<QuickType.Record>();
            //this.dataGrid.ItemsSource = records;
            if(this.check_Logon.IsChecked.Value)
            {
                for (int i = 0; i < this.TxtRow.LineCount; i++)
                {
                    string a = this.TxtRow.GetLineText(i);
                    a = a.Replace("\r\n", "");
                    if (IsNumeric(a))
                    {
                        var res = OAconsole.Access_OA.FsiData_Frm(a);
                       // MessageBox.Show(res.OwnerName);//.ToString());
                        records.Add(res);
                    }
                    
                }
                if (records.Count > 0)
                {
                    this.dataGrid.ItemsSource = records;
                }
            }

        }
        public static bool IsNumeric(string value)
        {
            Regex objNotNumberPattern = new Regex("[^0-9.-]");
            Regex objTwoDotPattern = new Regex("[0-9]*[.][0-9]*[.][0-9]*");
            Regex objTwoMinusPattern = new Regex("[0-9]*[-][0-9]*[-][0-9]*");
            String strValidRealPattern = "^([-]|[.]|[-.]|[0-9])[0-9]*[.]*[0-9]+$";
            String strValidIntegerPattern = "^([-]|[0-9])[0-9]*$";
            Regex objNumberPattern = new Regex("(" + strValidRealPattern + ")|(" + strValidIntegerPattern + ")");

            return !objNotNumberPattern.IsMatch(value) &&
                !objTwoDotPattern.IsMatch(value) &&
                !objTwoMinusPattern.IsMatch(value) &&
                objNumberPattern.IsMatch(value);
        }
    }
}
