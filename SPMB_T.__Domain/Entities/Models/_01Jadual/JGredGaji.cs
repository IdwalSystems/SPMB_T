using SPMB_T.__Domain.Entities._Enums;
using SPMB_T.__Domain.Entities.Bases;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SPMB_T.__Domain.Entities.Models._01Jadual
{
    public class JGredGaji : GenericFields
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Kod diperlukan")]
        public string? Kod { get; set; }
        [DisplayName("Klasifikasi Perkhidmatan")]
        public EnKlasifikasiPerkhidmatan EnKlasifikasiPerkhidmatan { get; set; }

    }
}
