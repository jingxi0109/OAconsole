using System;
using System.Collections.Generic;
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
            OAconsole.ConfigList cf = OAconsole.ConfigList.FromJson(File.ReadAllText("38659config.json"));

            Console.WriteLine(cf.Token);
            this.Title = cf.Token;
            this.dataGrid.ItemsSource = cf.Result.ProductConfigDataList;

        }

    }
}
