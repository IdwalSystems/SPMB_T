﻿using SPMB_T.__Domain.Entities.Bases;
using SPMB_T.__Domain.Entities.Models._02Daftar;
using SPMB_T.__Domain.Entities.Models._03Akaun;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T.__Domain.Entities.Models._01Jadual
{
    public class JCawangan : GenericFields
    {
        public int Id { get; set; }
        public string? Kod { get; set; }
        [DisplayName("Cawangan")]
        public string? Perihal { get; set; }
        [DisplayName("Kod Bank")]
        public int? AkBankId { get; set; }
        public AkBank? AkBank { get; set; }
        public ICollection<DPenyelia>? DPenyelia { get; set; }
        public ICollection<AkTerima>? AkTerima { get; set; }
        public ICollection<AkJanaanProfil>? AkJanaanProfil { get; set; }
        public ICollection<AkPenyataPemungut>? AkPenyataPemungut { get; set; }

    }
}
