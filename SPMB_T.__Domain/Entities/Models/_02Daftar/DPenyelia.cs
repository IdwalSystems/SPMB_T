﻿using SPMB_T.__Domain.Entities.Models._01Jadual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T.__Domain.Entities.Models._02Daftar
{
    public class DPenyelia
    {
        public int Id { get; set; }
        public int JCawanganId { get; set; }
        public JCawangan? JCawangan { get; set; }
        public int DPekerjaId { get; set; }
        public DPekerja? DPekerja { get; set; }
    }
}
