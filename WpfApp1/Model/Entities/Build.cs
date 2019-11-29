using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model.Entities.Model.Entities
{
    public class Build
    {
        public int ID { get; set; }
        public int IDUserInfo { get; set; }
        public enum TypeOfBuild { Квартира, будинок, Гараж, Інше }
        public string Address { get; set; }
        public int Area { get; set; }
        public int RoomsCount { get; set; }
        public int CertificateID { get; set; }
        public Certificate Certificate { get; set; }

    }
}
