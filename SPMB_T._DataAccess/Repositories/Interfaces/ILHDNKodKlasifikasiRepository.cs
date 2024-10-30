using SPMB_T.__Domain.Entities.Models._50LHDN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T._DataAccess.Repositories.Interfaces
{
    public interface ILHDNKodKlasifikasiRepository : _IGenericRepository<LHDNKodKlasifikasi>
    {
        Task<LHDNKodKlasifikasi> GetByCodeAsync(string code);
    }
}
