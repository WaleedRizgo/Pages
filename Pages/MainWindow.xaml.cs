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

namespace Pages
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           
        }

        private void BtnClickP1(object sender, RoutedEventArgs e)
        {
            Main.Content = new Page1();
        }
        private void BtnClickP2(object sender, RoutedEventArgs e)
        {
            Main.Content = new Page2();
        }
        private void BtnClickP3(object sender, RoutedEventArgs e)
        {
            Main.Content = new Page3();
        }
        private void BtnClickP4(object sender, RoutedEventArgs e)
        {
            Main.Content = new Page4();
        }
        private void BtnClickP5(object sender, RoutedEventArgs e)
        {
            Main.Content = new Page5();
        }
        private void BtnClickP6(object sender, RoutedEventArgs e)
        {
            Main.Content = new Page6();
        }
        private void BtnClickP7(object sender, RoutedEventArgs e)
        {
            Main.Content = new Page7();
        }

        private void BtnClickP8(object sender, RoutedEventArgs e)
        {
            Main.Content = new Page8();
        }
        
    }
}