using SPMB_T.__Domain.Entities.Models._01Jadual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T._DataAccess.Repositories.Interfaces
{
    public interface IJKonfigPenyataRepository : _IGenericRepository<JKonfigPenyata>
    {
        JKonfigPenyata GetAllDetailsById(int id);
        JKonfigPenyata GetAllDetailsByTahunOrKod(string? tahun, string? kod);
    }
}
