﻿using SPMB_T.__Domain.Entities._Enums;
using SPMB_T.__Domain.Entities.Bases;
using SPMB_T.__Domain.Entities.Models._01Jadual;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T.__Domain.Entities.Models._02Daftar
{
    public class DKonfigKelulusan : GenericFields
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Anggota Diperlukan")]
        [DisplayName("Anggota")]
        public int DPekerjaId { get; set; }
        public DPekerja? DPekerja { get; set; }
        [DisplayName("Bahagian")]
        public int? JBahagianId { get; set; }
        public JBahagian? JBahagian { get; set; }
        [DisplayName("Kategori Kelulusan")]
        public EnKategoriKelulusan EnKategoriKelulusan { get; set; }
        [DisplayName("Jenis Modul")]
        public EnJenisModulKelulusan EnJenisModulKelulusan { get; set; }
        [DisplayName("Amaun Disemak RM")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal MinAmaun { get; set; }
        [Column(TypeName = "decimal(18, 2)")]

        public decimal MaksAmaun { get; set; }
        [DataType(DataType.Password)]
        [DisplayName("Kata Laluan")]
        public string? KataLaluan { get; set; }
        [DisplayName("Tandatangan")]
        public string? Tandatangan { get; set; }
        public string? KodLama { get; set; } // dummy
        public bool IsAktif { get; set; }
    }
}