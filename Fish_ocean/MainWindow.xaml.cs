using System;
using System.Collections.Generic;
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

namespace Fish_ocean
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
      
   

        private void But_start_Click_1(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int cordx,cordy;
            cordx = (rnd.Next(1,18)*50);
            cordy = (rnd.Next(1,12)*50);

        }

        private void But_start_Click(object sender, RoutedEventArgs e)
        {
            Options options = new Options();
            options.Show();
        }

        private void But_reset_Click(object sender, RoutedEventArgs e)
        {

        }

        private void But_pause_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
