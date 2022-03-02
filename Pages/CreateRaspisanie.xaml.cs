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

namespace School.Pages
{
    /// <summary>
    /// Логика взаимодействия для CreateRaspisanie.xaml
    /// </summary>
    public partial class CreateRaspisanie : Page
    {
        private Raspisanie _context = new Raspisanie();

        public CreateRaspisanie()
        {
            InitializeComponent();
            DataContext = _context;
            Discipl.ItemsSource = DB.db.Disciplini.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Number.Text == "" || Int64.Parse(Number.Text) <= 0 || Kabinet.Text == "" || Int64.Parse(Kabinet.Text) <= 0 || Discipl.SelectedIndex == -1 || TeacherT.SelectedIndex == -1 || DT.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                MessageBox.Show("Данные сохранены");
            }
        }
    }
}
