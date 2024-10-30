using SPMB_T.__Domain.Entities.Administrations;
using SPMB_T._DataAccess.Data;
using SPMB_T._DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T._DataAccess.Repositories.Implementations
{
    internal class _ApplicationUserRepository : _IApplicationUserRepository
    {
        private readonly ApplicationDbContext context;

        public _ApplicationUserRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public ApplicationUser GetApplicationUser(string id)
        {
            return context.ApplicationUsers.FirstOrDefault(b => b.Id == id) ?? new ApplicationUser();
        }
    }
}
