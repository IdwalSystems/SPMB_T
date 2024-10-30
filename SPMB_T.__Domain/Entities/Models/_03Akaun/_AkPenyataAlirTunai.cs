using SPMB_T.__Domain.Entities._Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T.__Domain.Entities.Models._03Akaun
{
    public class _AkPenyataAlirTunai
    {
        public int Susunan { get; set; }
        public string? Perihal { get; set; }
        public string? Tahun { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Amaun1 { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Amaun2 { get; set; }
        public EnKategoriTajuk EnKategoriTajuk { get; set; }
        public EnKategoriJumlah EnKategoriJumlah { get; set; }

    }
}
