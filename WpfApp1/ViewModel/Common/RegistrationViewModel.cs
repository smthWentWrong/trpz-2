using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfApp1.Model.EFRepository;
using WpfApp1.Model.Entities;
using WpfApp1.Model.Entities.Model.Context;
using WpfApp1.Model.Entities.Model.DALInterfaces;
using WpfApp1.Model.Entities.Model.Entities;
using WpfApp1.Model.Entities.ViewModel;

namespace WpfApp1.ViewModel.Common
{
    public class RegistrationViewModel : INotifyPropertyChanged
    {
        private string _password;
        private string _login;
        private string _addFirstname;
        private string _addSurname;
        private UserInformation.Sex? _addGender;
        private UserInformation.Status? _addStatus;
        private string _addIdentificationCode;
        private string _addPassport;
        private string _addDateOfBirthday;
        private string _addTelephone;
        private string _addEmail;
        private string _addAddress;


        public event EventHandler ClosingRequest;

        private RelayCommand _addPaswordChangedCommand;

        private RelayCommand _createAccountCommand;
        private RelayCommand _toLoginPageCommand;
        [Required(ErrorMessage ="should not be empty")]
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
        public string FirstName
        {
            get { return _addFirstname; }
            set { 
                _addFirstname = value;
                OnPropertyChanged("FirstName");
            }
        }
        public string SurName
        {
            get { return _addSurname; }
            set
            {
                _addSurname = value;
                OnPropertyChanged("SurName");
            }
        }

        public IEnumerable<UserInformation.Sex> Genders 
        {
            get { return Enum.GetValues(typeof(UserInformation.Sex)).Cast<UserInformation.Sex>(); }
        }
        public IEnumerable<UserInformation.Status> Status
        {
            get { return Enum.GetValues(typeof(UserInformation.Status)).Cast<UserInformation.Status>(); }
        }
        public UserInformation.Sex? AddGender
        {
            get { return _addGender; }
            set
            {
                _addGender = value;
                OnPropertyChanged("AddGender");
            }
        }
        public UserInformation.Status? AddStatus
        {
            get { return _addStatus; }
            set
            {
                _addStatus = value;
                OnPropertyChanged("AddStatus");
            }
        }
        public string IdentificationCode
        {
            get { return _addIdentificationCode; }
            set
            {
                _addIdentificationCode = value;
                OnPropertyChanged("IdentificationCode");
            }
        }
        public string Passport
        {
            get { return _addPassport; }
            set
            {
                _addPassport = value;
                OnPropertyChanged("Passport");
            }
        }
        public string DateOfBirthday
        {
            get { return _addDateOfBirthday; }
            set
            {
                _addDateOfBirthday = value;
                OnPropertyChanged("DateOfBirthday");
            }
        }
        public string Telephone
        {
            get { return _addTelephone; }
            set
            {
                _addTelephone = value;
                OnPropertyChanged("Telephone");
            }
        }
        public string Email
        {
            get { return _addEmail; }
            set
            {
                _addEmail = value;
                OnPropertyChanged("Email");
            }
        }
        public string Address
        {
            get { return _addAddress; }
            set
            {
                _addAddress = value;
                OnPropertyChanged("Address");
            }
        }



        public RelayCommand PasswordChangedCommand
        {
            get
            {
                return _addPaswordChangedCommand ??
                    (_addPaswordChangedCommand = new RelayCommand(obj =>
                    {
                        PasswordBox passwordBox = obj as PasswordBox;
                        Password = passwordBox.Password;
                    }
                    ));
            }
        }

        

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
                        using (MainContext mainContext = new MainContext())
                        {
                            //logic of create new account
                            var userRepository = new UserRepository(mainContext);
                            User user = userRepository.List(u => (u.Login == Login && u.Password == Password)).FirstOrDefault();

                            if (user == null) 
                            {
                                User newuser = new User
                                {

                                    Login = Login,
                                    Password = Password,
                                    Admin = false
                                    
                                };
                                userRepository.Add(newuser);
                                UserInformation userInformation = new UserInformation
                                {
                                    UserID = newuser.Id,            
                                    Firstname = FirstName,
                                    Surname = SurName,
                                    Gender = AddGender,
                                    State = AddStatus,
                                    IdentificationCode =IdentificationCode,
                                    Passport = Passport,
                                    DateOfBirthday = DateOfBirthday,
                                    Telephone = Telephone,
                                    Email=Email,
                                    Address=Address
                                };
                                var userInforamtionRepository = new UserInformationRepository(mainContext);
                                userInforamtionRepository.Add(userInformation);
                                
                                mainContext.SaveChanges(); 
                                MessageBox.Show("Account was created succesfully!", "", MessageBoxButton.OK, MessageBoxImage.Information);
                                ClosingRequest?.Invoke(this, EventArgs.Empty);
                                
                            }
                            else
                            {
                                MessageBox.Show("User with such login and password already registered!");
                            }
                            
                        }

                        
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
