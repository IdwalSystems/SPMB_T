﻿using SPMB_T.__Domain.Entities._Enums;
using SPMB_T.__Domain.Entities.Models._50LHDN;
using System.ComponentModel.DataAnnotations.Schema;

namespace SPMB_T.__Domain.Entities.Models._03Akaun
{
    public class AkPelarasanIndenPerihal
    {
        public int Id { get; set; }
        public int AkPelarasanIndenId { get; set; }
        public AkPelarasanInden? AkPelarasanInden { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Bil { get; set; }
        public string? Perihal { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Kuantiti { get; set; }
        public int? LHDNKodKlasifikasiId { get; set; }
        public LHDNKodKlasifikasi? LHDNKodKlasifikasi { get; set; }
        public int? LHDNUnitUkuranId { get; set; }
        public LHDNUnitUkuran? LHDNUnitUkuran { get; set; }
        public string? Unit { get; set; }
        public EnLHDNJenisCukai EnLHDNJenisCukai { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal KadarCukai { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal AmaunCukai { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Harga { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Amaun { get; set; }
    }
}