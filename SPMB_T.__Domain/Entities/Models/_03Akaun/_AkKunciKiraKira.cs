using SPMB_T.__Domain.Entities._Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T.__Domain.Entities.Models._03Akaun
{
    public class _AkKunciKiraKira
    {
        public int Order { get; set; }
        public string? Jenis { get; set; }
        public string? Paras { get; set; }
        public string? KodAkaun { get; set; }
        public string? NamaAkaun { get; set; }
        public decimal Amaun { get; set; }

    }
}
