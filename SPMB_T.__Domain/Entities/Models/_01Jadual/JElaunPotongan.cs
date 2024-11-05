using SPMB_T.__Domain.Entities.Bases;
using SPMB_T.__Domain.Entities.Models._02Daftar;
using SPMB_T.__Domain.Entities.Models._04Sumber;
using System.ComponentModel;

namespace SPMB_T.__Domain.Entities.Models._01Jadual
{
    public class JElaunPotongan : GenericFields
    {
        public int Id { get; set; }
        public string? Kod { get; set; }
        public string? Perihal { get; set; }
        [DisplayName("Gaji Pokok")]
        public bool IsGajiPokok { get; set; }
        [DisplayName("KWSP")]
        public bool IsKWSP { get; set; }
        [DisplayName("SOCSO")]
        public bool IsSOCSO { get; set; }
        public ICollection<SuGajiElaunPotongan>? SuGajiElaunPotongan { get; set; }
        public ICollection<DPekerjaElaunPotongan>? DPekerjaElaunPotongan { get; set; }
    }
}