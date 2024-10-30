using SPMB_T.__Domain.Entities.Administrations;

namespace SPMB_T.BaseSumber.Models.ViewModels.Prints
{
    public class AppLogPrintModel
    {
        public List<AppLog>? AppLog { get; set; }
        public CompanyDetails? CompanyDetail { get; set; }
    }
}
