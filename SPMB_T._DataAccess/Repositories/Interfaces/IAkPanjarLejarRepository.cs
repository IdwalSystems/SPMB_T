using SPMB_T.__Domain.Entities.Models._03Akaun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T._DataAccess.Repositories.Interfaces
{
    public interface IAkPanjarLejarRepository
    {
        AkPanjarLejar GetDetailsLastByDPanjarId(int dPanjarId);
        List<AkPanjarLejar> GetListByDPanjarId(int dPanjarId);
        Task<bool> IsExistAsync(Expression<Func<AkPanjarLejar, bool>> predicate);
        void UpdateRange(List<AkPanjarLejar> akPanjarLejarList);
    }
}
