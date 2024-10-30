﻿using SPMB_T.__Domain.Entities._Enums;
using SPMB_T.__Domain.Entities.Bases;
using SPMB_T.__Domain.Entities.Models._01Jadual;
using SPMB_T.__Domain.Entities.Models._02Daftar;
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
    public class AkBelian : GenericTransactionFields
    {
        public int Id { get; set; }
        [DisplayName("Tahun Belanjawan")]
        public string? Tahun { get; set; }
        [DisplayName("No Rujukan")]
        public string? NoRujukan { get; set; }
        [DisplayName("Tarikh")]
        public DateTime Tarikh { get; set; }
        [DisplayName("Tarikh Terima Bahagian")]
        public DateTime TarikhTerimaBahagian { get; set; }
        [DisplayName("Tarikh Terima Kewangan")]
        public DateTime? TarikhTerimaKewangan { get; set; }
        [DisplayName("Tarikh Akuan Kewangan")]
        public DateTime? TarikhAkuanKewangan { get; set; }
        [DisplayName("Bayaran Untuk")]
        public EnJenisBayaranBelian EnJenisBayaranBelian { get; set; }
        [DisplayName("No Inden Kerja")]
        public int? AkIndenId { get; set; }
        public AkInden? AkInden { get; set; }
        [DisplayName("No Pesanan Tempatan")]
        public int? AkPOId { get; set; }
        public AkPO? AkPO { get; set; }
        [DisplayName("No Nota Minta")]
        public int? AkNotaMintaId { get; set; }
        public AkNotaMinta? AkNotaMinta { get; set; }

        [DisplayName("Pembekal")]
        public int DDaftarAwamId { get; set; }
        public DDaftarAwam? DDaftarAwam { get; set; }
        [DisplayName("Akaun Pemiutang")]
        public int? AkAkaunAkruId { get; set; }
        public AkCarta? AkAkaunAkru { get; set; }
        [DisplayName("Jumlah RM")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Jumlah { get; set; }
        [DisplayName("Kump. Wang")]
        public int JKWId { get; set; }
        public JKW? JKW { get; set; }
        public string? Ringkasan { get; set; }
        [DisplayName("No e-Invois")]
        public int? LHDNEInvoisId { get; set; }
        public LHDNEInvois? LHDNEInvois { get; set; }
        public int? LHDNMSICId { get; set; }
        [DisplayName("MSIC")]
        public LHDNMSIC? LHDNMSIC { get; set; }
        public string? UUID { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal JumlahCukai { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal JumlahTanpaCukai { get; set; }
        public string? KodPbklLama { get; set; }
        public ICollection<AkBelianObjek>? AkBelianObjek { get; set; }
        public ICollection<AkBelianPerihal>? AkBelianPerihal { get; set; }
        public ICollection<AkPVInvois>? AkPVInvois { get; set; }

    }
}
