using Microsoft.EntityFrameworkCore;
using SPMB_T.__Domain.Entities.Models._01Jadual;
using SPMB_T._DataAccess.Data;
using SPMB_T._DataAccess.Repositories.Interfaces;

namespace SPMB_T._DataAccess.Repositories.Implementations
{
    public class JBahagianRepository : _GenericRepository<JBahagian>, IJBahagianRepository
    {
        private readonly ApplicationDbContext _context;

        public JBahagianRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public List<JBahagian> GetAllDetails()
        {
            return _context.JBahagian.Include(b => b.JKWPTJBahagian).ToList();
        }

        public JBahagian GetAllDetailsById(int id)
        {
            return _context.JBahagian.Include(b => b.JKWPTJBahagian).Where(b => b.Id == id).FirstOrDefault() ?? new JBahagian();
        }
    }
}