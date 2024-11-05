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
    public class JGredTanggaGajiController : Microsoft.AspNetCore.Mvc.Controller
    {
        public const string modul = Modules.kodJGredTanggaGaji;
        public const string namamodul = Modules.namaJGredTanggaGaji;

        private readonly ApplicationDbContext _context;
        private readonly _IUnitOfWork _unitOfWork;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly _AppLogIRepository<AppLog, int> _appLog;

        public JGredTanggaGajiController(ApplicationDbContext context,
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
            // SELECT * FROM JGREDTANGGAGAJI A
            // LEFT JOIN JGREDGAJI B ON B.ID = A.JGREDGAJIID
            // LEFT JOIN JTANGGAGAJI C ON C.ID = A.JTANGGAGAJIID
            return View(_unitOfWork.JGredTanggaGaji.GetAllDetails());
        }

        // GET: KW/Details/5
        [Authorize(Policy = modul)]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            // SELECT * FROM JGREDTANGGAGAJI A
            // LEFT JOIN JGREDGAJI B ON B.ID = A.JGREDGAJIID
            // LEFT JOIN JTANGGAGAJI C ON C.ID = A.JTANGGAGAJIID WHERE ID = id
            var gredTanggaGaji = _unitOfWork.JGredTanggaGaji.GetDetailsById((int)id);
            if (gredTanggaGaji == null)
            {
                return NotFound();
            }

            return View(gredTanggaGaji);
        }

        // GET: KW/Create
        [Authorize(Policy = modul + "C")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = modul + "C")]
        public async Task<IActionResult> Create(JGredTanggaGaji gredTanggaGaji, string syscode)
        {
            if (gredTanggaGaji != null 
                && gredTanggaGaji.JGredGajiId != 0 
                && gredTanggaGaji.JTanggaGajiId != 0 
                && GredTanggaGajiExists(gredTanggaGaji.JGredGajiId, gredTanggaGaji.JTanggaGajiId) == false)
            {
                if (ModelState.IsValid)
                {
                    var user = await _userManager.GetUserAsync(User);
                    int? pekerjaId = _context.ApplicationUsers.Where(b => b.Id == user!.Id).FirstOrDefault()!.DPekerjaId;

                    gredTanggaGaji.UserId = user?.UserName ?? "";

                    gredTanggaGaji.TarMasuk = DateTime.Now;
                    gredTanggaGaji.DPekerjaMasukId = pekerjaId;

                    _context.Add(gredTanggaGaji);
                    _appLog.Insert("Tambah", 
                        gredTanggaGaji.JGredGajiId.ToString() ?? "" + " / " + gredTanggaGaji.JTanggaGajiId.ToString() ?? "", 
                        gredTanggaGaji.JGredGajiId.ToString() ?? "" + " / " + gredTanggaGaji.JTanggaGajiId.ToString() ?? "", 
                        0, 
                        0, 
                        pekerjaId, 
                        modul,
                        syscode, 
                        namamodul, 
                        user);
                    await _context.SaveChangesAsync();
                    TempData[SD.Success] = "Data berjaya ditambah..!";
                    return RedirectToAction(nameof(Index));

                }
            }
            else
            {
                TempData[SD.Error] = "Perihal ini telah wujud..!";
            }

            return View(gredTanggaGaji);
        }

        [Authorize(Policy = modul + "E")]
        // GET: KW/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gredTanggaGaji = _unitOfWork.JGredTanggaGaji.GetDetailsById((int)id);
            if (gredTanggaGaji == null)
            {
                return NotFound();
            }
            return View(gredTanggaGaji);
        }

        // POST: KW/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = modul + "E")]
        public async Task<IActionResult> Edit(int id, JGredTanggaGaji gredTanggaGaji, string syscode)
        {
            if (id != gredTanggaGaji.Id)
            {
                return NotFound();
            }

            if (gredTanggaGaji != null 
                && gredTanggaGaji.JGredGajiId != 0 
                && gredTanggaGaji.JTanggaGajiId != 0 
                && ModelState.IsValid)
            {
                try
                {
                    var user = await _userManager.GetUserAsync(User);
                    int? pekerjaId = _context.ApplicationUsers.Where(b => b.Id == user!.Id).FirstOrDefault()!.DPekerjaId;

                    var objAsal = await _context.JGredTanggaGaji.FirstOrDefaultAsync(x => x.Id == gredTanggaGaji.Id);
                    var gredGajiIdAsal = objAsal?.JGredGajiId;
                    var tanggaGajiIdAsal = objAsal?.JTanggaGajiId;
                    gredTanggaGaji.UserId = objAsal?.UserId ?? "";
                    gredTanggaGaji.TarMasuk = objAsal?.TarMasuk ?? new DateTime();
                    gredTanggaGaji.DPekerjaMasukId = objAsal?.DPekerjaMasukId;

                    _unitOfWork.JGredTanggaGaji.Detach(objAsal!);

                    gredTanggaGaji.UserIdKemaskini = user?.UserName ?? "";

                    gredTanggaGaji.TarKemaskini = DateTime.Now;
                    gredTanggaGaji.DPekerjaKemaskiniId = pekerjaId;

                    _unitOfWork.JGredTanggaGaji.Update(gredTanggaGaji);

                    _appLog.Insert("Ubah", 
                        gredGajiIdAsal + " -> " + gredTanggaGaji.JGredGajiId + ", " + tanggaGajiIdAsal + " -> " + gredTanggaGaji.JTanggaGajiId, 
                        gredGajiIdAsal + " -> " + gredTanggaGaji.JGredGajiId + ", " + tanggaGajiIdAsal + " -> " + gredTanggaGaji.JTanggaGajiId, 
                        id, 
                        0, 
                        pekerjaId, 
                        modul, 
                        syscode, 
                        namamodul, 
                        user);

                    await _context.SaveChangesAsync();
                    TempData[SD.Success] = "Data berjaya diubah..!";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GredTanggaGajiExists(gredTanggaGaji.Id))
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
            return View(gredTanggaGaji);
        }

        // GET: KW/Delete/5
        [Authorize(Policy = modul + "D")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gredTanggaGaji = _unitOfWork.JGredTanggaGaji.GetDetailsById((int)id);
            if (gredTanggaGaji == null)
            {
                return NotFound();
            }

            return View(gredTanggaGaji);
        }

        // POST: KW/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = modul + "D")]
        public async Task<IActionResult> DeleteConfirmed(int id, string syscode)
        {
            var gredTanggaGaji = _unitOfWork.JGredTanggaGaji.GetById((int)id);

            var user = await _userManager.GetUserAsync(User);
            int? pekerjaId = _context.ApplicationUsers.Where(b => b.Id == user!.Id).FirstOrDefault()!.DPekerjaId;

            if (gredTanggaGaji != null 
                && gredTanggaGaji.JGredGajiId != 0 
                && gredTanggaGaji.JTanggaGajiId != 0)
            {
                gredTanggaGaji.UserIdKemaskini = user?.UserName ?? "";
                gredTanggaGaji.TarKemaskini = DateTime.Now;
                gredTanggaGaji.DPekerjaKemaskiniId = pekerjaId;

                _context.JGredTanggaGaji.Remove(gredTanggaGaji);
                _appLog.Insert("Hapus", 
                    gredTanggaGaji.JGredGajiId.ToString() ?? "" + " / " + gredTanggaGaji.JTanggaGajiId.ToString() ?? "",
                    gredTanggaGaji.JGredGajiId.ToString() ?? "" + " / " + gredTanggaGaji.JTanggaGajiId.ToString() ?? "", 
                    id, 
                    0, 
                    pekerjaId, 
                    modul, 
                    syscode, 
                    namamodul, 
                    user);
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

            var obj = await _context.JGredTanggaGaji.IgnoreQueryFilters()
                .FirstOrDefaultAsync(x => x.Id == id);

            // Batal operation

            if (obj != null)
            {
                obj.FlHapus = 0;
                obj.UserIdKemaskini = user?.UserName ?? "";
                obj.TarKemaskini = DateTime.Now;
                obj.DPekerjaKemaskiniId = pekerjaId;

                _context.JGredTanggaGaji.Update(obj);

                // Batal operation end
                _appLog.Insert("Rollback", 
                    obj.JGredGajiId.ToString() ?? "" + " / " + obj.JTanggaGajiId.ToString() ?? "",
                    obj.JGredGajiId.ToString() ?? "" + " / " + obj.JTanggaGajiId.ToString() ?? "", 
                    id, 
                    0, 
                    pekerjaId,
                    modul, 
                    syscode, 
                    namamodul, 
                    user);

                await _context.SaveChangesAsync();
                TempData[SD.Success] = "Data berjaya dikembalikan..!";
            }

            return RedirectToAction(nameof(Index));
        }
        private bool GredTanggaGajiExists(int id)
        {
            return _unitOfWork.JGredTanggaGaji.IsExist(b => b.Id == id);
        }

        private bool GredTanggaGajiExists(int jGredGajiId, int jTanggaGajiId)
        {
            return _unitOfWork.JGredTanggaGaji.IsExist(e => e.JGredGajiId == jGredGajiId && e.JTanggaGajiId == jTanggaGajiId);
        }
    }
}
