using SPMB_T.__Domain.Entities._Enums;
using SPMB_T.__Domain.Entities._Statics;
using SPMB_T.__Domain.Entities.Administrations;
using SPMB_T.__Domain.Entities.Models._01Jadual;
using SPMB_T._DataAccess.Data;
using SPMB_T._DataAccess.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SPMB_T.BaseSumber.Microservices;

namespace SPMB_T.BaseSumber.Controller._01Jadual
{
    [Authorize(Roles = Init.superAdminSupervisorRole)]
    public class JGredGajiController : Microsoft.AspNetCore.Mvc.Controller
    {
        public const string modul = Modules.kodJGredGaji;
        public const string namamodul = Modules.namaJGredGaji;

        private readonly ApplicationDbContext _context;
        private readonly _IUnitOfWork _unitOfWork;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly _AppLogIRepository<AppLog, int> _appLog;

        public JGredGajiController(ApplicationDbContext context,
            _IUnitOfWork unitOfWork,
            UserManager<IdentityUser> userManager,
            _AppLogIRepository<AppLog, int> appLog)
        {
            _context = context;
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _appLog = appLog;
        }

        // Papar
        [Authorize(Policy = modul)]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // SELECT * FROM [JGREDGAJI] WHERE ID = [id] 
            var gredGaji = _unitOfWork.JGredGaji.GetById((int)id);
            if (gredGaji == null)
            {
                return NotFound();
            }

            return View(gredGaji);
        }

        // fungsi main
        public IActionResult Index()
        {
            return View(_unitOfWork.JGredGaji.GetAll());
        }

        // fungsi tambah
        [Authorize(Policy = modul + "C")]
        public IActionResult Create()
        {
            var klasifikasiPerkhidmatan = EnumHelper<EnKlasifikasiPerkhidmatan>.GetList();
            ViewBag.EnKlasifikasiPerkhidmatan = klasifikasiPerkhidmatan;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = modul + "C")]
        public async Task<IActionResult> Create(JGredGaji gredGaji, string syscode)
        {
            if (gredGaji.Kod != null && KodGredGajiExists(gredGaji.Kod) == false)
            {
                if (ModelState.IsValid)
                {
                    var user = await _userManager.GetUserAsync(User);
                    int? pekerjaId = _context.ApplicationUsers.Where(b => b.Id == user!.Id).FirstOrDefault()!.DPekerjaId;

                    gredGaji.UserId = user?.UserName ?? "";

                    gredGaji.TarMasuk = DateTime.Now;
                    gredGaji.DPekerjaMasukId = pekerjaId;

                    _context.Add(gredGaji);
                    _appLog.Insert("Tambah", gredGaji.Kod ?? "", gredGaji.Kod ?? "", 0, 0, pekerjaId, modul, syscode, namamodul, user);
                    await _context.SaveChangesAsync();
                    TempData[SD.Success] = "Data berjaya ditambah..!";
                    return RedirectToAction(nameof(Index));

                }
            }
            else
            {
                TempData[SD.Error] = "Kod ini telah wujud..!";
            }
            var klasifikasiPerkhidmatan = EnumHelper<EnKlasifikasiPerkhidmatan>.GetList();
            ViewBag.EnKlasifikasiPerkhidmatan = klasifikasiPerkhidmatan;

            return View(gredGaji);
        }

        [Authorize(Policy = modul + "E")]
        // fungsi ubah
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gredGaji = _unitOfWork.JGredGaji.GetById((int)id);
            if (gredGaji == null)
            {
                return NotFound();
            }
            var klasifikasiPerkhidmatan = EnumHelper<EnKlasifikasiPerkhidmatan>.GetList();
            ViewBag.EnKlasifikasiPerkhidmatan = klasifikasiPerkhidmatan;

            return View(gredGaji);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = modul + "E")]
        // fungsi submit ubah
        public async Task<IActionResult> Edit(int id, JGredGaji gredGaji, string syscode)
        {
            if (id != gredGaji.Id)
            {
                return NotFound();
            }

            if (gredGaji.Kod != null && ModelState.IsValid)
            {
                try
                {
                    var user = await _userManager.GetUserAsync(User);
                    int? pekerjaId = _context.ApplicationUsers.Where(b => b.Id == user!.Id).FirstOrDefault()!.DPekerjaId;

                    var objAsal = await _context.JGredGaji.FirstOrDefaultAsync(x => x.Id == gredGaji.Id);
                    var kodAsal = objAsal?.Kod;
                    gredGaji.UserId = objAsal?.UserId ?? "";
                    gredGaji.TarMasuk = objAsal?.TarMasuk ?? new DateTime();
                    gredGaji.DPekerjaMasukId = objAsal?.DPekerjaMasukId;

                    _unitOfWork.JGredGaji.Detach(objAsal!);

                    gredGaji.UserIdKemaskini = user?.UserName ?? "";

                    gredGaji.TarKemaskini = DateTime.Now;
                    gredGaji.DPekerjaKemaskiniId = pekerjaId;

                    _unitOfWork.JGredGaji.Update(gredGaji);

                    _appLog.Insert("Ubah", kodAsal + " -> " + gredGaji.Kod + ", ", gredGaji.Kod ?? "", id, 0, pekerjaId, modul, syscode, namamodul, user);

                    await _context.SaveChangesAsync();
                    TempData[SD.Success] = "Data berjaya diubah..!";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GredGajiExists(gredGaji.Id))
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
            var klasifikasiPerkhidmatan = EnumHelper<EnKlasifikasiPerkhidmatan>.GetList();
            ViewBag.EnKlasifikasiPerkhidmatan = klasifikasiPerkhidmatan;

            return View(gredGaji);
        }

        [Authorize(Policy = modul + "D")]
        // fungsi hapus
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bangsa = _unitOfWork.JGredGaji.GetById((int)id);
            if (bangsa == null)
            {
                return NotFound();
            }

            return View(bangsa);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = modul + "D")]
        // fungsi submit hapus
        public async Task<IActionResult> DeleteConfirmed(int id, string syscode)
        {
            var gredGaji = _unitOfWork.JGredGaji.GetById((int)id);

            var user = await _userManager.GetUserAsync(User);
            int? pekerjaId = _context.ApplicationUsers.Where(b => b.Id == user!.Id).FirstOrDefault()!.DPekerjaId;

            if (gredGaji != null && gredGaji.Kod != null)
            {
                gredGaji.UserIdKemaskini = user?.UserName ?? "";
                gredGaji.TarKemaskini = DateTime.Now;
                gredGaji.DPekerjaKemaskiniId = pekerjaId;

                _context.JGredGaji.Remove(gredGaji);
                _appLog.Insert("Hapus", gredGaji.Kod ?? "", gredGaji.Kod ?? "", id, 0, pekerjaId, modul, syscode, namamodul, user);
                await _context.SaveChangesAsync();
                TempData[SD.Success] = "Data berjaya dihapuskan..!";
            }

            return RedirectToAction(nameof(Index));
        }

        [Authorize(Policy = modul + "R")]
        //fungsi rollback
        public async Task<IActionResult> RollBack(int id, string syscode)
        {
            var user = await _userManager.GetUserAsync(User);
            int? pekerjaId = _context.ApplicationUsers.Where(b => b.Id == user!.Id).FirstOrDefault()!.DPekerjaId;

            var obj = await _context.JGredGaji.IgnoreQueryFilters()
                .FirstOrDefaultAsync(x => x.Id == id);

            // Batal operation

            if (obj != null)
            {
                obj.FlHapus = 0;
                obj.UserIdKemaskini = user?.UserName ?? "";
                obj.TarKemaskini = DateTime.Now;
                obj.DPekerjaKemaskiniId = pekerjaId;

                _context.JGredGaji.Update(obj);

                // Batal operation end
                _appLog.Insert("Rollback", obj.Kod ?? "", obj.Kod ?? "", id, 0, pekerjaId, modul, syscode, namamodul, user);

                await _context.SaveChangesAsync();
                TempData[SD.Success] = "Data berjaya dikembalikan..!";
            }

            return RedirectToAction(nameof(Index));
        }

        private bool GredGajiExists(int id)
        {
            return _unitOfWork.JGredGaji.IsExist(b => b.Id == id);
        }

        private bool KodGredGajiExists(string kod)
        {
            // SELECT COUNT(Kod) FROM JGREDGAJI WHERE KOD = kod
            // HAVING COUNT(KOD) > 0
            return _unitOfWork.JGredGaji.IsExist(e => e.Kod == kod);
        }
    }
}
