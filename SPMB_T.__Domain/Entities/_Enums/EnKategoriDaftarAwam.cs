﻿using System.ComponentModel.DataAnnotations;

namespace SPMB_T.__Domain.Entities._Enums
{
    public enum EnKategoriDaftarAwam
    {
        [Display(Name = "Pembekal")]
        Pembekal = 1,
        [Display(Name = "Penghutang")]
        Penghutang = 2,
        [Display(Name = "Penyewa")]
        Penyewa = 3,
        [Display(Name = "Pekerja")]
        Pekerja = 4,
        [Display(Name = "Daftar Awam")]
        DaftarAwam = 5,
        [Display(Name = "Penceramah")]
        Penceramah = 6,
        [Display(Name = "Ahli Majlis")]
        AhliMajlis = 7,
        [Display(Name = "Lain-lain")]
        LainLain = 0
    }
}