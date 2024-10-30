using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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
    public class JKWRepository : _GenericRepository<JKW>, IJKWRepository
    {
        private readonly ApplicationDbContext _context;

        public JKWRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public EntityEntry Entry(JKW jkw)
        {
            return _context.Entry(jkw);
        }

        public List<JKW> GetAllDetails()
        {
            return _context.JKW.Include(kw => kw.JKWPTJBahagian)
                    .ThenInclude(kw => kw.JPTJ)
                .Include(kw => kw.JKWPTJBahagian)
                    .ThenInclude(kw => kw.JBahagian).
                    ToList();
        }

        public JKW GetAllDetailsById(int id)
        {
            return _context.JKW
                .Include(kw => kw.JKWPTJBahagian)
                    .ThenInclude(kw => kw.JPTJ)
                .Include(kw => kw.JKWPTJBahagian)
                    .ThenInclude(kw => kw.JBahagian)
                .FirstOrDefault(kw => kw.Id == id) ?? new JKW();
        }
    }
}
