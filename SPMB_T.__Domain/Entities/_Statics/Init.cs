using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T.__Domain.Entities._Statics
{
    public static class Init
    {
        public const string superAdminName = "SuperAdmin";
        public const string superAdminEmail = "amin@idwal.com.my";
        public const string superAdminPassword = "Latihan2024#";

        public const string superAdminRole = "SuperAdmin";

        public const string adminRole = "Admin";
        public const string supervisorRole = "Supervisor";
        public const string userRole = "User";

        public const string superAdminAdminRole = superAdminRole + "," + adminRole;
        public const string superAdminSupervisorRole = superAdminRole + "," + supervisorRole;
        public const string allExceptAdminRole = superAdminRole + "," + supervisorRole + "," + userRole;
        public const string allExceptSuperadminRole = adminRole + "," + supervisorRole + "," + userRole;
        public const string allRole = superAdminRole + "," + supervisorRole + "," + userRole + "," + adminRole;

        // initial password
        public const string commonPassword = "Spmb1234#";

        // list of systems
        public const string CompSPMBCode = "Akaun"; // Akaun & Belanjawan
        public const string CompSPSUCode = "Sumber"; // Sumber
        public const string CompSPSWCode = "Sewaan"; // Sewaan
        public const string CompSPDWCode = "Dana Wakaf"; // Dana Wakaf
        public const string CompSPASCode = "Aset"; // Aset

        // initial Company Details
        public const string CompName = "<Nama_Agensi>";
        public const string CompInitial = "<Singkatan_Agensi>";
        public const string CompRegNo = "<No_Pendaftaran_agensi>";
        public const string CompAddress1 = "<Alamat_Agensi_1>";
        public const string CompAddress2 = "<Alamat_Agensi_2>";
        public const string CompAddress3 = "<Alamat_Agensi_3>";
        public const string CompCity = "<Bandar_Agensi>";
        public const string CompPoscode = "<Poskod_Agensi>";
        public const string CompDistrict = "<Daerah_Agensi>";
        public const string CompState = "<Negeri_Agensi>";
        public const string CompTel = "<No_Tel_Agensi>";
        public const string CompEmail = "<Emel_Agensi>";
        public const string CompFax = "<Faks_Agensi>";
        public const string CompWebLogo = "MainLogo_Syarikat.webp";
        public const string CompPrintLogo = "MainLogo_Syarikat.png";
    }
}
