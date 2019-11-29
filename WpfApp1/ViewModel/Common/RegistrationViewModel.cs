using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.Model.Entities;
using WpfApp1.Model.Entities.Model.Entities;
using WpfApp1.Model.Entities.ViewModel;

namespace WpfApp1.ViewModel.Common
{
    public class RegistrationViewModel : INotifyPropertyChanged
    {
        private User user;
        private string _Name;
        private string Surname;

        public IEnumerable<UserInformation.Sex> Genders 
        {
            get { return Enum.GetValues(typeof(UserInformation.Sex)).Cast<UserInformation.Sex>(); }
        } 

        private RelayCommand _createAccountCommand;
        private RelayCommand _toLoginPageCommand;



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
        public RelayCommand CreateAccountCommand
        {
            get
            {
                return _createAccountCommand ??
                    (_createAccountCommand = new RelayCommand(obj =>
                    {




                        //logic of create new account
                        MessageBox.Show("Account was created succesfully!", "", MessageBoxButton.OK, MessageBoxImage.Information);
                        ClosingRequest?.Invoke(this, EventArgs.Empty);
                    }));


            }
        }

        public RegistrationViewModel()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
