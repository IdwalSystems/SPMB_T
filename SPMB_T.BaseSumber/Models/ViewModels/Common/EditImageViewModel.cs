﻿namespace SPMB_T.BaseSumber.Models.ViewModels.Common
{
    public class EditImageViewModel : UploadImageViewModel
    {
        public int Id { get; set; }
        public string GambarSediaAda { get; set; } = string.Empty;
    }
}