using SPMB_T.__Domain.Entities.Models._02Daftar;
using SPMB_T.__Domain.Entities.Models._03Akaun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T._DataAccess.Repositories.Interfaces
{
    public interface IDPenerimaCekGajiRepository : _IGenericRepository<DPenerimaCekGaji>
    {
        public DPenerimaCekGaji GetAllDetailsById(int id);
        public List<DPenerimaCekGaji> GetAllDetails();
        public List<AkJanaanProfil> GetAllDetailsById();
        public string GetMaxRefNo();

    }
}