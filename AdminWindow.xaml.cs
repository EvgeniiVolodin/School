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
using System.Windows.Shapes;

namespace School
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyWindow.Navigate(new Pages.GraphicCurses());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MyWindow.Navigate(new CompletedCurses());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MyWindow.Navigate(new Pages.CreateCurses());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MyWindow.Navigate(new Pages.Otchet());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MyWindow.Navigate(new Pages.CreateRaspisanie());
        }
    }
}
