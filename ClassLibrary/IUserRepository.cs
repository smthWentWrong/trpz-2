using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1.Model.Entities
{
    interface IUserRepository
    {
        IEnumerable GetUsers();
        User GetUserByID(int customerId);
        void InsertUser(User customer);
        void DeleteUser(int customerId);
        void UpdateUser(User customer);
        void Save();
    }
}
