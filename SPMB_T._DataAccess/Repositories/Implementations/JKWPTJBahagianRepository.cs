using Microsoft.EntityFrameworkCore;
using SPMB_T.__Domain.Entities.Models._01Jadual;
using SPMB_T._DataAccess.Data;
using SPMB_T._DataAccess.Repositories.Interfaces;

namespace SPMB_T._DataAccess.Repositories.Implementations
{
    public class JKWPTJBahagianRepository : _GenericRepository<JKWPTJBahagian>, IJKWPTJBahagianRepository
    {
        private readonly ApplicationDbContext _context;

        public JKWPTJBahagianRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public List<JKWPTJBahagian> GetAllDetails()
        {
            return _context.JKWPTJBahagian
                .Include(b => b.JKW)
                .Include(b => b.JPTJ)
                .Include(b => b.JBahagian)
                .ToList();
        }

        public JKWPTJBahagian GetAllDetailsById(int id)
        {
            return _context.JKWPTJBahagian
                .Include(b => b.JKW)
                .Include(b => b.JPTJ)
                .Include(b => b.JBahagian)
                .FirstOrDefault(b => b.Id == id) ?? new JKWPTJBahagian();
        }

        public List<JKWPTJBahagian> GetAllDetailsByJKWId(int JKWId)
        {
            return _context.JKWPTJBahagian
                .Include(b => b.JKW)
                .Include(b => b.JPTJ)
                .Include(b => b.JBahagian).Where(b => b.JKWId == JKWId)
                .ToList();
        }

        public List<JKWPTJBahagian> GetAllDetailsByJPTJId(int JPTJId)
        {
            return _context.JKWPTJBahagian
                .Include(b => b.JKW)
                .Include(b => b.JPTJ)
                .Include(b => b.JBahagian).Where(b => b.JPTJId == JPTJId)
                .ToList();
        }
    }
}