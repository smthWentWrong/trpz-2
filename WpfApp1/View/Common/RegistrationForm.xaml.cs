﻿using System;
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

namespace WpfApp1.Model.Entities
{
    /// <summary>
    /// Логика взаимодействия для RegistrationForm.xaml
    /// </summary>
    public partial class RegistrationForm : Window
    {
        
        public RegistrationForm()
        {
            InitializeComponent();
            WpfApp1.ViewModel.Common.RegistrationViewModel viewModel = new WpfApp1.ViewModel.Common.RegistrationViewModel();
            this.DataContext = viewModel;
            viewModel.ClosingRequest += (e, sender) => Close();
        }



    }
}
