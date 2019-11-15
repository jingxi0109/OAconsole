using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WCore
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class LogoFrm : Window
    {
        public LogoFrm()
        {
            InitializeComponent();
        }

        private void image_Loaded(object sender, RoutedEventArgs e)
        {
            image.Source = BitmapToImageSource(OAconsole.Access_OA.Get_verycode());
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.checkBox.IsChecked = bool.Parse(OAconsole.Access_OA.Request_Login(this.textBox.Text).ToString());

            this.Title = OAconsole.Access_OA.Jsid;
            MainWindow.Jsd = OAconsole.Access_OA.Jsid;
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
