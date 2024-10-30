using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T.__Domain.Entities._Enums
{
    public enum EnJenisJurnal
    {
        [Display(Name = "Cek Batal")]
        CekBatal = 1,
        [Display(Name = "Pel. Baucer")]
        Baucer = 2,
        [Display(Name = "Lain-lain")]
        LainLain = 0
    }
}
