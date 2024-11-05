using SPMB_T.__Domain.Entities._Statics;
using SPMB_T.__Domain.Entities.Administrations;
using SPMB_T.__Domain.Entities.Models._01Jadual;
using SPMB_T._DataAccess.Data;
using SPMB_T._DataAccess.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SPMB_T.Sumber.Controller._01Jadual
{
    [Authorize(Roles = Init.superAdminSupervisorRole)]
    public class JElaunPotonganController : Microsoft.AspNetCore.Mvc.Controller
    {
        public const string modul = Modules.kodJElaunPotongan;
        public const string namamodul = Modules.namaJElaunPotongan;

        private readonly ApplicationDbContext _context;
        private readonly _IUnitOfWork _unitOfWork;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly _AppLogIRepository<AppLog, int> _appLog;

        public JElaunPotonganController(ApplicationDbContext context,
            _IUnitOfWork unitOfWork,
            UserManager<IdentityUser> userManager,
            _AppLogIRepository<AppLog, int> appLog)
        {
            _context = context;
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _appLog = appLog;
        }
        public IActionResult Index()
        {
            return View(_unitOfWork.JElaunPotongan.GetAll());
        }

        // GET: KW/Details/5
        [Authorize(Policy = modul)]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var elaunPotongan = _unitOfWork.JElaunPotongan.GetById((int)id);
            if (elaunPotongan == null)
            {
                return NotFound();
            }

            return View(elaunPotongan);
        }

        // GET: KW/Create
        [Authorize(Policy = modul + "C")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: KW/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = modul + "C")]
        public async Task<IActionResult> Create(JElaunPotongan elaunPotongan, string syscode)
        {
            if (elaunPotongan.Kod != null && KodElaunPotonganExists(elaunPotongan.Kod) == false)
            {
                if (ModelState.IsValid)
                {
                    var user = await _userManager.GetUserAsync(User);
                    int? pekerjaId = _context.ApplicationUsers.Where(b => b.Id == user!.Id).FirstOrDefault()!.DPekerjaId;

                    elaunPotongan.UserId = user?.UserName ?? "";

                    elaunPotongan.TarMasuk = DateTime.Now;
                    elaunPotongan.DPekerjaMasukId = pekerjaId;

                    _context.Add(elaunPotongan);
                    _appLog.Insert("Tambah", elaunPotongan.Kod ?? "", elaunPotongan.Kod ?? "", 0, 0, pekerjaId, modul, syscode, namamodul, user);
                    await _context.SaveChangesAsync();
                    TempData[SD.Success] = "Data berjaya ditambah..!";
                    return RedirectToAction(nameof(Index));

                }
            }
            else
            {
                TempData[SD.Error] = "Kod ini telah wujud..!";
            }

            return View(elaunPotongan);
        }

        [Authorize(Policy = modul + "E")]
        // GET: KW/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var elaunPotongan = _unitOfWork.JElaunPotongan.GetById((int)id);
            if (elaunPotongan == null)
            {
                return NotFound();
            }
            return View(elaunPotongan);
        }

        // POST: KW/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = modul + "E")]
        public async Task<IActionResult> Edit(int id, JElaunPotongan elaunPotongan, string syscode)
        {
            if (id != elaunPotongan.Id)
            {
                return NotFound();
            }

            if (elaunPotongan.Kod != null && ModelState.IsValid)
            {
                try
                {
                    var user = await _userManager.GetUserAsync(User);
                    int? pekerjaId = _context.ApplicationUsers.Where(b => b.Id == user!.Id).FirstOrDefault()!.DPekerjaId;

                    var objAsal = await _context.JElaunPotongan.FirstOrDefaultAsync(x => x.Id == elaunPotongan.Id);
                    var kodAsal = objAsal?.Kod;
                    elaunPotongan.UserId = objAsal?.UserId ?? "";
                    elaunPotongan.TarMasuk = objAsal?.TarMasuk ?? new DateTime();
                    elaunPotongan.DPekerjaMasukId = objAsal?.DPekerjaMasukId;

                    _unitOfWork.JElaunPotongan.Detach(objAsal!);

                    elaunPotongan.UserIdKemaskini = user?.UserName ?? "";

                    elaunPotongan.TarKemaskini = DateTime.Now;
                    elaunPotongan.DPekerjaKemaskiniId = pekerjaId;

                    _unitOfWork.JElaunPotongan.Update(elaunPotongan);

                    _appLog.Insert("Ubah", kodAsal + " -> " + elaunPotongan.Kod + ", ", elaunPotongan.Kod ?? "", id, 0, pekerjaId, modul, syscode, namamodul, user);

                    await _context.SaveChangesAsync();
                    TempData[SD.Success] = "Data berjaya diubah..!";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ElaunPotonganExists(elaunPotongan.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(elaunPotongan);
        }

        // GET: KW/Delete/5
        [Authorize(Policy = modul + "D")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var elaunPotongan = _unitOfWork.JElaunPotongan.GetById((int)id);
            if (elaunPotongan == null)
            {
                return NotFound();
            }

            return View(elaunPotongan);
        }

        // POST: KW/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = modul + "D")]
        public async Task<IActionResult> DeleteConfirmed(int id, string syscode)
        {
            var elaunPotongan = _unitOfWork.JElaunPotongan.GetById((int)id);

            var user = await _userManager.GetUserAsync(User);
            int? pekerjaId = _context.ApplicationUsers.Where(b => b.Id == user!.Id).FirstOrDefault()!.DPekerjaId;

            if (elaunPotongan != null && elaunPotongan.Kod != null)
            {
                elaunPotongan.UserIdKemaskini = user?.UserName ?? "";
                elaunPotongan.TarKemaskini = DateTime.Now;
                elaunPotongan.DPekerjaKemaskiniId = pekerjaId;

                _context.JElaunPotongan.Remove(elaunPotongan);
                _appLog.Insert("Hapus", elaunPotongan.Kod ?? "", elaunPotongan.Kod ?? "", id, 0, pekerjaId, modul, syscode, namamodul, user);
                await _context.SaveChangesAsync();
                TempData[SD.Success] = "Data berjaya dihapuskan..!";
            }

            return RedirectToAction(nameof(Index));
        }

        [Authorize(Policy = modul + "R")]
        public async Task<IActionResult> RollBack(int id, string syscode)
        {
            var user = await _userManager.GetUserAsync(User);
            int? pekerjaId = _context.ApplicationUsers.Where(b => b.Id == user!.Id).FirstOrDefault()!.DPekerjaId;

            var obj = await _context.JElaunPotongan.IgnoreQueryFilters()
                .FirstOrDefaultAsync(x => x.Id == id);

            // Batal operation

            if (obj != null)
            {
                obj.FlHapus = 0;
                obj.UserIdKemaskini = user?.UserName ?? "";
                obj.TarKemaskini = DateTime.Now;
                obj.DPekerjaKemaskiniId = pekerjaId;

                _context.JElaunPotongan.Update(obj);

                // Batal operation end
                _appLog.Insert("Rollback", obj.Kod ?? "", obj.Kod ?? "", id, 0, pekerjaId, modul, syscode, namamodul, user);

                await _context.SaveChangesAsync();
                TempData[SD.Success] = "Data berjaya dikembalikan..!";
            }

            return RedirectToAction(nameof(Index));
        }
        private bool ElaunPotonganExists(int id)
        {
            return _unitOfWork.JElaunPotongan.IsExist(b => b.Id == id);
        }

        private bool KodElaunPotonganExists(string kod)
        {
            return _unitOfWork.JElaunPotongan.IsExist(e => e.Kod == kod);
        }
    }
}
