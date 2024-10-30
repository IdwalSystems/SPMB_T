﻿using SPMB_T.__Domain.Entities._Enums;
using SPMB_T.__Domain.Entities.Models._03Akaun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T._DataAccess.Repositories.Interfaces
{
    public interface IAkCartaRepository : _IGenericRepository<AkCarta>
    {
        string FormulaInSentence(EnJenisOperasi jenisOperasi, string? jenisCarta, bool isKecuali, string? kodList);
        public List<AkCarta> GetResultsByJenis(EnJenisCarta jenis, EnParas paras);
        public List<AkCarta> GetResultsByParas(EnParas paras);
        string GetSetOfCartaStringList(bool isPukal, string? enJenisCartaList, bool isKecuali, string? kodList);
    }
}
