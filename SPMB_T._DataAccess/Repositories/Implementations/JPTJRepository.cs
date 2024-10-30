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
    public class JPTJRepository : _GenericRepository<JPTJ>, IJPTJRepository
    {
        private readonly ApplicationDbContext _context;

        public JPTJRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public List<JPTJ> GetAllDetails()
        {
            return _context.JPTJ.Include(ptj => ptj.JKWPTJBahagian).ThenInclude(ptj => ptj.JKW).ToList();
        }

        public JPTJ GetAllDetailsById(int id)
        {
            return _context.JPTJ.Include(ptj => ptj.JKWPTJBahagian).Where(ptj => ptj.Id == id).FirstOrDefault() ?? new JPTJ();
        }
    }
}
