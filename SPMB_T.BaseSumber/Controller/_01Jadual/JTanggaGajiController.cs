using SPMB_T.__Domain.Entities._Statics;
using SPMB_T.__Domain.Entities.Administrations;
using SPMB_T.__Domain.Entities.Models._01Jadual;
using SPMB_T._DataAccess.Data;
using SPMB_T._DataAccess.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SPMB_T.BaseSumber.Controller._01Jadual
{
    [Authorize(Roles = Init.superAdminSupervisorRole)]
    public class JTanggaGajiController : Microsoft.AspNetCore.Mvc.Controller
    {
        public const string modul = Modules.kodJTanggaGaji;
        public const string namamodul = Modules.namaJTanggaGaji;

        private readonly ApplicationDbContext _context;
        private readonly _IUnitOfWork _unitOfWork;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly _AppLogIRepository<AppLog, int> _appLog;

        public JTanggaGajiController(ApplicationDbContext context,
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
            return View(_unitOfWork.JTanggaGaji.GetAll());
        }

        // GET: KW/Details/5
        [Authorize(Policy = modul)]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tanggaGaji = _unitOfWork.JTanggaGaji.GetById((int)id);
            if (tanggaGaji == null)
            {
                return NotFound();
            }

            return View(tanggaGaji);
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
        public async Task<IActionResult> Create(JTanggaGaji tanggaGaji, string syscode)
        {
            if ((tanggaGaji.KodSSPA != null && tanggaGaji.KodSSM != null) && KodSSMKodSSPATanggaGajiExists(tanggaGaji.KodSSPA, tanggaGaji.KodSSM) == false)
            {
                if (ModelState.IsValid)
                {
                    var user = await _userManager.GetUserAsync(User);
                    int? pekerjaId = _context.ApplicationUsers.Where(b => b.Id == user!.Id).FirstOrDefault()!.DPekerjaId;

                    tanggaGaji.UserId = user?.UserName ?? "";

                    tanggaGaji.TarMasuk = DateTime.Now;
                    tanggaGaji.DPekerjaMasukId = pekerjaId;

                    _context.Add(tanggaGaji);
                    _appLog.Insert(
                        "Tambah", 
                        tanggaGaji.KodSSM ?? "" + " / " + tanggaGaji.KodSSPA ?? "", 
                        tanggaGaji.KodSSM ?? "" + " / " + tanggaGaji.KodSSPA ?? "", 
                        0, 
                        0,
                        pekerjaId, 
                        modul, 
                        syscode, 
                        namamodul, 
                        user
                        );
                    await _context.SaveChangesAsync();
                    TempData[SD.Success] = "Data berjaya ditambah..!";
                    return RedirectToAction(nameof(Index));

                }
            }
            else
            {
                TempData[SD.Error] = "Perihal ini telah wujud..!";
            }

            return View(tanggaGaji);
        }

        [Authorize(Policy = modul + "E")]
        // GET: KW/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tanggaGaji = _unitOfWork.JTanggaGaji.GetById((int)id);
            if (tanggaGaji == null)
            {
                return NotFound();
            }
            return View(tanggaGaji);
        }

        // POST: KW/1/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = modul + "E")]
        public async Task<IActionResult> Edit(int id, JTanggaGaji tanggaGaji, string syscode)
        {
            if (id != tanggaGaji.Id)
            {
                return NotFound();
            }

            if ((tanggaGaji.KodSSPA != null && tanggaGaji.KodSSM != null) && ModelState.IsValid)
            {
                try
                {
                    var user = await _userManager.GetUserAsync(User);
                    int? pekerjaId = _context.ApplicationUsers.Where(b => b.Id == user!.Id).FirstOrDefault()!.DPekerjaId;

                    var objAsal = await _context.JTanggaGaji.FirstOrDefaultAsync(x => x.Id == tanggaGaji.Id);
                    var kodSSMAsal = objAsal?.KodSSM;
                    var kodSSPAAsal = objAsal?.KodSSPA;
                    tanggaGaji.UserId = objAsal?.UserId ?? "";
                    tanggaGaji.TarMasuk = objAsal?.TarMasuk ?? new DateTime();
                    tanggaGaji.DPekerjaMasukId = objAsal?.DPekerjaMasukId;

                    _unitOfWork.JTanggaGaji.Detach(objAsal!);

                    tanggaGaji.UserIdKemaskini = user?.UserName ?? "";

                    tanggaGaji.TarKemaskini = DateTime.Now;
                    tanggaGaji.DPekerjaKemaskiniId = pekerjaId;

                    _unitOfWork.JTanggaGaji.Update(tanggaGaji);

                    _appLog.Insert("Ubah", 
                        kodSSMAsal + " -> " + tanggaGaji.KodSSM + " / " + kodSSPAAsal + " -> " + tanggaGaji.KodSSPA + ", ", 
                        tanggaGaji.KodSSM ?? "" + " / " + tanggaGaji.KodSSPA ?? "", 
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
                    if (!TanggaGajiExists(tanggaGaji.Id))
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
            return View(tanggaGaji);
        }

        // GET: KW/Delete/5
        [Authorize(Policy = modul + "D")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tanggaGaji = _unitOfWork.JTanggaGaji.GetById((int)id);
            if (tanggaGaji == null)
            {
                return NotFound();
            }

            return View(tanggaGaji);
        }

        // POST: KW/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = modul + "D")]
        public async Task<IActionResult> DeleteConfirmed(int id, string syscode)
        {
            var tanggaGaji = _unitOfWork.JTanggaGaji.GetById((int)id);

            var user = await _userManager.GetUserAsync(User);
            int? pekerjaId = _context.ApplicationUsers.Where(b => b.Id == user!.Id).FirstOrDefault()!.DPekerjaId;

            if (tanggaGaji != null && tanggaGaji.KodSSM != null && tanggaGaji.KodSSPA != null)
            {
                tanggaGaji.UserIdKemaskini = user?.UserName ?? "";
                tanggaGaji.TarKemaskini = DateTime.Now;
                tanggaGaji.DPekerjaKemaskiniId = pekerjaId;

                _context.JTanggaGaji.Remove(tanggaGaji);
                _appLog.Insert("Hapus", 
                    tanggaGaji.KodSSM ?? "" + " / " + tanggaGaji.KodSSPA ?? "", 
                    tanggaGaji.KodSSM ?? "" + " / " + tanggaGaji.KodSSPA ?? "", 
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

            var obj = await _context.JTanggaGaji.IgnoreQueryFilters()
                .FirstOrDefaultAsync(x => x.Id == id);

            // Batal operation

            if (obj != null)
            {
                obj.FlHapus = 0;
                obj.UserIdKemaskini = user?.UserName ?? "";
                obj.TarKemaskini = DateTime.Now;
                obj.DPekerjaKemaskiniId = pekerjaId;

                _context.JTanggaGaji.Update(obj);

                // Batal operation end
                _appLog.Insert("Rollback", obj.KodSSM ?? "" + " / " + obj.KodSSPA ?? "", obj.KodSSM ?? "" + " / " + obj.KodSSPA ?? "", id, 0, pekerjaId, modul, syscode, namamodul, user);

                await _context.SaveChangesAsync();
                TempData[SD.Success] = "Data berjaya dikembalikan..!";
            }

            return RedirectToAction(nameof(Index));
        }
        private bool TanggaGajiExists(int id)
        {
            return _unitOfWork.JTanggaGaji.IsExist(b => b.Id == id);
        }

        private bool KodSSMKodSSPATanggaGajiExists(string kodSSM, string kodSSPA)
        {
            return _unitOfWork.JTanggaGaji.IsExist(e => e.KodSSM == kodSSM && e.KodSSPA == kodSSPA);
        }
    }
}
