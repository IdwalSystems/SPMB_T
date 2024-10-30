﻿using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using SPMB_T.__Domain.Entities._Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T._DataAccess.Services.Cart.Session
{
    public class SessionCartAkNotaDebitKreditDiterima : CartAkNotaDebitKreditDiterima
    {
        public static CartAkNotaDebitKreditDiterima GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext!.Session!;
            SessionCartAkNotaDebitKreditDiterima cart = session?.GetJson<SessionCartAkNotaDebitKreditDiterima>("CartAkNotaDebitKreditDiterima") ?? new SessionCartAkNotaDebitKreditDiterima();
            cart.Session = session;
            return cart;
        }
        private ISession? Session { get; set; }

        // NotaDebitKreditDiterimaObjek
        public override void AddItemObjek(int akNotaDebitKreditDiterimaId, int jKWPTJBahagianId, int akCartaId, decimal amaun)
        {
            base.AddItemObjek(akNotaDebitKreditDiterimaId, jKWPTJBahagianId, akCartaId, amaun);

            Session?.SetJson("CartAkNotaDebitKreditDiterima", this);
        }

        public override void RemoveItemObjek(int jKWPTJBahagianId, int akCartaId)
        {
            base.RemoveItemObjek(jKWPTJBahagianId, akCartaId);
            Session?.SetJson("CartAkNotaDebitKreditDiterima", this);
        }

        public override void ClearObjek()
        {
            base.ClearObjek();
            Session?.Remove("CartAkNotaDebitKreditDiterima");
        }
        //

        //NotaDebitKreditDiterimaPerihal
        public override void AddItemPerihal(int akNotaDebitKreditDiterimaId, decimal bil, string? perihal, decimal kuantiti, int? lHDNKodKlasifikasiId, int? lHDNUnitUkuranId, string? unit, EnLHDNJenisCukai enLHDNJenisCukai, decimal kadarCukai, decimal amaunCukai, decimal harga, decimal amaun)
        {
            base.AddItemPerihal(akNotaDebitKreditDiterimaId, bil, perihal, kuantiti, lHDNKodKlasifikasiId, lHDNUnitUkuranId, unit, enLHDNJenisCukai, kadarCukai, amaunCukai, harga, amaun);
            Session?.SetJson("CartAkNotaDebitKreditDiterima", this);
        }

        public override void RemoveItemPerihal(decimal bil)
        {
            base.RemoveItemPerihal(bil);
            Session?.SetJson("CartAkNotaDebitKreditDiterima", this);
        }

        public override void ClearPerihal()
        {
            base.ClearPerihal();
            Session?.Remove("CartAkNotaDebitKreditDiterima");
        }
        //
    }
}
