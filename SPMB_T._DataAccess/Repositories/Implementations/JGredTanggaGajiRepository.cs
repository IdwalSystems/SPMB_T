using SPMB_T.__Domain.Entities.Models._01Jadual;
using SPMB_T._DataAccess.Data;
using SPMB_T._DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace SPMB_T._DataAccess.Repositories.Implementations
{
    public class JGredTanggaGajiRepository : _GenericRepository<JGredTanggaGaji>, IJGredTanggaGaji
    {
        private readonly ApplicationDbContext _context;

        public JGredTanggaGajiRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public List<JGredTanggaGaji> GetAllDetails()
        {
            return _context.JGredTanggaGaji
                .Include(gtg => gtg.JTanggaGaji)
                .Include(gtg => gtg.JGredGaji)
                .ToList();
        }

        public JGredTanggaGaji GetDetailsById(int id)
        {
            return _context.JGredTanggaGaji
                .Include(gtg => gtg.JTanggaGaji)
                .Include(gtg => gtg.JGredGaji)
                .FirstOrDefault(gtg => gtg.Id == id) ?? new JGredTanggaGaji();
        }
    }
}