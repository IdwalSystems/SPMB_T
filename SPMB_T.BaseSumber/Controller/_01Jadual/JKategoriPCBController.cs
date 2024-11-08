﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SPMB_T.__Domain.Entities._Statics;
using SPMB_T.__Domain.Entities.Administrations;
using SPMB_T._DataAccess.Data;
using SPMB_T._DataAccess.Repositories.Interfaces;
using SPMB_T.__Domain.Entities.Models._01Jadual;
using Microsoft.EntityFrameworkCore;

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
            return View(_unitOfWork.JKategoriPCB.GetAll());
        }

        // GET: KW/Details/5
        [Authorize(Policy = modul)]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kategoriPCB = _unitOfWork.JKategoriPCB.GetById((int)id);
            if (kategoriPCB == null)
            {
                return NotFound();
            }

            return View(kategoriPCB);
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
        public async Task<IActionResult> Create(JKategoriPCB kategoriPCB, string syscode)
        {
            if (kategoriPCB.Kod != null && KodKategoriPCBExists(kategoriPCB.Kod) == false)
            {
                if (ModelState.IsValid)
                {
                    var user = await _userManager.GetUserAsync(User);
                    int? pekerjaId = _context.ApplicationUsers.Where(b => b.Id == user!.Id).FirstOrDefault()!.DPekerjaId;

                    kategoriPCB.UserId = user?.UserName ?? "";

                    kategoriPCB.TarMasuk = DateTime.Now;
                    kategoriPCB.DPekerjaMasukId = pekerjaId;

                    _context.Add(kategoriPCB);
                    _appLog.Insert("Tambah", kategoriPCB.Kod ?? "", kategoriPCB.Kod ?? "", 0, 0, pekerjaId, modul, syscode, namamodul, user);
                    await _context.SaveChangesAsync();
                    TempData[SD.Success] = "Data berjaya ditambah..!";
                    return RedirectToAction(nameof(Index));

                }
            }
            else
            {
                TempData[SD.Error] = "Kod ini telah wujud..!";
            }

            return View(kategoriPCB);
        }

        [Authorize(Policy = modul + "E")]
        // GET: KW/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kategoriPCB = _unitOfWork.JKategoriPCB.GetById((int)id);
            if (kategoriPCB == null)
            {
                return NotFound();
            }
            return View(kategoriPCB);
        }

        // POST: KW/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = modul + "E")]
        public async Task<IActionResult> Edit(int id, JKategoriPCB kategoriPCB, string syscode)
        {
            if (id != kategoriPCB.Id)
            {
                return NotFound();
            }

            if (kategoriPCB.Kod != null && ModelState.IsValid)
            {
                try
                {
                    var user = await _userManager.GetUserAsync(User);
                    int? pekerjaId = _context.ApplicationUsers.Where(b => b.Id == user!.Id).FirstOrDefault()!.DPekerjaId;

                    var objAsal = await _context.JKategoriPCB.FirstOrDefaultAsync(x => x.Id == kategoriPCB.Id);
                    var kodAsal = objAsal?.Kod;
                    kategoriPCB.UserId = objAsal?.UserId ?? "";
                    kategoriPCB.TarMasuk = objAsal?.TarMasuk ?? new DateTime();
                    kategoriPCB.DPekerjaMasukId = objAsal?.DPekerjaMasukId;

                    _unitOfWork.JKategoriPCB.Detach(objAsal!);

                    kategoriPCB.UserIdKemaskini = user?.UserName ?? "";

                    kategoriPCB.TarKemaskini = DateTime.Now;
                    kategoriPCB.DPekerjaKemaskiniId = pekerjaId;

                    _unitOfWork.JKategoriPCB.Update(kategoriPCB);

                    _appLog.Insert("Ubah", kodAsal + " -> " + kategoriPCB.Kod + ", ", kategoriPCB.Kod ?? "", id, 0, pekerjaId, modul, syscode, namamodul, user);

                    await _context.SaveChangesAsync();
                    TempData[SD.Success] = "Data berjaya diubah..!";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KategoriPCBExists(kategoriPCB.Id))
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
            return View(kategoriPCB);
        }

        // GET: KW/Delete/5
        [Authorize(Policy = modul + "D")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kategoriPCB = _unitOfWork.JKategoriPCB.GetById((int)id);
            if (kategoriPCB == null)
            {
                return NotFound();
            }

            return View(kategoriPCB);
        }

        // POST: KW/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = modul + "D")]
        public async Task<IActionResult> DeleteConfirmed(int id, string syscode)
        {
            var kategoriPCB = _unitOfWork.JKategoriPCB.GetById((int)id);

            var user = await _userManager.GetUserAsync(User);
            int? pekerjaId = _context.ApplicationUsers.Where(b => b.Id == user!.Id).FirstOrDefault()!.DPekerjaId;

            if (kategoriPCB != null && kategoriPCB.Kod != null)
            {
                kategoriPCB.UserIdKemaskini = user?.UserName ?? "";
                kategoriPCB.TarKemaskini = DateTime.Now;
                kategoriPCB.DPekerjaKemaskiniId = pekerjaId;

                _context.JKategoriPCB.Remove(kategoriPCB);
                _appLog.Insert("Hapus", kategoriPCB.Kod ?? "", kategoriPCB.Kod ?? "", id, 0, pekerjaId, modul, syscode, namamodul, user);
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

            var obj = await _context.JKategoriPCB.IgnoreQueryFilters()
                .FirstOrDefaultAsync(x => x.Id == id);

            // Batal operation

            if (obj != null)
            {
                obj.FlHapus = 0;
                obj.UserIdKemaskini = user?.UserName ?? "";
                obj.TarKemaskini = DateTime.Now;
                obj.DPekerjaKemaskiniId = pekerjaId;

                _context.JKategoriPCB.Update(obj);

                // Batal operation end
                _appLog.Insert("Rollback", obj.Kod ?? "", obj.Kod ?? "", id, 0, pekerjaId, modul, syscode, namamodul, user);

                await _context.SaveChangesAsync();
                TempData[SD.Success] = "Data berjaya dikembalikan..!";
            }

            return RedirectToAction(nameof(Index));
        }
        private bool KategoriPCBExists(int id)
        {
            return _unitOfWork.JKategoriPCB.IsExist(b => b.Id == id);
        }

        private bool KodKategoriPCBExists(string kod)
        {
            return _unitOfWork.JKategoriPCB.IsExist(e => e.Kod == kod);
        }
    }
}
