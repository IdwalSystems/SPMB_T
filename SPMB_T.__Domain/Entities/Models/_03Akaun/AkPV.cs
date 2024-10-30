﻿using SPMB_T.__Domain.Entities._Enums;
using SPMB_T.__Domain.Entities.Bases;
using SPMB_T.__Domain.Entities.Models._01Jadual;
using SPMB_T.__Domain.Entities.Models._04Sumber;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T.__Domain.Entities.Models._03Akaun
{
    public class AkPV : GenericTransactionFields
    {
        public int Id { get; set; }
        [DisplayName("Tahun Belanjawan")]
        public string? Tahun { get; set; }
        [DisplayName("No Rujukan")]
        public string? NoRujukan { get; set; }
        public DateTime Tarikh { get; set; }
        [DisplayName("Cawangan")]
        public int JCawanganId { get; set; }
        public JCawangan? JCawangan { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Jumlah { get; set; }
        public bool IsInvois { get; set; }
        public bool IsAkru { get; set; }
        public bool IsTanggungan { get; set; }
        [DisplayName("Akaun Bank")]
        public int AkBankId { get; set; }
        public AkBank? AkBank { get; set; }
        [DisplayName("Kump. Wang")]
        public int JKWId { get; set; }
        public JKW? JKW { get; set; }
        public string? Ringkasan { get; set; }
        public string? NoRujukanLama { get; set; } // dummy
        [Display(Name = "Janaan Profil")]
        public int? AkJanaanProfilId { get; set; }
        public AkJanaanProfil? AkJanaanProfil { get; set; }
        public int? SuGajiBulananId { get; set; }
        public SuGajiBulanan? SuGajiBulanan { get; set; }
        public DateTime? TarikhJanaanProfil { get; set; }
        [DisplayName("Nama Penerima")]
        public string? NamaPenerima { get; set; }
        public bool IsGanda { get; set; }
        [DisplayName("Jenis Bayaran")]
        public EnJenisBayaran EnJenisBayaran { get; set; }
        public ICollection<AkPVObjek>? AkPVObjek { get; set; }
        public ICollection<AkPVInvois>? AkPVInvois { get; set; }
        public ICollection<AkPVPenerima>? AkPVPenerima { get; set; }
        public ICollection<AkEFTPenerima>? AkEFTPenerima { get; set; }
        public ICollection<AkJurnalPenerimaCekBatal>? AkJurnalPenerimaCekBatal { get; set; }
    }
}
