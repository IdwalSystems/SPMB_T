using SPMB_T.__Domain.Entities.Administrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T._DataAccess.Repositories.Interfaces
{
    public interface _IApplicationUserRepository
    {
        ApplicationUser GetApplicationUser(string id);
    }
}
