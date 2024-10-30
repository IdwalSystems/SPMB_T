using SPMB_T.__Domain.Entities._Enums;
using SPMB_T.__Domain.Entities.Models._03Akaun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T._DataAccess.Repositories.Interfaces
{
    public interface IAkJanaanProfilRepository : _IGenericRepository<AkJanaanProfil>
    {
        public List<AkJanaanProfil> GetResults(string? searchString, DateTime? dateFrom, DateTime? dateTo, string? orderBy, EnStatusBorang enStatusBorang);
        public AkJanaanProfil GetDetailsById(int id);
        public string GetMaxRefNo(string initNoRujukan, string tahun);

    }
}
