﻿using SPMB_T.__Domain.Entities._Enums;
using SPMB_T.__Domain.Entities.Models._03Akaun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T._DataAccess.Services.Cart
{
    public class CartAkTerima
    {
        //TerimaObjek

        private List<AkTerimaObjek> collectionObjek = new List<AkTerimaObjek>();

        public virtual void AddItemObjek(
            int akTerimaId,
            int jKWPTJBahagianId,
            int akCartaId,
            decimal amaun
            )
        {
            AkTerimaObjek line = collectionObjek.FirstOrDefault(p => p.JKWPTJBahagianId == jKWPTJBahagianId && p.AkCartaId == akCartaId)!;

            if (line == null)
            {
                collectionObjek.Add(new AkTerimaObjek
                {
                    AkTerimaId = akTerimaId,
                    JKWPTJBahagianId = jKWPTJBahagianId,
                    AkCartaId = akCartaId,
                    Amaun = amaun
                });
            }
        }

        public virtual void RemoveItemObjek(int jKWPTJBahagianId, int akCartaId) =>
            collectionObjek.RemoveAll(l => l.AkCartaId == akCartaId && l.JKWPTJBahagianId == jKWPTJBahagianId);


        public virtual void ClearObjek() => collectionObjek.Clear();

        public virtual IEnumerable<AkTerimaObjek> AkTerimaObjek => collectionObjek;

        //TerimaCaraBayar

        private List<AkTerimaCaraBayar> collectionCaraBayar = new List<AkTerimaCaraBayar>();

        public virtual void AddItemCaraBayar(
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
            AkTerimaCaraBayar line = collectionCaraBayar.FirstOrDefault(p => p.JCaraBayarId == jCaraBayarId)!;

            if (line == null)
            {
                collectionCaraBayar.Add(new AkTerimaCaraBayar
                {
                    AkTerimaId = akTerimaId,
                    JCaraBayarId = jCaraBayarId,
                    Amaun = amaun,
                    NoCekMK = noCekMK,
                    EnJenisCek = enJenisCek,
                    KodBankCek = kodBankCek,
                    TempatCek = tempatCek,
                    NoSlip = noSlip,
                    TarikhSlip = tarikhSlip

                });
            }
        }

        public virtual void RemoveItemCaraBayar(int jCaraBayarId) =>
            collectionCaraBayar.RemoveAll(l => l.JCaraBayarId == jCaraBayarId);


        public virtual void ClearCaraBayar() => collectionCaraBayar.Clear();

        public virtual IEnumerable<AkTerimaCaraBayar> AkTerimaCaraBayar => collectionCaraBayar;

        //TerimaInvois

        private List<AkTerimaInvois> collectionInvois = new List<AkTerimaInvois>();

        public virtual void AddItemInvois(
            int akTerimaId,
            int akInvoisId,
            decimal amaun
            )
        {
            AkTerimaInvois line = collectionInvois.FirstOrDefault(p => p.AkInvoisId == akInvoisId)!;

            if (line == null)
            {
                collectionInvois.Add(new AkTerimaInvois
                {
                    AkTerimaId = akTerimaId,
                    AkInvoisId = akInvoisId,
                    Amaun = amaun
                });
            }
        }

        public virtual void RemoveItemInvois(int akInvoisId) =>
            collectionInvois.RemoveAll(l => l.AkInvoisId == akInvoisId);


        public virtual void ClearInvois() => collectionInvois.Clear();

        public virtual IEnumerable<AkTerimaInvois> AkTerimaInvois => collectionInvois;
    }
}
