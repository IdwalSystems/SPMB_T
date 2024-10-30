using Microsoft.EntityFrameworkCore;
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
    public class JCawanganRepository : _GenericRepository<JCawangan>, IJCawanganRepository
    {
        private readonly ApplicationDbContext _context;

        public JCawanganRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public JCawangan GetAllDetailsById(int id)
        {
            return _context.JCawangan
                .Include(jc => jc.DPenyelia)
                .Include(jc => jc.AkBank)
                .Where(jc => jc.Id == id).FirstOrDefault() ?? new JCawangan();
        }

    }
}
