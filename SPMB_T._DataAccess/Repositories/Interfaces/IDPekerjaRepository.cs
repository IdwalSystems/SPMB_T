﻿using SPMB_T.__Domain.Entities.Models._02Daftar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T._DataAccess.Repositories.Interfaces
{
    public interface IDPekerjaRepository : _IGenericRepository<DPekerja>
    {
        public List<DPekerja> GetAllDetails();
        public string GetMaxRefNo();
        public DPekerja GetAllDetailsById(int id);
        public List<DPekerja> GetResults(string? searchString, string? orderBy);
        public IEnumerable<DPekerja> GetAllByStatus(string? statusKerja);

    }
}
