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

namespace Gra_w_kosci
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

        private void Button_Rzuc(object sender, RoutedEventArgs e)
        {
            uklad u = new uklad();
            u.uklad_losuj();
            
            kosc0Label.Content = u.uklad5[0].Oczka.ToString();
            kosc1Label.Content = u.uklad5[1].Oczka.ToString();
            kosc2Label.Content = u.uklad5[2].Oczka.ToString();
            kosc3Label.Content = u.uklad5[3].Oczka.ToString();
            kosc4Label.Content = u.uklad5[4].Oczka.ToString();

            BitmapImage bi3 = new BitmapImage();
            bi3.BeginInit();
            bi3.UriSource = new Uri("/Recources/kostka1.png", UriKind.Relative);
            bi3.EndInit();

            kosc0Image.Source = bi3;



            //wynik1.Content = u.uklad5[0].OczkaProperty.ToString();
        }



        
    }
}
