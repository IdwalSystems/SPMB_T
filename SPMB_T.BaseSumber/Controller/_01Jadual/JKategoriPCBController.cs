using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SPMB_T.__Domain.Entities._Statics;
using SPMB_T.__Domain.Entities.Administrations;
using SPMB_T._DataAccess.Data;
using SPMB_T._DataAccess.Repositories.Interfaces;

namespace SPMB_T.BaseSumber.Controller._01Jadual
{
    [Authorize(Roles = Init.superAdminSupervisorRole)]
    public class JKategoriPCBController : Microsoft.AspNetCore.Mvc.Controller
    {
        public const string modul = Modules.kodJKategoriPCB;
        public const string namamodul = Modules.namaJKategoriPCB;

        private readonly _IUnitOfWork _unitOfWork;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly _AppLogIRepository<AppLog, int> _appLog;

        public JKategoriPCBController(
            _IUnitOfWork unitOfWork,
            ApplicationDbContext context,
            UserManager<IdentityUser> userManager,
            _AppLogIRepository<AppLog, int> appLog)
        {
            _unitOfWork = unitOfWork;
            _context = context;
            _userManager = userManager;
            _appLog = appLog;
        }
        public IActionResult Index()
        {
            return View(_unitOfWork.JKategoriPCBRepo.GetAllIncludeDeleted());
        }
    }
}
