using System.ComponentModel.DataAnnotations;

namespace SPMB_T.__Domain.Entities._Enums
{
    public enum EnSijilKelayakan
    {
        [Display(Name = "SPM")]
        SPM = 1, 
        [Display(Name = "Diploma/STPM")]
        DiplomaSTPM = 2,
        [Display(Name = "IJazah")]
        Ijazah = 3,
    }
}
