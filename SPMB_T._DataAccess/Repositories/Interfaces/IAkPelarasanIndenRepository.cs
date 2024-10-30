﻿using SPMB_T.__Domain.Entities._Enums;
using SPMB_T.__Domain.Entities.Models._03Akaun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T._DataAccess.Repositories.Interfaces
{
    public interface IAkPelarasanIndenRepository : _IGenericRepository<AkPelarasanInden>
    {
        public List<AkPelarasanInden> GetResults(string? searchString, DateTime? dateFrom, DateTime? dateTo, string? orderBy, EnStatusBorang enStatusBorang);
        public List<AkPelarasanInden> GetResultsByDPekerjaIdFromDKonfigKelulusan(string? searchString, DateTime? dateFrom, DateTime? dateTo, string? orderBy, EnStatusBorang enStatusBorang, int dPekerjaId, EnKategoriKelulusan enKategoriKelulusan, EnJenisModulKelulusan enJenisModulKelulusan);
        public List<AkPelarasanInden> FilterByComparingJBahagianAkPenilaianObjekWithJBahagianDKonfigKelulusan(int dPekerjaId, EnKategoriKelulusan enKategoriKelulusan, EnJenisModulKelulusan enJenisModulKelulusan, List<AkPelarasanInden> akPPList);
        public AkPelarasanInden GetDetailsById(int id);
        public string GetMaxRefNo(string initNoRujukan, string tahun);
        public Task<bool> IsSahAsync(int id);
        public void Sah(int id, int? pengesahId, string? userId);
        public Task<bool> IsSemakAsync(int id);
        public void Semak(int id, int penyemakId, string? userId);
        public Task<bool> IsLulusAsync(int id);
        public void Lulus(int id, int? pelulusId, string? userId);
        public void HantarSemula(int id, string? tindakan, string? userId);
        public Task<bool> IsBatalAsync(int id);
        public void Batal(int id, string? sebabBatal, string? userId);
        public void PostingToAbBukuVot(AkPelarasanInden akPelarasanInden);

        public void RemovePostingFromAbBukuVot(AkPelarasanInden akPelarasanInden, string userId);
        Task<bool> IsPostedAsync(int id, string noRujukan);
        public void BatalLulus(int id, string? tindakan, string? userId);
        public void BatalPos(int id, string? tindakan, string? userId);
    }
}
