using SPMB_T.__Domain.Entities.Models._01Jadual;
using SPMB_T._DataAccess.Data;
using SPMB_T._DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T._DataAccess.Repositories.Implementations
{
    public class JKategoriPCBRepository : _GenericRepository<JKategoriPCB>, IJKategoriPCB
    {
        public JKategoriPCBRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
