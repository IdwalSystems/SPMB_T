using SPMB_T.__Domain.Entities.Bases;
using SPMB_T.__Domain.Entities.Models._01Jadual;
using SPMB_T.__Domain.Entities.Models._03Akaun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T.__Domain.Entities.Models._02Daftar
{
    public class DKonfigKelulusanViewModel : GenericFields
    {
        public int Id { get; set; }
        public string? EnJenisModulKelulusan { get; set; }
        public string? EnKategoriKelulusan { get; set; }
        public string? JBahagian { get; set; }
        public DPekerja? DPekerja { get; set; }
        public decimal MinAmaun { get; set; }
        public decimal MaksAmaun { get; set; }
    }
}

