using SPMB_T.__Domain.Entities.Models._01Jadual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T._DataAccess.Repositories.Interfaces
{
    public interface IJKWPTJBahagianRepository : _IGenericRepository<JKWPTJBahagian>
    {
        public JKWPTJBahagian GetAllDetailsById(int id);
        public List<JKWPTJBahagian> GetAllDetails();
        public List<JKWPTJBahagian> GetAllDetailsByJKWId(int JKWId);
        public List<JKWPTJBahagian> GetAllDetailsByJPTJId(int JPTJId);
    }
}
