using System;
using System.Collections.Generic;

using System.Text;

namespace WpfApp1.Model.Entities
{
    public class User:Person
        {
        private int uid;

        private string passport;

        private string identificationCode;

        private string email;

        private bool married;

        public string Passport
        {
            get { return passport; }
            set { passport = value; }
        }
        public User(string name,string firstname,string secondname):base(name,firstname, secondname)
        {
            
        }

        public User()
        {

        }



    }
}
