using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1.Model.Entities
{
    public class Person
    {
        private string _name;
        private string _firstname;
        private string _secondname;

        public Person(string name,string firstname,string secondname)
        {
            _name = name;
            _firstname = firstname;
            _secondname = secondname;
            
        }
        public Person()
        {
            throw new System.NotImplementedException();
        }
    }
}
