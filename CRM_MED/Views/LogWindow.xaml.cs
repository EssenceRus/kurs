using CRM_MED.Models;
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

namespace CRM_MED.Views
{
    /// <summary>
    /// Логика взаимодействия для Log_Window.xaml
    /// </summary>
    public partial class Log_Window : Window
    {

        public Log_Window()
        {
            InitializeComponent();

        }
        private void IsAdmin(object sender, RoutedEventArgs e)
        {
            if(admin.IsChecked== true)
            {
                Login.Visibility = Visibility.Collapsed;
            }
            else
            {
                Login.Visibility = Visibility.Visible;
            }
        }

        private void Enter(object sender, RoutedEventArgs e)
        {
            if (admin.IsChecked == true)
            {
                using (var context = new CRMmedContext())
                {
                    var password = context.Admins.First().Password;
                    if (Password.Text == password)
                    {
                        MessageBox.Show("KRUT");
                    }
                    else
                    {
                        MessageBox.Show("Admin пароль неверный");
                    }
                }
            }
            else
            {
                using (var context = new CRMmedContext())
                {

                    var bol = context.Doctors.Where(d => d.Login == Login.Text).Any();
                    if (bol)
                    {
                        var doctor = context.Doctors.Where(d => d.Login == Login.Text).ToList();
                        if (Password.Text == doctor[0].Password && Login.Text == doctor[0].Login)
                        {
                            MessageBox.Show("Всё круто");
                        }
                        else
                        {
                            MessageBox.Show("Неверный пароль");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин");
                    }
                }
            }
        }
    }
}
