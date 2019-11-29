using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model.Entities.Model.Entities;

namespace WpfApp1.Model.Entities.Model.Context
{
    public class MainContext : DbContext
    {
        //static MainContext()
        //{
        //    Database.SetInitializer<MainContext>(new ContextInitializer());
        //}
        public MainContext() : base("DbConnection")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserInformation> UsersInfromation {get;set;}
        public DbSet<Build> Builds { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Transport> Transports { get; set; }
    }
}
