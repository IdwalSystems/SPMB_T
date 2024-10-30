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
    public class SessionCartAkInden : CartAkInden
    {
        public static CartAkInden GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext!.Session!;
            SessionCartAkInden cart = session?.GetJson<SessionCartAkInden>("CartAkInden") ?? new SessionCartAkInden();
            cart.Session = session;
            return cart;
        }
        private ISession? Session { get; set; }

        // IndenObjek
        public override void AddItemObjek(int akIndenId, int jKWPTJBahagianId, int akCartaId, decimal amaun)
        {
            base.AddItemObjek(akIndenId, jKWPTJBahagianId, akCartaId, amaun);

            Session?.SetJson("CartAkInden", this);
        }

        public override void RemoveItemObjek(int jKWPTJBahagianId, int akCartaId)
        {
            base.RemoveItemObjek(jKWPTJBahagianId, akCartaId);
            Session?.SetJson("CartAkInden", this);
        }

        public override void ClearObjek()
        {
            base.ClearObjek();
            Session?.Remove("CartAkInden");
        }
        //

        //IndenPerihal
        public override void AddItemPerihal(int akIndenId, decimal bil, string? perihal, decimal kuantiti, int? lHDNKodKlasifikasiId, int? lHDNUnitUkuranId, string? unit, EnLHDNJenisCukai enLHDNJenisCukai, decimal kadarCukai, decimal amaunCukai, decimal harga, decimal amaun)
        {
            base.AddItemPerihal(akIndenId, bil, perihal, kuantiti, lHDNKodKlasifikasiId, lHDNUnitUkuranId, unit, enLHDNJenisCukai, kadarCukai, amaunCukai, harga, amaun);
            Session?.SetJson("CartAkInden", this);
        }

        public override void RemoveItemPerihal(decimal bil)
        {
            base.RemoveItemPerihal(bil);
            Session?.SetJson("CartAkInden", this);
        }

        public override void ClearPerihal()
        {
            base.ClearPerihal();
            Session?.Remove("CartAkInden");
        }
        //
    }
}
