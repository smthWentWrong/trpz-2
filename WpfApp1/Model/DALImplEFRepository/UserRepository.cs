using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model.Entities.Model.Context;
using WpfApp1.Model.Entities.Model.Repositories;

namespace WpfApp1.Model.Entities.Model.DALInterfaces
{
    public class UserRepository : GenericRepository<User>,IUserRepository
    {
        
        public UserRepository(MainContext mainContext) : base(mainContext)
        {

        }
        
    }


}
