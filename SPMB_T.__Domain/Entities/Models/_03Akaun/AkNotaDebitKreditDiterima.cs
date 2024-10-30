﻿using SPMB_T.__Domain.Entities.Bases;
using SPMB_T.__Domain.Entities.Models._01Jadual;
using SPMB_T.__Domain.Entities.Models._50LHDN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T.__Domain.Entities.Models._03Akaun
{
    public class AkNotaDebitKreditDiterima : GenericTransactionFields
    {
        public int Id { get; set; }
        [DisplayName("Tahun Belanjawan")]
        public string? Tahun { get; set; }
        [DisplayName("No Rujukan")]
        public string? NoRujukan { get; set; }
        [DisplayName("Tarikh")]
        public DateTime Tarikh { get; set; }
        // nota :
        // 0 - debit
        // 1 - kredit
        [DisplayName("Debit / Kredit")]
        public int FlDebitKredit { get; set; }
        [DisplayName("No Invois Pembekal")]
        public int AkBelianId { get; set; }

        public AkBelian? AkBelian { get; set; }
        [DisplayName("Jumlah RM")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Jumlah { get; set; }
        [DisplayName("Kump. Wang")]
        public int JKWId { get; set; }
        public JKW? JKW { get; set; }
        public string? Ringkasan { get; set; }
        public int? LHDNEInvoisId { get; set; }
        public LHDNEInvois? LHDNEInvois { get; set; }
        [DisplayName("MSIC")]
        public int? LHDNMSICId { get; set; }
        public LHDNMSIC? LHDNMSIC { get; set; }
        public string? UUID { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal JumlahCukai { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal JumlahTanpaCukai { get; set; }
        public ICollection<AkNotaDebitKreditDiterimaObjek>? AkNotaDebitKreditDiterimaObjek { get; set; }
        public ICollection<AkNotaDebitKreditDiterimaPerihal>? AkNotaDebitKreditDiterimaPerihal { get; set; }


    }
}
