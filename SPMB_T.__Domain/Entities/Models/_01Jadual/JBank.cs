using SPMB_T.__Domain.Entities.Bases;
using System.ComponentModel;

namespace SPMB_T.__Domain.Entities.Models._01Jadual
{
    public class JBank : GenericFields
    {
        public int Id { get; set; }
        public string? Kod { get; set; }
        public string? Perihal { get; set; }
        [DisplayName("Kod BNM EFT")]
        public string? KodBNMEFT { get; set; }
        [DisplayName("Aksara 1")]
        public int Length1 { get; set; }
        [DisplayName("Aksara 2")]
        public int? Length2 { get; set; }
    }
}
