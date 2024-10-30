using SPMB_T.__Domain.Entities._Enums;
using SPMB_T.__Domain.Entities.Bases;
using SPMB_T.__Domain.Entities.Models._02Daftar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T._DataAccess.Repositories.Interfaces
{
    public interface IDDaftarAwamRepository : _IGenericRepository<DDaftarAwam>
    {
        public List<DDaftarAwam> GetAllDetails();
        public List<SelectItemList> GetAllDetailsGroupByKod();
        public IEnumerable<DDaftarAwam> GetAllDetailsByKategori(EnKategoriDaftarAwam kategoriDaftarAwam);
        public DDaftarAwam GetAllDetailsById(int id);
        public string GetMaxRefNo(string initial);
        public List<DDaftarAwam> GetResults(string? searchString, string? orderBy);
        Task<IEnumerable<DDaftarAwam>> GetResultsAsync(string? searchString, string? orderBy);
    }
}
