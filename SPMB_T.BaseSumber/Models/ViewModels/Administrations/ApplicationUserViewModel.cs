using SPMB_T.BaseSumber.Models.ViewModels.Common;
using System.ComponentModel;

namespace SPMB_T.BaseSumber.Models.ViewModels.Administrations
{
    public class ApplicationUserViewModel : EditSignViewModel
    {
        public string id { get; set; } = string.Empty;
        public string Nama { get; set; } = string.Empty;
        [DisplayName("Tandatangan")]
        public string Tandatangan { get; set; } = string.Empty;
    }
}
