using System.Collections.Generic;
using System.Data.Entity;
using WpfApp1.Model.Entities.Model.DALInterfaces;

namespace WpfApp1.Model.Entities.Model.Context
{
    public class ContextInitializer : CreateDatabaseIfNotExists<MainContext>
    {
        private UserRepository _userRepository;
        protected override void Seed(MainContext mainContext)
        {
            _userRepository = new UserRepository(mainContext);
            InitializeUsers();
        }


        private void InitializeUsers()
        {
            List<User> users = new List<User>
            {
                new User{Login = "user", Password = "user", Admin = false},
                new User { Login = "admin", Password = "admin", Admin = true }
            };
            foreach (User user in users)
            {
                _userRepository.Add(user);
            }
        }
        
    }
}