using SPMB_T.__Domain.Entities._Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace SPMB_T.__Domain.Entities.Models._01Jadual
{
    public class JKonfigPenyataBaris
    {
        public int Id { get; set; }
        public int Bil { get; set; }
        public int JKonfigPenyataId { get; set; }
        public JKonfigPenyata? JKonfigPenyata { get; set; }
        public EnKategoriTajuk EnKategoriTajuk { get; set; }
        public string? Perihal { get; set; }
        public int Susunan { get; set; }
        public bool IsFormula { get; set; }
        public EnKategoriJumlah EnKategoriJumlah { get; set; }
        public string? JumlahSusunanList { get; set; }
        public ICollection<JKonfigPenyataBarisFormula>? JKonfigPenyataBarisFormula { get; set; }
    }
}