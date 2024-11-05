using SPMB_T.__Domain.Entities.Models._01Jadual;

namespace SPMB_T._DataAccess.Repositories.Interfaces
{
    public interface IJGredTanggaGaji : _IGenericRepository<JGredTanggaGaji>
    {
        List<JGredTanggaGaji> GetAllDetails();
        JGredTanggaGaji GetDetailsById(int id);
    }
}
