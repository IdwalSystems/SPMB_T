using SPMB_T.__Domain.Entities.Models._02Daftar;
using SPMB_T.__Domain.Entities.Models._03Akaun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T._DataAccess.Repositories.Interfaces
{
    public interface IAkRekupRepository : _IGenericRepository<AkRekup>
    {
        List<AkRekup> GetAllDetails();
        List<AkRekup> GetAllExceptBakiAwalByDPanjarId(int dPanjarId);
        List<AkRekup> GetAllFilteredBy(bool isLinked);
        AkRekup GetDetailsByBakiAwalAndDPanjarId(string noRujukan, int dPanjarId, bool isLinked);
        AkRekup GetDetailsById(int id);
        AkRekup GetDetailsLastByDPanjarId(int dPanjarId);
        string GetMaxRefNoByDPanjarId(string initNoRujukan, int dPanjarId);
    }
}
