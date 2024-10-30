using SPMB_T.__Domain.Entities.Models._01Jadual;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SPMB_T.__Domain.Entities.Models._03Akaun
{
    public class AkNotaDebitKreditDikeluarkanObjek
    {
        public int Id { get; set; }
        public int AkNotaDebitKreditDikeluarkanId { get; set; }
        public AkNotaDebitKreditDikeluarkan? AkNotaDebitKreditDikeluarkan { get; set; }
        [DisplayName("Carta")]
        public int AkCartaId { get; set; }
        public AkCarta? AkCarta { get; set; }
        [DisplayName("Bahagian")]
        public int JKWPTJBahagianId { get; set; }
        public JKWPTJBahagian? JKWPTJBahagian { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Amaun { get; set; }
    }
}