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
    public class SessionCartAkPelarasanPO : CartAkPelarasanPO
    {
        public static CartAkPelarasanPO GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext!.Session!;
            SessionCartAkPelarasanPO cart = session?.GetJson<SessionCartAkPelarasanPO>("CartAkPelarasanPO") ?? new SessionCartAkPelarasanPO();
            cart.Session = session;
            return cart;
        }
        private ISession? Session { get; set; }

        // AkPelarasanPOObjek
        public override void AddItemObjek(int akPOId, int jKWPTJBahagianId, int akCartaId, decimal amaun)
        {
            base.AddItemObjek(akPOId, jKWPTJBahagianId, akCartaId, amaun);

            Session?.SetJson("CartAkPelarasanPO", this);
        }

        public override void RemoveItemObjek(int jKWPTJBahagianId, int akCartaId)
        {
            base.RemoveItemObjek(jKWPTJBahagianId, akCartaId);
            Session?.SetJson("CartAkPelarasanPO", this);
        }

        public override void ClearObjek()
        {
            base.ClearObjek();
            Session?.Remove("CartAkPelarasanPO");
        }
        //

        // AkPelarasanPOPerihal
        public override void AddItemPerihal(int akPelarasanPOId, decimal bil, string? perihal, decimal kuantiti, int? lHDNKodKlasifikasiId, int? lHDNUnitUkuranId, string? unit, EnLHDNJenisCukai enLHDNJenisCukai, decimal kadarCukai, decimal amaunCukai, decimal harga, decimal amaun)
        {
            base.AddItemPerihal(akPelarasanPOId, bil, perihal, kuantiti, lHDNKodKlasifikasiId, lHDNUnitUkuranId, unit, enLHDNJenisCukai, kadarCukai, amaunCukai, harga, amaun);
            Session?.SetJson("CartAkPelarasanPO", this);
        }

        public override void RemoveItemPerihal(decimal bil)
        {
            base.RemoveItemPerihal(bil);
            Session?.SetJson("CartAkPelarasanPO", this);
        }

        public override void ClearPerihal()
        {
            base.ClearPerihal();
            Session?.Remove("CartAkPelarasanPO");
        }
        //
    }
}
