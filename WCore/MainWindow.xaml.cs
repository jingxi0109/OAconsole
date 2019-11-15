using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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

namespace WCore
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
        
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
           

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //OAconsole.ConfigList cf = OAconsole.ConfigList.FromJson(File.ReadAllText("38659config.json"));

            //Console.WriteLine(cf.Token);
            //this.Title = cf.Token;
            //this.dataGrid.ItemsSource = cf.Result.ProductConfigDataList;
            ////this.image. = OAconsole.Access_OA.get_verycode();
           
        }
       static  string jsd;

        public static string Jsd { get => jsd; set => jsd = value; }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            LogoFrm logoFrm = new LogoFrm();
            logoFrm.ShowDialog();
            this.Title = Jsd;

            if(jsd.Length>3)
            {

                logoFrm.Close();
            }
            else
            {
                MessageBox.Show("login failed. ");
            }
          
        }

        private void btn_data_Click(object sender, RoutedEventArgs e)
        {

           OAconsole.Model.Srv_Config  cd;
     cd=    OAconsole.Access_OA.Get_Config_details(this.textBox.Text, this.Title);
            this.dataGrid.ItemsSource = cd.Part_List;//.ProductConfigDataList;//Result.//OptionalPartList;//ProductConfigDataList;
                                                     //  this.dg2.ItemsSource = cd.Result.PlatformPartList;
            this.label.Content = cd.ProductPlatform;
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
