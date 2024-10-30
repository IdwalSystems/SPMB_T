using System.ComponentModel.DataAnnotations;

namespace SPMB_T.BaseSumber.Models.ViewModels.Administrations
{
    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessage = "Emel diperlukan")]
        [EmailAddress]
        public string Emel { get; set; } = string.Empty;
    }
}
