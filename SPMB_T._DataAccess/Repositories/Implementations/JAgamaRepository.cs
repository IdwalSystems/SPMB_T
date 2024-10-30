using SPMB_T.__Domain.Entities.Models._01Jadual;
using SPMB_T._DataAccess.Data;
using SPMB_T._DataAccess.Repositories.Interfaces;

namespace SPMB_T._DataAccess.Repositories.Implementations
{
    public class JAgamaRepository : _GenericRepository<JAgama>, IJAgamaRepository
    {
        private readonly ApplicationDbContext _context;

        public JAgamaRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}