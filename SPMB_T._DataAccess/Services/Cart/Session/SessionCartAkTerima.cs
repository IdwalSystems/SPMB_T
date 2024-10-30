﻿using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using SPMB_T.__Domain.Entities._Enums;
using SPMB_T.__Domain.Entities.Models._01Jadual;
using SPMB_T.__Domain.Entities.Models._03Akaun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T._DataAccess.Services.Cart.Session
{
    public class SessionCartAkTerima : CartAkTerima
    {
        public static CartAkTerima GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext!.Session!;
            SessionCartAkTerima cart = session?.GetJson<SessionCartAkTerima>("CartAkTerima") ?? new SessionCartAkTerima();
            cart.Session = session;
            return cart;
        }
        private ISession? Session { get; set; }

        //TerimaObjek
        public override void AddItemObjek(
            int akTerimaId,
            int jBahagianId,
            int akCartaId,
            decimal amaun
           )
        {
            base.AddItemObjek(akTerimaId,
                          jBahagianId,
                          akCartaId,
                          amaun);

            Session?.SetJson("CartAkTerima", this);
        }
        public override void RemoveItemObjek(int jBahagianId, int akCartaId)
        {
            base.RemoveItemObjek(jBahagianId, akCartaId);
            Session?.SetJson("CartAkTerima", this);
        }
        public override void ClearObjek()
        {
            base.ClearObjek();
            Session?.Remove("CartAkTerima");
        }
        //TerimaObjek End

        //TerimaCaraBayar
        public override void AddItemCaraBayar(
            int akTerimaId,
            int jCaraBayarId,
            decimal amaun,
            string? noCekMK,
            EnJenisCek enJenisCek,
            string? kodBankCek,
            string? tempatCek,
            string? noSlip,
        DateTime? tarikhSlip
           )
        {
            base.AddItemCaraBayar(
                    akTerimaId,
                    jCaraBayarId,
                    amaun,
                    noCekMK,
                    enJenisCek,
                    kodBankCek,
                    tempatCek,
                    noSlip,
                    tarikhSlip);

            Session?.SetJson("CartAkTerima", this);
        }
        public override void RemoveItemCaraBayar(
            int jCaraBayarId)
        {
            base.RemoveItemCaraBayar(jCaraBayarId);
            Session?.SetJson("CartAkTerima", this);
        }
        public override void ClearCaraBayar()
        {
            base.ClearCaraBayar();
            Session?.Remove("CartAkTerima");
        }
        //TerimaCaraBayar End

        //TerimaInvois
        public override void AddItemInvois(int akTerimaId, int akInvoisId, decimal amaun)
        {
            base.AddItemInvois(akTerimaId, akInvoisId, amaun);
            Session?.SetJson("CartAkTerima", this);
        }
        public override void RemoveItemInvois(int akInvoisId)
        {
            base.RemoveItemInvois(akInvoisId);
            Session?.SetJson("CartAkTerima", this);
        }
        public override void ClearInvois()
        {
            base.ClearInvois();
            Session?.Remove("CartAkTerima");
        }
        //TerimaInvois End

    }
}
