﻿using SPMB_T.__Domain.Entities.Bases;

namespace SPMB_T.__Domain.Entities.Models._01Jadual
{
    public class JNegeri : GenericFields
    {
        public int Id { get; set; }
        public string? Kod { get; set; }
        public string? Perihal { get; set; }
    }
}
