﻿using SPMB_T.__Domain.Entities.Models._03Akaun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T._DataAccess.Repositories.Interfaces
{
    public interface IAkAkaunPenyataBankRepository<T1> where T1 : class
    {
        void Add(AkAkaunPenyataBank akAkaunPenyataBank);
        Task<IEnumerable<T1>> GetPadananPenyataListByAkPenyesuaianBankIdAsync(int akPenyesuaianBankId);
        Task<IEnumerable<AkAkaunPenyataBank>> GetListByIdAsync(int id);
        void Remove(int id);
        void Save();
        void Update(AkAkaunPenyataBank akAkaunPenyataBank);
    }
}
