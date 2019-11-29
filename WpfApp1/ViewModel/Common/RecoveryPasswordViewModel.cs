using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.Model.Entities.ViewModel;

namespace WpfApp1.ViewModel.Common
{
    public class RecoveryPasswordViewModel
    {
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

        public RelayCommand SendLetterToEmailCommand
        {
            get
            {
                return _sendLetterToEmailCommand ??
                    (_sendLetterToEmailCommand = new RelayCommand(obj =>
                    {
                        MessageBox.Show("Check your email!We was send a letter.", "", MessageBoxButton.OK,MessageBoxImage.Information);
                    }

                    ));
            }
        }

    }
}
