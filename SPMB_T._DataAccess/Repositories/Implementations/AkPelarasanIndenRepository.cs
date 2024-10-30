﻿using Microsoft.EntityFrameworkCore;
using SPMB_T.__Domain.Entities._Enums;
using SPMB_T.__Domain.Entities.Models._01Jadual;
using SPMB_T.__Domain.Entities.Models._02Daftar;
using SPMB_T.__Domain.Entities.Models._03Akaun;
using SPMB_T._DataAccess.Data;
using SPMB_T._DataAccess.Repositories.Interfaces;

namespace SPMB_T._DataAccess.Repositories.Implementations
{
    public class AkPelarasanIndenRepository : _GenericRepository<AkPelarasanInden>, IAkPelarasanIndenRepository
    {
        private readonly ApplicationDbContext _context;

        public AkPelarasanIndenRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public AkPelarasanInden GetDetailsById(int id)
        {
            return _context.AkPelarasanInden
                .IgnoreQueryFilters()
                .Include(t => t.LHDNMSIC)
                .Include(t => t.JKW)
                .Include(t => t.AkInden)
                    .ThenInclude(t => t!.DDaftarAwam)
                .Include(t => t.DPekerjaPosting)
                .Include(t => t.DPengesah)
                    .ThenInclude(t => t!.DPekerja)
                .Include(t => t.DPenyemak)
                    .ThenInclude(t => t!.DPekerja)
                .Include(t => t.DPelulus)
                    .ThenInclude(t => t!.DPekerja)
                .Include(t => t.AkPelarasanIndenObjek)!
                    .ThenInclude(to => to.AkCarta)
                .Include(t => t.AkPelarasanIndenObjek)!
                    .ThenInclude(to => to.JKWPTJBahagian)
                        .ThenInclude(b => b!.JKW)
                .Include(t => t.AkPelarasanIndenObjek)!
                    .ThenInclude(to => to.JKWPTJBahagian)
                        .ThenInclude(b => b!.JPTJ)
                .Include(t => t.AkPelarasanIndenObjek)!
                    .ThenInclude(to => to.JKWPTJBahagian)
                        .ThenInclude(b => b!.JBahagian)
                .Include(t => t.AkPelarasanIndenPerihal)
                .FirstOrDefault(pp => pp.Id == id) ?? new AkPelarasanInden();
        }

        public List<AkPelarasanInden> GetResults(string? searchString, DateTime? dateFrom, DateTime? dateTo, string? orderBy, EnStatusBorang enStatusBorang)
        {
            if (searchString == null && dateFrom == null && dateTo == null && orderBy == null)
            {
                return new List<AkPelarasanInden>();
            }

            var akPelarasanIndenList = _context.AkPelarasanInden
                .IgnoreQueryFilters()
                .Include(t => t.LHDNMSIC)
                .Include(t => t.JKW)
                .Include(t => t.AkInden)
                    .ThenInclude(t => t!.DDaftarAwam)
                .Include(t => t.DPekerjaPosting)
                .Include(t => t.DPengesah)
                    .ThenInclude(t => t!.DPekerja)
                .Include(t => t.DPenyemak)
                    .ThenInclude(t => t!.DPekerja)
                .Include(t => t.DPelulus)
                    .ThenInclude(t => t!.DPekerja)
                .Include(t => t.AkPelarasanIndenObjek)!
                    .ThenInclude(to => to.AkCarta)
                .Include(t => t.AkPelarasanIndenObjek)!
                    .ThenInclude(to => to.JKWPTJBahagian)
                        .ThenInclude(b => b!.JKW)
                .Include(t => t.AkPelarasanIndenObjek)!
                    .ThenInclude(to => to.JKWPTJBahagian)
                        .ThenInclude(b => b!.JPTJ)
                .Include(t => t.AkPelarasanIndenObjek)!
                    .ThenInclude(to => to.JKWPTJBahagian)
                        .ThenInclude(b => b!.JBahagian)
                        .Where(t => t.Tarikh >= dateFrom && t.Tarikh <= dateTo!.Value.AddHours(23.99))
                .ToList();

            // searchstring filters
            if (searchString != null)
            {
                akPelarasanIndenList = akPelarasanIndenList.Where(t =>
                t.NoRujukan!.Contains(searchString, StringComparison.OrdinalIgnoreCase)
                || t.AkInden!.DDaftarAwam!.Nama!.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }
            // searchString filters end

            // status borang filters
            switch (enStatusBorang)
            {
                case EnStatusBorang.None:
                    akPelarasanIndenList = akPelarasanIndenList.Where(pp => pp.EnStatusBorang == EnStatusBorang.None).ToList();
                    break;
                case EnStatusBorang.Sah:
                    akPelarasanIndenList = akPelarasanIndenList.Where(pp => pp.EnStatusBorang == EnStatusBorang.Sah).ToList();
                    break;
                case EnStatusBorang.Semak:
                    akPelarasanIndenList = akPelarasanIndenList.Where(pp => pp.EnStatusBorang == EnStatusBorang.Semak).ToList();
                    break;
                case EnStatusBorang.Lulus:
                    akPelarasanIndenList = akPelarasanIndenList.Where(pp => pp.EnStatusBorang == EnStatusBorang.Lulus).ToList();
                    break;
                case EnStatusBorang.Semua:
                    break;
            }
            // status borang filters end

            // order by filters
            if (orderBy != null)
            {
                switch (orderBy)
                {
                    case "Nama":
                        akPelarasanIndenList = akPelarasanIndenList.OrderBy(t => t.AkInden!.DDaftarAwam!.Nama).ToList();
                        break;
                    case "Tarikh":
                        akPelarasanIndenList = akPelarasanIndenList.OrderBy(t => t.Tarikh).ToList(); break;
                    default:
                        akPelarasanIndenList = akPelarasanIndenList.OrderBy(t => t.NoRujukan).ToList();
                        break;
                }

            }
            // order by filters end

            return akPelarasanIndenList;
        }

        public List<AkPelarasanInden> GetResultsByDPekerjaIdFromDKonfigKelulusan(string? searchString, DateTime? dateFrom, DateTime? dateTo, string? orderBy, EnStatusBorang enStatusBorang, int dPekerjaId, EnKategoriKelulusan enKategoriKelulusan, EnJenisModulKelulusan enJenisModulKelulusan)
        {

            // get all data with details
            List<AkPelarasanInden> akPelarasanIndenList = GetResults(searchString, dateFrom, dateTo, orderBy, enStatusBorang);

            var filterings = FilterByComparingJBahagianAkPenilaianObjekWithJBahagianDKonfigKelulusan(dPekerjaId, enKategoriKelulusan, enJenisModulKelulusan, akPelarasanIndenList);

            var results = FilterByComparingJumlahAkPelarasanIndenWithMinAmountMaxAmountDKonfigKelulusan(dPekerjaId, enKategoriKelulusan, enJenisModulKelulusan, filterings);

            return results;
        }

        public List<AkPelarasanInden> FilterByComparingJBahagianAkPenilaianObjekWithJBahagianDKonfigKelulusan(int dPekerjaId, EnKategoriKelulusan enKategoriKelulusan, EnJenisModulKelulusan enJenisModulKelulusan, List<AkPelarasanInden> akPelarasanIndenList)
        {
            // initialize result sets
            List<AkPelarasanInden> results = new List<AkPelarasanInden>();

            //get all pengesah/penyemak/pelulus with same dpekerjaId, group by pekerjaId and bahagianId

            var konfigKelulusanBahagianGrouped = _context.DKonfigKelulusan
                 .Include(kk => kk.DPekerja)
                 .Include(kk => kk.JBahagian)
                .Where(b => b.EnKategoriKelulusan == enKategoriKelulusan
                && b.DPekerjaId == dPekerjaId
                && b.EnJenisModulKelulusan == enJenisModulKelulusan)
                .GroupBy(b => new { b.DPekerjaId, b.JBahagianId }).Select(l => new DKonfigKelulusan
                {
                    Id = l.First().DPekerjaId,
                    DPekerjaId = l.First().DPekerjaId,
                    DPekerja = l.First().DPekerja,
                    JBahagianId = l.First().JBahagianId,
                    JBahagian = l.First().JBahagian
                }).ToList();

            var konfigKelulusanBahagianList = new List<JBahagian>();


            if (konfigKelulusanBahagianGrouped != null && konfigKelulusanBahagianGrouped.Count > 0)
            {

                foreach (var item in konfigKelulusanBahagianGrouped)
                {
                    if (item.JBahagian != null) konfigKelulusanBahagianList.Add(item.JBahagian);
                }

                var akPelarasanIndenGroup = new List<AkPelarasanIndenObjek>().GroupBy(objek => objek.JKWPTJBahagianId);
                if (akPelarasanIndenList != null && akPelarasanIndenList.Count > 0)
                {
                    foreach (var akPelarasanInden in akPelarasanIndenList)
                    {
                        var penilaianPerolehanObjekBahagianList = new List<JBahagian>();

                        // group akPelarasanIndenObjek by bahagian
                        if (akPelarasanInden.AkPelarasanIndenObjek != null && akPelarasanInden.AkPelarasanIndenObjek.Count > 0)
                        {
                            foreach (var item in akPelarasanInden.AkPelarasanIndenObjek)
                            {
                                penilaianPerolehanObjekBahagianList.Add(item.JKWPTJBahagian?.JBahagian ?? new JBahagian());
                            }

                        }
                        // if konfigKelulusan bahagian null, bypass all, add to results
                        if (konfigKelulusanBahagianList.Count == 0)
                        {
                            results.Add(akPelarasanInden);
                            continue;
                        }

                        // compare each lists, if its equal then insert to results
                        var items = penilaianPerolehanObjekBahagianList.All(konfigKelulusanBahagianList.Contains);
                        if (konfigKelulusanBahagianList.OrderBy(kk => kk.Kod).SequenceEqual(penilaianPerolehanObjekBahagianList.OrderBy(pp => pp.Kod))
                            || penilaianPerolehanObjekBahagianList.All(konfigKelulusanBahagianList.Contains))
                        {

                            results.Add(akPelarasanInden);
                            continue;
                        };
                    }
                }
            }


            return results;
        }


        public List<AkPelarasanInden> FilterByComparingJumlahAkPelarasanIndenWithMinAmountMaxAmountDKonfigKelulusan(int dPekerjaId, EnKategoriKelulusan enKategoriKelulusan, EnJenisModulKelulusan enJenisModulKelulusan, List<AkPelarasanInden> filterings)
        {
            //initialize new list akPelarasanInden
            List<AkPelarasanInden> results = new List<AkPelarasanInden>();

            // get list of dKonfigKelulusan with same DPekerjaId, enKategoriKelulusan, enJenisModulKelulusan
            var konfigKelulusanList = _context.DKonfigKelulusan.Include(kk => kk.DPekerja)
                 .Include(kk => kk.JBahagian)
                .Where(b => b.EnKategoriKelulusan == enKategoriKelulusan
                && b.DPekerjaId == dPekerjaId
                && b.EnJenisModulKelulusan == enJenisModulKelulusan).ToList();

            if (filterings != null && filterings.Count > 0)
            {
                foreach (var filtering in filterings)
                {
                    if (konfigKelulusanList != null && konfigKelulusanList.Count > 0)
                    {
                        foreach (var konfigKelulusan in konfigKelulusanList)
                        {
                            if (konfigKelulusan.MinAmaun <= filtering.Jumlah && filtering.Jumlah <= konfigKelulusan.MaksAmaun)
                            {
                                results.Add(filtering);
                            }
                        }
                    }
                }
            }

            return results.GroupBy(b => b.Id).Select(grp => grp.First()).ToList();
        }
        public async Task<bool> IsSahAsync(int id)
        {
            bool isSah = await _context.AkPelarasanInden.AnyAsync(t => t.Id == id && (t.EnStatusBorang == EnStatusBorang.Sah || t.EnStatusBorang == EnStatusBorang.Semak || t.EnStatusBorang == EnStatusBorang.Lulus));
            if (isSah)
            {
                return true;
            }

            return false;
        }

        public async Task<bool> IsSemakAsync(int id)
        {
            bool isSemak = await _context.AkPelarasanInden.AnyAsync(t => t.Id == id && (t.EnStatusBorang == EnStatusBorang.Semak || t.EnStatusBorang == EnStatusBorang.Lulus));
            if (isSemak)
            {
                return true;
            }

            return false;
        }


        public async Task<bool> IsLulusAsync(int id)
        {
            bool isLulus = await _context.AkPelarasanInden.AnyAsync(t => t.Id == id && t.EnStatusBorang == EnStatusBorang.Lulus);
            if (isLulus)
            {
                return true;
            }

            return false;
        }

        public async Task<bool> IsPostedAsync(int id, string noRujukan)
        {
            bool isPosted = await _context.AkPelarasanInden.AnyAsync(t => t.Id == id && t.FlPosting == 1);
            if (isPosted)
            {
                return true;
            }

            bool isExistInAbBukuVot = await _context.AbBukuVot.AnyAsync(b => b.NoRujukan == noRujukan);

            if (isExistInAbBukuVot)
            {
                return true;
            }

            return false;

        }

        public void Sah(int id, int? pengesahId, string? userId)
        {
            var data = _context.AkPelarasanInden.FirstOrDefault(pp => pp.Id == id);
            var pengesah = _context.DKonfigKelulusan.FirstOrDefault(kk => kk.DPekerjaId == pengesahId);
            if (data != null)
            {
                data.EnStatusBorang = EnStatusBorang.Sah;
                data.DPengesahId = pengesah!.Id;
                data.TarikhSah = DateTime.Now;

                data.UserIdKemaskini = userId ?? "";
                data.TarKemaskini = DateTime.Now;
                data.Tindakan = "";

                _context.Update(data);

            }
        }

        public void Semak(int id, int penyemakId, string? userId)
        {
            var data = _context.AkPelarasanInden.FirstOrDefault(pp => pp.Id == id);
            var penyemak = _context.DKonfigKelulusan.FirstOrDefault(kk => kk.DPekerjaId == penyemakId);
            if (data != null)
            {
                data.EnStatusBorang = EnStatusBorang.Semak;
                data.DPenyemakId = penyemak!.Id;
                data.TarikhSemak = DateTime.Now;

                data.UserIdKemaskini = userId ?? "";
                data.TarKemaskini = DateTime.Now;
                data.Tindakan = "";

                _context.Update(data);

            }
        }

        public void Lulus(int id, int? pelulusId, string? userId)
        {
            var data = GetDetailsById(id);
            var pelulus = _context.DKonfigKelulusan.FirstOrDefault(kk => kk.DPekerjaId == pelulusId);
            if (data != null)
            {
                if (data.EnStatusBorang != EnStatusBorang.Kemaskini)
                {
                    data.DPelulusId = pelulus!.Id;
                    data.TarikhLulus = DateTime.Now;
                }

                data.EnStatusBorang = EnStatusBorang.Lulus;
                data.FlPosting = 1;
                data.DPekerjaPostingId = pelulusId;
                data.TarikhPosting = DateTime.Now;

                data.UserIdKemaskini = userId ?? "";
                data.TarKemaskini = DateTime.Now;
                data.Tindakan = "";

                _context.Update(data);

                PostingToAbBukuVot(data);

            }
        }

        public void HantarSemula(int id, string? tindakan, string? userId)
        {
            var data = _context.AkPelarasanInden.FirstOrDefault(pp => pp.Id == id);

            if (data != null)
            {
                data.EnStatusBorang = EnStatusBorang.None;
                data.DPengesahId = null;
                data.TarikhSah = null;

                data.DPenyemakId = null;
                data.TarikhSemak = null;

                data.DPelulusId = null;
                data.TarikhLulus = null;

                data.DPekerjaPostingId = null;
                data.TarikhPosting = null;

                data.Tindakan = tindakan;
                data.UserIdKemaskini = userId ?? "";
                data.TarKemaskini = DateTime.Now;

                data.FlPosting = 0;
                data.TarikhPosting = null;

                _context.Update(data);

            }
        }

        public async Task<bool> IsBatalAsync(int id)
        {
            bool isBatal = await _context.AkPelarasanInden.AnyAsync(t => t.Id == id && t.FlBatal == 1);
            if (isBatal)
            {
                return true;
            }

            return false;
        }

        public void Batal(int id, string? sebabBatal, string? userId)
        {

            var data = _context.AkPelarasanInden.FirstOrDefault(pp => pp.Id == id);

            if (data != null)
            {
                data.EnStatusBorang = EnStatusBorang.Batal;
                data.FlBatal = 1;
                data.TarBatal = DateTime.Now;
                data.SebabBatal = sebabBatal;

                data.UserIdKemaskini = userId ?? "";
                data.TarKemaskini = DateTime.Now;

                _context.Update(data);
            }
        }

        public string GetMaxRefNo(string initNoRujukan, string tahun)
        {
            var max = _context.AkPelarasanInden.Where(pp => pp.Tahun == tahun).OrderByDescending(pp => pp.NoRujukan).ToList();

            if (max != null)
            {
                var refNo = max.FirstOrDefault()?.NoRujukan?.Substring(8, 5);
                return refNo ?? "";
            }
            else
            {
                return "";
            }
        }

        public void PostingToAbBukuVot(AkPelarasanInden akPelarasanInden)
        {
            List<AbBukuVot> abBukuVotList = new List<AbBukuVot>();

            if (akPelarasanInden.AkPelarasanIndenObjek != null && akPelarasanInden.AkPelarasanIndenObjek.Count > 0)
            {


                foreach (var item in akPelarasanInden.AkPelarasanIndenObjek)
                {
                    AbBukuVot abBukuVot = new AbBukuVot()
                    {
                        Tahun = akPelarasanInden.Tahun,
                        JKWId = item.JKWPTJBahagian?.JKWId ?? akPelarasanInden.JKWId,
                        JPTJId = (int)item.JKWPTJBahagian!.JPTJId,
                        JBahagianId = item.JKWPTJBahagian.JBahagianId,
                        Tarikh = akPelarasanInden.Tarikh,
                        DDaftarAwamId = akPelarasanInden.AkInden!.DDaftarAwamId,
                        VotId = item.AkCartaId,
                        NoRujukan = akPelarasanInden.NoRujukan,
                        Tanggungan = item.Amaun
                    };

                    abBukuVotList.Add(abBukuVot);
                }
            }

            _context.AbBukuVot.AddRange(abBukuVotList);
        }

        public void RemovePostingFromAbBukuVot(AkPelarasanInden akPelarasanInden, string userId)
        {
            var abBukuVotList = _context.AbBukuVot.Where(b => b.NoRujukan == akPelarasanInden.NoRujukan).ToList();

            if (abBukuVotList != null && abBukuVotList.Count > 0)
            {
                _context.RemoveRange(abBukuVotList);
            }

        }

        public void BatalLulus(int id, string? tindakan, string? userId)
        {
            var data = _context.AkPelarasanInden.FirstOrDefault(pp => pp.Id == id);

            if (data != null)
            {
                HantarSemula(id, tindakan, userId);

                RemovePostingFromAbBukuVot(data, userId ?? "");

            }
        }

        public void BatalPos(int id, string? tindakan, string? userId)
        {
            var data = _context.AkPelarasanInden.FirstOrDefault(pp => pp.Id == id);

            if (data != null)
            {
                data.EnStatusBorang = EnStatusBorang.Kemaskini;
                data.Tindakan = tindakan;

                data.UserIdKemaskini = userId ?? "";
                data.TarKemaskini = DateTime.Now;

                data.FlPosting = 0;
                data.TarikhPosting = null;

                _context.Update(data);

                RemovePostingFromAbBukuVot(data, userId ?? "");

            }
        }
    }
}