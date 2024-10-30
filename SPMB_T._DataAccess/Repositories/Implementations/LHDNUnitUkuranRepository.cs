using Microsoft.EntityFrameworkCore;
using SPMB_T.__Domain.Entities.Models._50LHDN;
using SPMB_T._DataAccess.Data;
using SPMB_T._DataAccess.Repositories.Interfaces;

namespace SPMB_T._DataAccess.Repositories.Implementations
{
    public class LHDNUnitUkuranRepository : _GenericRepository<LHDNUnitUkuran>, ILHDNUnitUkuranRepository
    {
        private readonly ApplicationDbContext _context;

        public LHDNUnitUkuranRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<LHDNUnitUkuran> GetByCodeAsync(string code)
        {
            return await _context.LHDNUnitUkuran.FirstOrDefaultAsync(uu => uu.Code == code) ?? new LHDNUnitUkuran();
        }
    }
}