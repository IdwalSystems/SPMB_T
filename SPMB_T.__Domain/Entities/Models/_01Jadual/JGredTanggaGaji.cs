using SPMB_T.__Domain.Entities._Enums;
using SPMB_T.__Domain.Entities.Bases;
using System.ComponentModel;

namespace SPMB_T.__Domain.Entities.Models._01Jadual
{
    public class JGredTanggaGaji : GenericFields
    {
        public int Id { get; set; }
        [DisplayName("Tangga Gaji (SSM / SSPA)")]
        public int JTanggaGajiId { get; set; }
        public JTanggaGaji? JTanggaGaji { get; set; }
        [DisplayName("Gred Gaji")]
        public int JGredGajiId { get; set; }
        public JGredGaji? JGredGaji { get; set; }
        [DisplayName("Sijil Kelayakan")]
        public EnSijilKelayakan EnSijilKelayakan { get; set; }
    }
}
