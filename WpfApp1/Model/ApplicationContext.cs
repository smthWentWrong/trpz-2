using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model.Entities;

namespace WpfApp1.Model
{
    public class ApplicationContext
    {
        public static User CurrentUser { get; set; }
    }
}
