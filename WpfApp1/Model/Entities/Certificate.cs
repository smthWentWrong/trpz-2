using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model.Entities.Model.Entities
{
    public class Certificate
    {
        
        public int ID { get; set; }
        public string RegistrationNumber { get; set; }
        public string PlaceRegistration { get; set; }
        public string PurchaseDate { get; set; }
        
        public int BuildID { get; set; }
        public Build Build { get; set; }
    }
}
