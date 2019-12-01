using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WpfApp1.Model.Entities.Model.Entities
{
    public class UserInformation
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public enum Sex { male, female }
        public enum Status { married,not_married}
        public Status? State { get; set; }
        public Sex? Gender { get; set; }
        public string IdentificationCode { get; set; }
        public string Passport { get; set; }
        public string DateOfBirthday { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int BuildID { get; set; }
        public List<Build> Build { get; set; }
        public int TransportID { get; set; }
        public List<Transport> Transport {get; set;}

    }
}
