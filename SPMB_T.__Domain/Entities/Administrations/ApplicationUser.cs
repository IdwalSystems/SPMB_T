﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using SPMB_T.__Domain.Entities.Models._02Daftar;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SPMB_T.__Domain.Entities.Administrations
{
    public class ApplicationUser : IdentityUser
    {
        public string? Nama { get; set; }
        [DisplayName("Tandatangan")]
        public string? Tandatangan { get; set; }
        [NotMapped]
        public string? RoleId { get; set; }
        [NotMapped]
        public string? Role { get; set; }
        [NotMapped]
        public List<string>? UserRoles { get; set; }
        [NotMapped]
        public List<IdentityUserRole<string>>? SelectedRoleList { get; set; }
        [NotMapped]
        public IEnumerable<SelectListItem>? RoleList { get; set; }

        //relationship
        public int? DPekerjaId { get; set; }
        public DPekerja? DPekerja { get; set; }
        [DisplayName("Bahagian")]
        public string? JKWPTJBahagianList { get; set; }
        [NotMapped]
        public List<int>? SelectedJKWPTJBahagianList { get; set; }
    }
}
