using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T.__Domain.Entities._Enums
{
    public enum EnJenisBayaranBelian
    {
        [Display(Name = "Lain - Lain")]
        LainLain = 0,
        [Display(Name = "Pesanan Tempatan")]
        PO = 1,
        [Display(Name = "Inden Kerja")]
        Inden = 2,
        [Display(Name = "Nota Minta")]
        NotaMinta = 3
    }
}
