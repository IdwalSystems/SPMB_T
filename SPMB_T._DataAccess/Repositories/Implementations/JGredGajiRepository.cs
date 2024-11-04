using SPMB_T.__Domain.Entities.Models._01Jadual;
using SPMB_T._DataAccess.Data;
using SPMB_T._DataAccess.Repositories.Interfaces;

namespace SPMB_T._DataAccess.Repositories.Implementations
{
    public class JGredGajiRepository : _GenericRepository<JGredGaji>, IJGredGaji
    {
        private ApplicationDbContext context;

        public JGredGajiRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }
    }
}