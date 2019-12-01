using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model.DALInterfaces;
using WpfApp1.Model.Entities;
using WpfApp1.Model.Entities.Model.Context;
using WpfApp1.Model.Entities.Model.Repositories;

namespace WpfApp1.Model.EFRepository
{
    public class TransportRepository:GenericRepository<Transport>,ITransportRepository
    {
        public TransportRepository(MainContext maincontext) : base(maincontext) { }
    }
}
