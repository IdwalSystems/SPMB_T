using SPMB_T.__Domain.Entities._Enums;
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
    public class DKonfigKelulusanBahagian
    {
        public int Id { get; set; }
        public int DKonfigKelulusanId { get; set; }
        public DKonfigKelulusan? DKonfigKelulusan { get; set; }
        public int JBahagianId { get; set; }
        public JBahagian? JBahagian { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal MinAmaun { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal MaksAmaun { get; set; }
    }
}
