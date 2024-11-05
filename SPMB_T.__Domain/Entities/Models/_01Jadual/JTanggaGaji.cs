using SPMB_T.__Domain.Entities.Bases;
using System.ComponentModel;

namespace SPMB_T.__Domain.Entities.Models._01Jadual
{
    public class JTanggaGaji : GenericFields
    {
        public int Id { get; set; }
        [DisplayName("Kod SSPA")]
        public string? KodSSPA { get; set; }
        [DisplayName("Kod SSM")]
        public string? KodSSM { get; set; }
        public ICollection<JGredTanggaGaji>? JGredTanggaGaji { get; set; }
    }
}
