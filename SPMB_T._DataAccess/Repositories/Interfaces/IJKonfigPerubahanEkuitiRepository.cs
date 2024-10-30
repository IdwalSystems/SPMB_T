using SPMB_T.__Domain.Entities._Enums;
using SPMB_T.__Domain.Entities.Models._01Jadual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T._DataAccess.Repositories.Interfaces
{
    public interface IJKonfigPerubahanEkuitiRepository : _IGenericRepository<JKonfigPerubahanEkuiti>
    {
        public JKonfigPerubahanEkuiti GetAllDetailsById(int id);
        public List<JKonfigPerubahanEkuiti> GetAllDetails();
        JKonfigPerubahanEkuiti GetAllDetailsByTahunOrJenisEkuiti(string? tahun, EnJenisLajurJadualPerubahanEkuiti? enJenisEkuiti);
    }
}
