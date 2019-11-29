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

namespace WpfApp1.Model.Entities.View.Admin
{
    /// <summary>
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Window
    {
        public AdminPage()
        {
            InitializeComponent();
            ViewModel.Admin.AdminViewModel viewmodel = new ViewModel.Admin.AdminViewModel();
            DataContext = viewmodel;
            viewmodel.ClosingRequest += (sender, e) => Close();
            
        }



        private void AdminPage_Loaded(object sender, RoutedEventArgs e)
        {
           // DataContext = new ViewModel.AdminControlViewModel();
        }
    }
}
