using SPMB_T.__Domain.Entities.Models._03Akaun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T._DataAccess.Repositories.Interfaces
{
    public interface IAkAnggarLejarRepository<T1> where T1 : class
    {
        public Task<IEnumerable<T1>> GetResults(int? JKWPTJBahagianId, int? AkCartaId, DateTime? DateFrom, DateTime? DateTo);
    }
}
