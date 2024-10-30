﻿using SPMB_T.__Domain.Entities._Enums;
using SPMB_T.__Domain.Entities.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T.__Domain.Entities.Models._01Jadual
{
    public class JKonfigPerubahanEkuiti : GenericFields
    {
        public int Id { get; set; }
        [Display(Name = "Lajur Jadual")]
        public EnJenisLajurJadualPerubahanEkuiti EnLajurJadual { get; set; }
        [Display(Name = "Kump. Wang")]
        public int? JKWId { get; set; }
        public JKW? JKW { get; set; }
        public string? Tahun { get; set; }

        public ICollection<JKonfigPerubahanEkuitiBaris>? JKonfigPerubahanEkuitiBaris { get; set; }

    }
}
