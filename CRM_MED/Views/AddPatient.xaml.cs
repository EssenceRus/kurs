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
    /// Логика взаимодействия для AddPatient.xaml
    /// </summary>
    public partial class AddPatient : Window
    {
        public List<Gender> genders { get; set; }
        public AddPatient()
        {
            InitializeComponent();
            var context = new CRMmedContext();
            genders = new List<Gender>();
            genders = context.Genders.ToList();
            
            DataContext = this;
        }

        private void AddBtn(object sender, RoutedEventArgs e)
        {
            
            var context = new CRMmedContext(); 
            Patient patient = new Patient
            {
                Name = name.Text,
                Surname = surname.Text,
                Patronymic = patronymic.Text,
                GenderCodeNavigation = genders[gender.SelectedIndex],
                PhoneNumber = phone.Text,
                ChronicDiseases = hronick.Text,
                Passport = pass.Text,
                SNILS = snils.Text,
                PhotoPath = photo.Text,
                PolicyNumber = policy.Text,
                PlaceOfRegistration = reg.Text,
                BirthDay = Convert.ToDateTime(birthday.Text)
            };
            context.Patients.Add(patient);
            context.SaveChanges();
        }
    }
}
