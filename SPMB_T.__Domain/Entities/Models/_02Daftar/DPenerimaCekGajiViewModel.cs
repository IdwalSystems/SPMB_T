using SPMB_T.__Domain.Entities.Bases;
using SPMB_T.__Domain.Entities.Models._03Akaun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T.__Domain.Entities.Models._02Daftar
{
    public class DPenerimaCekGajiViewModel : GenericFields
    {
        public IEnumerable<DPenerimaCekGaji>? DPenerimaCekGaji { get; set; }
        public IEnumerable<AkJanaanProfil>? AkJanaanProfil { get; set; }
    }
}
