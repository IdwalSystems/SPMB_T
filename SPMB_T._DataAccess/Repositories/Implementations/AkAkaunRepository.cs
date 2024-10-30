﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SPMB_T.__Domain.Entities.Models._01Jadual;
using SPMB_T.__Domain.Entities.Models._03Akaun;
using SPMB_T._DataAccess.Data;
using SPMB_T._DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SPMB_T._DataAccess.Repositories.Implementations
{
    public class AkAkaunRepository : IAkAkaunRepository<AkAkaun>
    {
        private readonly ApplicationDbContext _context;

        public AkAkaunRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<AkAkaun> GetByNoRujukanAsync(string noRujukan)
        {
            return await _context.AkAkaun.FirstOrDefaultAsync(a => a.NoRujukan == noRujukan) ?? new AkAkaun();
        }

        public async Task<AkAkaun> GetByIdAsync(int id)
        {
            return await _context.AkAkaun.FindAsync(id) ?? new AkAkaun();
        }

        public async Task<AkAkaun> GetPreviousBalanceByStartingDate(int? JKWId, int? JPTJId, int? AkCarta1Id, DateTime? startingDate)
        {
            AkAkaun bakiAwalAkAkaun = new AkAkaun();

            List<AkAkaun> akaunList = new List<AkAkaun>();

            if (JKWId != null && startingDate != null)
            {
                akaunList = await _context.AkAkaun
                                    .Where(ak => ak.JKWId == JKWId
                                    && ak.Tarikh <= startingDate.Value.AddHours(23.99)
                                    && ak.AkCarta1Id == AkCarta1Id)
                                    .ToListAsync();

                if (JPTJId != null)
                {
                    akaunList = akaunList.Where(ak => ak.JPTJId == JPTJId).ToList();
                }

                decimal bakiAwal = 0;

                foreach (var i in akaunList)
                {
                    bakiAwal += i.Debit - i.Kredit;
                };

                bakiAwalAkAkaun.Tarikh = startingDate.Value;
                bakiAwalAkAkaun.NoRujukan = "Baki Awal";
                if (bakiAwal >= 0)
                {
                    bakiAwalAkAkaun.Debit = bakiAwal;
                }
                else
                {
                    bakiAwalAkAkaun.Kredit = 0 - bakiAwal;
                }

            }
            return bakiAwalAkAkaun;
        }

        public async Task<IEnumerable<AkAkaun>> GetResults(int? JKWId, int? JPTJId, int? AkCarta1Id, DateTime? DateFrom, DateTime? DateTo)
        {
            List<AkAkaun> akaunList = new List<AkAkaun>();

            if (JKWId != null && DateFrom != null && DateTo != null)
            {
                akaunList = await _context.AkAkaun
                                    .Include(ak => ak.JPTJ)
                                    .Include(ak => ak.JBahagian)
                                    .Include(ak => ak.AkCarta2)
                                    .Where(ak => ak.JKWId == JKWId
                                    && ak.Tarikh >= DateFrom && ak.Tarikh <= DateTo.Value.AddHours(23.99)
                                    && ak.AkCarta1Id == AkCarta1Id)
                                    .ToListAsync();

                if (JPTJId != null)
                {
                    akaunList = akaunList.Where(ak => ak.JPTJId == JPTJId).ToList();
                }
            }

            return akaunList;
        }
    }
}
