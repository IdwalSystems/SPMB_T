using SPMB_T.__Domain.Entities.Administrations;

namespace SPMB_T.BaseSumber.Models.ViewModels.Prints
{
    public class CommonPrintModel
    {
        public string? Username { get; set; }
        public string? KodLaporan { get; set; }
        public string? Tajuk1 { get; set; }
        public string? Tajuk2 { get; set; }
        public CompanyDetails? CompanyDetails { get; set; }
    }
}