using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T.__Domain.Entities._Enums
{
    public enum EnKategoriJumlah
    {
        [Display(Name = "Amaun Biasa")]
        Amaun = 0,
        [Display(Name = "Jumlah Kecil")]
        JumlahKecil = 1,
        [Display(Name = "Jumlah Besar")]
        JumlahBesar = 2,
        [Display(Name = "Jumlah Keseluruhan")]
        JumlahKeseluruhan = 3
    }
}
