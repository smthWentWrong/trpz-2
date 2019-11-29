using System;
using System.Collections.Generic;
using System.Text;
using WpfApp1.Model.Entities.Model.Entities;

namespace WpfApp1.Model.Entities
{
    public class User 
    {

        public int Id { get; set; }
        public string Login { get; set; }
        
        public string Password { get; set; }

        public bool Admin { get; set; }

        public UserInformation userInformation { get; set; }

        public User()
        {
            
        }

        public override bool Equals(object obj)
        {
            var user = obj as User;
            return user != null &&
                   Id == user.Id;
        }
        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }
    }





    public class Person
    {


 
    }
}
