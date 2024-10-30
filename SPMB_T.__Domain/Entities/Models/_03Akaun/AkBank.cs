﻿using SPMB_T.__Domain.Entities.Bases;
using SPMB_T.__Domain.Entities.Models._01Jadual;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T.__Domain.Entities.Models._03Akaun
{
    public class AkBank : GenericFields
    {
        public int Id { get; set; }
        [DisplayName("Kod Bank")]
        [Required(ErrorMessage = "Kod Bank Diperlukan")]
        public string? Kod { get; set; }
        public string? Perihal { get; set; }
        [DisplayName("No Akaun Bank")]
        [Required(ErrorMessage = "No Akaun Bank Diperlukan")]
        public string? NoAkaun { get; set; }
        [DisplayName("Kump. Wang")]
        public int JKWId { get; set; }
        public JKW? JKW { get; set; }
        [DisplayName("Kod Akaun")]
        public int AkCartaId { get; set; }
        public AkCarta? AkCarta { get; set; }
        [DisplayName("Bank")]
        public int JBankId { get; set; }
        public JBank? JBank { get; set; }
        public ICollection<AkPV>? AkPV { get; set; }
        public ICollection<AkEFT>? AkEFT { get; set; }
        public ICollection<AkPenyataPemungut>? AkPenyataPemungut { get; set; }
        public ICollection<AkPenyesuaianBank>? AkPenyesuaianBank { get; set; }


    }
}
