﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T.__Domain.Entities.Bases
{
    public interface IGenericFields
    {
        //Soft Delete
        public int FlHapus { get; set; }
        public DateTime? TarHapus { get; set; }
        public string? SebabHapus { get; set; }
        //Soft Delete end
    }
}
