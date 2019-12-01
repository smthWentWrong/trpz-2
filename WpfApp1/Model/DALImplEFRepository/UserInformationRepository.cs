using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model.DALInterfaces;
using WpfApp1.Model.Entities.Model.Context;
using WpfApp1.Model.Entities.Model.Entities;
using WpfApp1.Model.Entities.Model.Repositories;

namespace WpfApp1.Model.EFRepository
{
    public class UserInformationRepository : GenericRepository<UserInformation>, IUserInformationRepository
    {
     
        public UserInformationRepository(MainContext mainContext) : base(mainContext) {  }


    }
}
