﻿using SPMB_T.__Domain.Entities.Models._01Jadual;
using SPMB_T._DataAccess.Data;
using SPMB_T._DataAccess.Repositories.Interfaces;

namespace SPMB_T._DataAccess.Repositories.Implementations
{
    public class JCukaiRepository : _GenericRepository<JCukai>, IJCukaiRepository
    {
        public JCukaiRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}