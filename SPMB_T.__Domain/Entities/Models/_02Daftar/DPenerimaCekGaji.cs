﻿using SPMB_T.__Domain.Entities.Bases;
using SPMB_T.__Domain.Entities.Models._01Jadual;
using SPMB_T.__Domain.Entities.Models._03Akaun;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T.__Domain.Entities.Models._02Daftar
{
    public class DPenerimaCekGaji : GenericFields
    {
        public int Id { get; set; }

        public string? Kod { get; set; }

        [DisplayName("Amaun RM")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal AmaunGaji { get; set; }

        [DisplayName("Surat Nama")]
        public string? SuratNama { get; set; }

        [DisplayName("Surat Jabatan ")]
        public string? SuratJabatan { get; set; }


        [DisplayName("Rujukan Kami")]
        public string? RujukanKami { get; set; }


        [DisplayName("Nama")]
        public int? DDaftarAwamId { get; set; }
        public DDaftarAwam? DDaftarAwam { get; set; }

        [DisplayName("Cara Bayar")]
        public int JCaraBayarId { get; set; }
        public JCaraBayar? JCaraBayar { get; set; }

        [DisplayName("Cawangan")]
        public int? JCawanganId { get; set; }
        public JCawangan? JCawangan { get; set; }









    }
}
