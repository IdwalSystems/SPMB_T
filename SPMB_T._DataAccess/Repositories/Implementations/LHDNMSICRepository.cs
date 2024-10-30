using SPMB_T.__Domain.Entities.Models._50LHDN;
using SPMB_T._DataAccess.Data;
using SPMB_T._DataAccess.Repositories.Interfaces;

namespace SPMB_T._DataAccess.Repositories.Implementations
{
    public class LHDNMSICRepository : _GenericRepository<LHDNMSIC>, ILHDNMSICRepository
    {
        public LHDNMSICRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}