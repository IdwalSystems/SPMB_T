using SPMB_T.__Domain.Entities.Models._01Jadual;
using SPMB_T._DataAccess.Data;
using SPMB_T._DataAccess.Repositories.Interfaces;

namespace SPMB_T._DataAccess.Repositories.Implementations
{
    internal class JNegeriRepository : _GenericRepository<JNegeri>, IJNegeriRepository
    {
        public JNegeriRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}