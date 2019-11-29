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
using WpfApp1.ViewModel.Common;

namespace WpfApp1.Model.Entities
{
    /// <summary>
    /// Логика взаимодействия для RecoveryPassword.xaml
    /// </summary>
    public partial class RecoveryPasswordForm : Window
    {
        
        public RecoveryPasswordForm()
        {
            InitializeComponent();
            RecoveryPasswordViewModel viewmodel = new RecoveryPasswordViewModel();
            this.DataContext = viewmodel;
            viewmodel.ClosingRequest += (sender,e) => Close();
        }

    }
}
