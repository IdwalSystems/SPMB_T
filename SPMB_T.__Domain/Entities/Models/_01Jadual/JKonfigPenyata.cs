using SPMB_T.__Domain.Entities.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T.__Domain.Entities.Models._01Jadual
{
    public class JKonfigPenyata : GenericFields
    {
        public int Id { get; set; }
        public string? Kod { get; set; }
        public string? Perihal { get; set; }
        public string? Tahun { get; set; }
        public ICollection<JKonfigPenyataBaris>? JKonfigPenyataBaris { get; set; }
    }
}
