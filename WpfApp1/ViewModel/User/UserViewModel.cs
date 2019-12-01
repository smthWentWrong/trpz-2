using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model.EFRepository;
using WpfApp1.Model.Entities.Model.Context;
using WpfApp1.Model.Entities.Model.Entities;

namespace WpfApp1.Model.Entities.ViewModel.User
{
    public class UserViewModel:INotifyPropertyChanged
    {
        private UserInformationRepository _userInformationRepository;
        private string _userFullName;
        private UserInformation.Sex? _Gender;
        private UserInformation.Status? _Status;
        private string _IdentificationCode;
        private string _Passport;
        private string _DateOfBirthday;
        private string _Telephone;
        private string _Email;
        private string _Address;

        private RelayCommand _exitToLoginPageCommand;
        public string UserFullName
        {
            get { return _userFullName; }
            set
            {
                _userFullName = value;
                OnPropertyChanged("UserFullName");
            }
        }


        public UserInformation.Sex? Gender
        {
            get { return _Gender; }
            set
            {
                _Gender = value;
                OnPropertyChanged("Gender");
            }
        }
        public UserInformation.Status? Status
        {
            get { return _Status; }
            set
            {
                _Status = value;
                OnPropertyChanged("Status");
            }
        }
        public string IdentificationCode
        {
            get { return _IdentificationCode; }
            set
            {
                _IdentificationCode = value;
                OnPropertyChanged("IdentificationCode");
            }
        }
        public string Passport
        {
            get { return _Passport; }
            set
            {
                _Passport = value;
                OnPropertyChanged("Passport");
            }
        }
        public string DateOfBirthday
        {
            get { return _DateOfBirthday; }
            set
            {
                _DateOfBirthday = value;
                OnPropertyChanged("DateOfBirthday");
            }
        }
        public string Telephone
        {
            get { return _Telephone; }
            set
            {
                _Telephone = value;
                OnPropertyChanged("Telephone");
            }
        }
        public string Email
        {
            get { return _Email; }
            set
            {
                _Email = value;
                OnPropertyChanged("Email");
            }
        }
        public string Address
        {
            get { return _Address; }
            set
            {
                _Address = value;
                OnPropertyChanged("Address");
            }
        }
        public RelayCommand ExitToLoginPageCommand
        {
            get
            {
                return _exitToLoginPageCommand ??
                    (_exitToLoginPageCommand = new RelayCommand(obj =>
                    {
                        LoginView view = new LoginView();
                        view.Show();
                        ClosingRequest?.Invoke(this, EventArgs.Empty);
                    }));


            }
        }
        public UserViewModel()
        {
            using (MainContext maincontext= new MainContext())
            {
                _userInformationRepository = new UserInformationRepository(maincontext);
                var userInformation = _userInformationRepository.List(u=>(u.UserID == ApplicationContext.CurrentUser.Id)).FirstOrDefault();
                UserFullName = userInformation.Surname +" "+ userInformation.Firstname;
                Status = userInformation.State;
                IdentificationCode = userInformation.IdentificationCode;
                Passport = userInformation.Passport;
                Telephone = userInformation.Telephone;
                Email = userInformation.Email;
                Address = userInformation.Address;
                DateOfBirthday = userInformation.DateOfBirthday;
            }

                
        }
        public event EventHandler ClosingRequest;

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
