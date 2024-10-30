using SPMB_T.__Domain.Entities.Models._02Daftar;

namespace SPMB_T._DataAccess.Repositories.Interfaces
{
    public interface IDPanjarRepository : _IGenericRepository<DPanjar>
    {
        List<DPanjar> GetAllDetails();
        DPanjar GetAllDetailsById(int id);
        string GetMaxRefNo();
        List<DPanjar> GetResults(string? searchString, string? orderBy);
    }
}