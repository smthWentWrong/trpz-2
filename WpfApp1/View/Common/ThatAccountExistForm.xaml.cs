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

namespace WpfApp1.Model.Entities
{
    /// <summary>
    /// Логика взаимодействия для ThatAccountExist.xaml
    /// </summary>
    public partial class ThatAccountExistForm : Window
    {
        LoginView _prevWindow;
        public ThatAccountExistForm()
        {
            InitializeComponent();
        }
        public ThatAccountExistForm(LoginView prevWindow)
        {
            InitializeComponent();
            _prevWindow = prevWindow;
        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
            _prevWindow.Show();
            
        }


        //private void OnClosing(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    MessageBoxResult result = MessageBox.Show("Really close?", "Warning", MessageBoxButton.YesNo);
        //    if (result != MessageBoxResult.Yes)
        //    {
        //        e.Cancel = true;
        //    }

            //bool shouldClose = (()DataContext).TryClose(false);
            //if (!shouldClose)
            //{
            //    e.Cancel = true;
            //}
        //}
    }
}
