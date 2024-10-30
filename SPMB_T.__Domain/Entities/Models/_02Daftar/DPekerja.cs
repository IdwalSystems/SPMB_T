﻿using SPMB_T.__Domain.Entities._Enums;
using SPMB_T.__Domain.Entities.Bases;
using SPMB_T.__Domain.Entities.Models._01Jadual;
using SPMB_T.__Domain.Entities.Models._04Sumber;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SPMB_T.__Domain.Entities.Models._02Daftar
{
    public class DPekerja : GenericFields
    {
        public int Id { get; set; }
        [DisplayName("No Gaji")]
        public string? NoGaji { get; set; }
        [DisplayName("Kod Pekerja")]
        public string? KodPekerja { get; set; }
        [Required(ErrorMessage = "No Kad Pengenalan diperlukan")]
        [DisplayName("No KP")]
        public string? NoKp { get; set; }
        [DisplayName("No KP Lama")]
        public string? NoKpLama { get; set; }
        [Required(ErrorMessage = "Nama diperlukan")]
        public string? Nama { get; set; }
        [DisplayName("Tarikh lahir")]
        public DateTime? TarikhLahir { get; set; }
        [DisplayName("Alamat")]
        [Required(ErrorMessage = "Alamat diperlukan")]
        public string? Alamat1 { get; set; }
        public string? Alamat2 { get; set; }
        public string? Alamat3 { get; set; }
        [MaxLength(5)]
        [RegularExpression(@"^[\d+]*$", ErrorMessage = "Nombor sahaja dibenarkan")]
        public string? Poskod { get; set; }
        public string? Bandar { get; set; }
        [DisplayName("Negeri")]
        [Required(ErrorMessage = "Negeri diperlukan")]
        public int JNegeriId { get; set; }
        [DisplayName("No Telefon Rumah")]
        [RegularExpression(@"^[\d+]*$", ErrorMessage = "Nombor sahaja dibenarkan")]
        public string? TelefonRumah { get; set; }
        [DisplayName("No Telefon Bimbit")]
        [RegularExpression(@"^[\d+]*$", ErrorMessage = "Nombor sahaja dibenarkan")]
        public string? TelefonBimbit { get; set; }
        [Required(ErrorMessage = "Emel diperlukan")]
        [EmailAddress(ErrorMessage = "Emel tidak sah"), MaxLength(100)]
        public string? Emel { get; set; }
        [DisplayName("Tarikh Masuk Kerja")]
        public DateTime TarikhMasukKerja { get; set; }
        [DisplayName("Tarikh Berhenti Kerja")]
        public DateTime? TarikhBerhentiKerja { get; set; }
        [DisplayName("Nama Bank")]
        public int? JBankId { get; set; }
        public JBangsa? JBangsa { get; set; }
        [DisplayName("Jawatan")]
        public string? Jawatan { get; set; }
        [Required(ErrorMessage = "No Akaun Bank diperlukan")]
        [DisplayName("No Akaun Bank")]
        [RegularExpression(@"^[\d+]*$", ErrorMessage = "Nombor sahaja dibenarkan")]
        public string? NoAkaunBank { get; set; }
        public bool IsAdmin { get; set; }

        //relationship
        [DisplayName("Negeri")]
        public JNegeri? JNegeri { get; set; }

        [DisplayName("Nama Bank")]
        public JBank? JBank { get; set; }
        [DisplayName("Kod M2E")]
        public string? KodM2E { get; set; }
        [DisplayName("No Cukai")]
        public string? NoCukai { get; set; }
        [DisplayName("No PERKESO")]
        public string? NoPerkeso { get; set; }
        [DisplayName("No KWAP")]
        public string? NoKWAP { get; set; }
        [DisplayName("No KWSP")]
        public string? NoKWSP { get; set; }
        [DisplayName("Bahagian")]
        public int JBahagianId { get; set; }
        public JBahagian? JBahagian { get; set; }

        [DisplayName("Cawangan")]
        public int JCawanganId { get; set; }
        public JCawangan? JCawangan { get; set; }
        public ICollection<DPenyelia>? DPenyelia { get; set; }
        [DisplayName("PTJ")]
        public int JPTJId { get; set; }
        public JPTJ? JPTJ { get; set; }
        [Display(Name = "Jenis Id")]
        public EnJenisId EnJenisId { get; set; }
        public ICollection<DPekerjaElaunPotongan>? DPekerjaElaunPotongan { get; set; }
        public ICollection<SuGajiBulananPekerja>? SuGajiBulananPekerja { get; set; }
        public ICollection<DPanjarPemegang>? DPanjarPemegang { get; set; }


    }
}
