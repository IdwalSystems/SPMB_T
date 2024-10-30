using SPMB_T.__Domain.Entities.Models._01Jadual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T._DataAccess.Repositories.Interfaces
{
    public interface IJPTJRepository : _IGenericRepository<JPTJ>
    {
        public JPTJ GetAllDetailsById(int id);
        public List<JPTJ> GetAllDetails();
    }
}
