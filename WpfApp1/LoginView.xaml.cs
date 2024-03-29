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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1.Model.Entities
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            
            InitializeComponent();
            ColorAnimation animation = new ColorAnimation();
            animation.From = Colors.Orange;
            animation.To = Colors.Black;
            animation.Duration = new Duration(TimeSpan.FromSeconds(5));
            BackGround.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            
            ViewModel.LoginViewModel viewModel = new ViewModel.LoginViewModel();
            DataContext = viewModel;
            viewModel.ClosingRequest += (sender, e) => Close();
           
        }


    }
}
