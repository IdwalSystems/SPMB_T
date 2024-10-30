﻿using SPMB_T.__Domain.Entities._Enums;
using SPMB_T.__Domain.Entities.Bases;
using SPMB_T.__Domain.Entities.Models._01Jadual;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SPMB_T.__Domain.Entities.Models._02Daftar
{
    public class DPenerimaZakat : GenericFields
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Kod Diperlukan")]
        [DisplayName("Kod")]
        public string? Kod { get; set; }

        [Required(ErrorMessage = "Nama Diperlukan")]
        [DisplayName("Nama")]
        public string? Nama { get; set; }
        [DisplayName("Negeri")]
        public int? JNegeriId { get; set; }
        public virtual JNegeri? JNegeri { get; set; }
        [DisplayName("Bank")]
        public int? JBankId { get; set; }
        public virtual JBank? JBank { get; set; }
        [DisplayName("No Pendaftaran / No. KP / No Tentera")] // no IC // No Pendaftaran
        public string? NoPendaftaran { get; set; }
        [DisplayName("No KP Lama")] // no IC // No Pendaftaran // Lama
        public string? NoKPLama { get; set; }
        [DisplayName("Alamat")]
        public string? Alamat1 { get; set; }
        public string? Alamat2 { get; set; }
        public string? Alamat3 { get; set; }
        [MaxLength(5)]
        [RegularExpression(@"^[\d+]*$", ErrorMessage = "Nombor sahaja dibenarkan")]
        public string? Poskod { get; set; }
        public string? Bandar { get; set; }
        [DisplayName("No Telefon 1")]
        [RegularExpression(@"^[\d+]*$", ErrorMessage = "Nombor sahaja dibenarkan")]
        public string? Telefon1 { get; set; }
        [DisplayName("No Telefon 2")]
        public string? Telefon2 { get; set; }
        [DisplayName("No Telefon 3")]
        public string? Telefon3 { get; set; }
        [DisplayName("Tel. Bimbit")]
        public string? Handphone { get; set; }
        [EmailAddress(ErrorMessage = "Emel tidak sah"), MaxLength(100)]
        public string? Emel { get; set; }
        [DisplayName("No Akaun Bank")]
        [RegularExpression(@"^[\d+]*$", ErrorMessage = "Nombor sahaja dibenarkan")]
        public string? NoAkaunBank { get; set; }
        [DisplayName("Kategori Daftar Awam")]
        public EnKategoriDaftarAwam EnKategoriDaftarAwam { get; set; }
        [DisplayName("Kategori Ahli")]
        public EnKategoriAhli EnKategoriAhli { get; set; }
        public string? Faks { get; set; }
        [DisplayName("Jangka Masa")]
        public DateTime? JangkaMasaDari { get; set; }
        public DateTime? JangkaMasaHingga { get; set; }
        [DisplayName("Kod M2E")]
        public string? KodM2E { get; set; }
        [Display(Name = "Jenis Id")]
        public EnJenisId EnJenisId { get; set; }
    }
}