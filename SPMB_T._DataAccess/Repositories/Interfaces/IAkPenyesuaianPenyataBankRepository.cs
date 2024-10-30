using SPMB_T.__Domain.Entities._Enums;
using SPMB_T.__Domain.Entities.Models._03Akaun;
using System.Linq.Expressions;

namespace SPMB_T._DataAccess.Repositories.Interfaces
{
    public interface IAkPenyesuaianPenyataBankRepository : _IGenericRepository<AkPenyesuaianBank>
    {
        List<AkPenyesuaianBankPenyataBank> GetAkPenyesuaianBankPenyataBankByAkPenyesuaianBankId(int Id);
        AkPenyesuaianBank GetDetailsById(int id);
        string GetMaxRefNo(string initNoRujukan, string tahun);
        List<AkPenyesuaianBank> GetResults(string? searchString, DateTime? dateFrom, DateTime? dateTo, string? orderBy, EnStatusBorang enStatusBorang);
        bool IsAkPenyesuaianBankPenyataBankExist(Expression<Func<AkPenyesuaianBankPenyataBank, bool>> predicate);
        Task<bool> IsPostedAsync(int id, string noRujukan);
    }
}
