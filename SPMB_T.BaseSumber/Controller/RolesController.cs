using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SPMB_T.__Domain.Entities._Statics;
using SPMB_T._DataAccess.Data;

namespace SPMB_T.BaseSumber.Controller
{
    [Authorize(Roles = Init.superAdminAdminRole)]
    public class RolesController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly ApplicationDbContext db;

        public RolesController(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var roles = db.Roles.ToList();
            return View(roles);
        }
    }
}
