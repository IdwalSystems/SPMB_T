﻿using System.ComponentModel.DataAnnotations;

namespace SPMB_T.__Domain.Entities._Enums
{
    public enum EnStatusProses
    {
        [Display(Name = "")]
        None = 0,
        [Display(Name = "Tertangguh")]
        Pending = 1,
        [Display(Name = "Berjaya")]
        Success = 2,
        [Display(Name = "Gagal")]
        Fail = 3,
        [Display(Name = "Campuran")]
        Mixed = 4
    }
}