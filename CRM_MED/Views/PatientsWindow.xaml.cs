using CRM_MED.Models;
using Microsoft.EntityFrameworkCore;
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
    /// Логика взаимодействия для PatientsWindow.xaml
    /// </summary>
    public partial class PatientsWindow : Window
    {
        
        public PatientsWindow()
        {
            InitializeComponent();
            var context = new CRMmedContext();
            var patients = context.Patients.Include(cs=>cs.GenderCodeNavigation).ToList().OrderBy(p=>p.Surname);
            LViewPatient.ItemsSource = patients;
            
        }

        private void TBFind_change(object sender, TextChangedEventArgs e)
        {
            var context = new CRMmedContext();
            var patients = context.Patients.Where(p => p.Surname.ToLower().Contains(TBFind.Text.ToLower())).ToList();
            LViewPatient.ItemsSource = patients;
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            AddPatient add = new AddPatient();
            add.Show();
        }
    }
}
