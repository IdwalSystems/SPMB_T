using SPMB_T.__Domain.Entities.Models._03Akaun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T._DataAccess.Repositories.Interfaces
{
    public interface IAkBankRepository : _IGenericRepository<AkBank>
    {
        public List<AkBank> GetAllDetails();
        public AkBank GetAllDetailsById(int id);
    }
}
