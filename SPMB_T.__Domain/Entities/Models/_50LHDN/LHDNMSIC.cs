using SPMB_T.__Domain.Entities.Models._03Akaun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T.__Domain.Entities.Models._50LHDN
{
    public class LHDNMSIC
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        public string? MSICCategoryReference { get; set; }
        public ICollection<AkBelian>? AkBelian { get; set; }
        public ICollection<AkInvois>? AkInvois { get; set; }
        public ICollection<AkNotaDebitKreditDikeluarkan>? AkNotaDebitKreditDikeluarkan { get; set; }
        public ICollection<AkNotaDebitKreditDiterima>? AkNotaDebitKreditDiterima { get; set; }
    }
}
