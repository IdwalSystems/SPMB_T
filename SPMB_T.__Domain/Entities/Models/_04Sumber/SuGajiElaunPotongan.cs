using SPMB_T.__Domain.Entities.Models._01Jadual;

namespace SPMB_T.__Domain.Entities.Models._04Sumber
{
    public class SuGajiElaunPotongan
    {
        public int Id { get; set; }
        public int SuGajiBulananPekerjaId { get; set; }
        public SuGajiBulananPekerja? SuGajiBulananPekerja { get; set; }
        public int JElaunPotonganId { get; set; }
        public JElaunPotongan? JElaunPotongan { get; set; }
    }
}