using Microsoft.EntityFrameworkCore;
using SPMB_T.__Domain.Entities.Models._50LHDN;
using SPMB_T._DataAccess.Data;
using SPMB_T._DataAccess.Repositories.Interfaces;

namespace SPMB_T._DataAccess.Repositories.Implementations
{
    public class LHDNKodKlasifikasiRepository : _GenericRepository<LHDNKodKlasifikasi>, ILHDNKodKlasifikasiRepository
    {
        private readonly ApplicationDbContext _context;

        public LHDNKodKlasifikasiRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<LHDNKodKlasifikasi> GetByCodeAsync(string code)
        {
            return await _context.LHDNKodKlasifikasi.FirstOrDefaultAsync(kk => kk.Code == code) ?? new LHDNKodKlasifikasi();
        }
    }
}