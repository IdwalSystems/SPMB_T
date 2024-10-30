﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T.__Domain.Entities._Enums
{
    public enum EnJantina
    {
        [Display(Name = "Lelaki")]
        Lelaki = 1,
        [Display(Name = "Perempuan")]
        Perempuan = 2,
        [Display(Name = "Lain-lain")]
        LainLain = 0
    }
}
