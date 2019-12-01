using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.Model.Entities.ViewModel;
using WpfApp1.Model.Entities;
namespace WpfApp1.ViewModel.Common
{
    public class RecoveryPasswordViewModel
    {
        private string _email;
        private RelayCommand _toLoginPageCommand;
        private RelayCommand _sendLetterToEmailCommand;
        public event EventHandler ClosingRequest;

        public RelayCommand ToLoginPageCommand
        {
            get
            {
                return _toLoginPageCommand ??
                    (_toLoginPageCommand = new RelayCommand(obj =>
                    {
                        ClosingRequest?.Invoke(this, EventArgs.Empty);
                    }));
                    
                     
            }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public RelayCommand SendLetterToEmailCommand
        {
            get
            {
                return _sendLetterToEmailCommand ??
                    (_sendLetterToEmailCommand = new RelayCommand(obj =>
                    {
                        if (Email != null)
                        {
                            MessageBox.Show("Check your email!We was send a letter.", "", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                        else { MessageBox.Show("Email doesn`t exist or the field is empty", "", MessageBoxButton.OK, MessageBoxImage.Information); }
                    }
                    ));
            }
        }

    }
}
