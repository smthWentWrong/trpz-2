using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfApp1.Model.Entities.Model.Context;
using WpfApp1.Model.Entities.Model.DALInterfaces;
using WpfApp1.Model.Entities.Model.Entities;
using WpfApp1.Model.Entities.View.Admin;

namespace WpfApp1.Model.Entities.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {

        private string _login;
        private string _password;


        private RelayCommand _loginCommand;
        private RelayCommand _paswordChangedCommand;
        private RelayCommand _openRegistrationPageCommand;
        private RelayCommand _openRecoveryPasswordPageCommand;


        public event EventHandler ClosingRequest;


        public string Login
        {
            get { return _login; }
            set
            {
                _login = value;
                OnPropertyChanged("Login");
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged("Password");
            }
        }
        
        public RelayCommand LoginCommand
        {
            get
            {
                return _loginCommand ??
                    (_loginCommand = new RelayCommand(obj =>
                    {
                        using (MainContext mainContext = new MainContext())
                        {
                            var userRepository = new UserRepository(mainContext);
                            
                            WpfApp1.Model.Entities.User user = userRepository.List(u => (u.Login == Login && u.Password==Password)).FirstOrDefault();
                            if (user == null)
                            {
                                MessageBox.Show("There is no such user!");
                            }
                            else
                            {
                                if (user.Admin)
                                {
                                    AdminPage adminView = new AdminPage();
                                    adminView.Show();
                                }
                                else
                                {
                                    UserPage userPage = new UserPage();
                                    userPage.Show();
                                }


                                
                                mainContext.SaveChanges();
                                
                                ClosingRequest?.Invoke(this, EventArgs.Empty);
                            }
                            }
                    }
                    ));

            }
        }

        public RelayCommand PasswordChangedCommand
        {
            get
            {
                return _paswordChangedCommand ??
                    (_paswordChangedCommand = new RelayCommand(obj =>
                    {
                        PasswordBox passwordBox = obj as PasswordBox;
                        Password = passwordBox.Password;
                    }
                    ));
            }
        }
        public RelayCommand OpenRegistrationPageCommand
        {
            get
            {
                return _openRegistrationPageCommand ??
                    (_openRegistrationPageCommand = new RelayCommand(obj=>
                    {
                        RegistrationForm registration = new RegistrationForm();
                        registration.Show();
                    }));
            }
        }
        public RelayCommand OpenRecoveryPasswordPageCommand
        {
            get
            {
                return _openRecoveryPasswordPageCommand ??
                    (_openRecoveryPasswordPageCommand = new RelayCommand(obj =>
                    {
                        RecoveryPasswordForm registration = new RecoveryPasswordForm();
                        registration.Show();
                    }));
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }

    
}
