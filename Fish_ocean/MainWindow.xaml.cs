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

        Random rnd = new Random();
        int cordx, cordy;

        private void But_start_Click_1(object sender, RoutedEventArgs e)
        {
            fish_spawn();
            tango_spawn();
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

        private void fish_spawn(int fast,int stamina)
        {
            for (int i = fast; i>0; i--)
            {
                Rectangle fastfish = new Rectangle();

                cordx = (rnd.Next(1, 18) * 50);
                cordy = (rnd.Next(1, 12) * 50);

                fastfish.Height = 25;
                fastfish.Width = 50;
                ImageBrush ib = new ImageBrush();
                ib.AlignmentX = AlignmentX.Left;
                ib.Stretch = Stretch.None;
                ib.Viewbox = new Rect(0, 0, 50, 25);
                ib.ViewboxUnits = BrushMappingMode.Absolute;
                ib.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/текстурки/gg.gif", UriKind.Absolute));
                fastfish.Fill = ib;
                fastfish.Margin = new Thickness(cordx, cordy, 0, 0);
                scene.Children.Add(fastfish);
            }

            for (int i = stamina; i > 0; i--)
            {
                Rectangle staminafish = new Rectangle();

                cordx = (rnd.Next(1, 18) * 50);
                cordy = (rnd.Next(1, 12) * 50);

                staminafish.Height = 25;
                staminafish.Width = 50;
                ImageBrush ib = new ImageBrush();
                ib.AlignmentX = AlignmentX.Left;
                ib.Stretch = Stretch.None;
                ib.Viewbox = new Rect(0, 0, 50, 25);
                ib.ViewboxUnits = BrushMappingMode.Absolute;
                ib.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/текстурки/gg.gif", UriKind.Absolute));
                staminafish.Fill = ib;
                staminafish.Margin = new Thickness(cordx, cordy, 0, 0);
                scene.Children.Add(staminafish);
            }
        }

        private void tango_spawn(int amountoftango)
        {
            for (int i = amountoftango; i > 0; i--)
            {
                Rectangle tango = new Rectangle();

                cordx = (rnd.Next(1, 18) * 50);
                cordy = (rnd.Next(1, 12) * 50);

                tango.Height = 25;
                tango.Width = 50;
                ImageBrush ib = new ImageBrush();
                ib.AlignmentX = AlignmentX.Left;
                ib.Stretch = Stretch.None;
                ib.Viewbox = new Rect(0, 0, 50, 25);
                ib.ViewboxUnits = BrushMappingMode.Absolute;
                ib.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/текстурки/gg.gif", UriKind.Absolute));
                tango.Fill = ib;
                tango.Margin = new Thickness(cordx, cordy, 0, 0);
                scene.Children.Add(tango);
            }
        }

    }
}
