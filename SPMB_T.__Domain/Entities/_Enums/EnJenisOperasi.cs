﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T.__Domain.Entities._Enums
{
    public enum EnJenisOperasi
    {
        [Display(Name = "+")]
        Tambah = 0,
        [Display(Name = "-")]
        Tolak = 1,
    }
}