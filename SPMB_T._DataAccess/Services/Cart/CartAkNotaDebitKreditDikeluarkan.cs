﻿using SPMB_T.__Domain.Entities._Enums;
using SPMB_T.__Domain.Entities.Models._03Akaun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMB_T._DataAccess.Services.Cart
{
    public class CartAkNotaDebitKreditDikeluarkan
    {
        //NotaDebitKreditDikeluarkanObjek
        private List<AkNotaDebitKreditDikeluarkanObjek> collectionObjek = new List<AkNotaDebitKreditDikeluarkanObjek>();

        public virtual void AddItemObjek(
            int akNotaDebitKreditDikeluarkanId,
            int jKWPTJBahagianId,
            int akCartaId,
            decimal amaun
            )
        {
            AkNotaDebitKreditDikeluarkanObjek line = collectionObjek.FirstOrDefault(pp => pp.JKWPTJBahagianId == jKWPTJBahagianId && pp.AkCartaId == akCartaId)!;

            if (line == null)
            {
                collectionObjek.Add(new AkNotaDebitKreditDikeluarkanObjek()
                {
                    AkNotaDebitKreditDikeluarkanId = akNotaDebitKreditDikeluarkanId,
                    JKWPTJBahagianId = jKWPTJBahagianId,
                    AkCartaId = akCartaId,
                    Amaun = amaun
                });
            }
        }

        public virtual void RemoveItemObjek(int jKWPTJBahagianId, int akCartaId) => collectionObjek.RemoveAll(l => l.JKWPTJBahagianId == jKWPTJBahagianId && l.AkCartaId == akCartaId);

        public virtual void ClearObjek() => collectionObjek.Clear();

        public virtual IEnumerable<AkNotaDebitKreditDikeluarkanObjek> AkNotaDebitKreditDikeluarkanObjek => collectionObjek;
        //

        // NotaDebitKreditDikeluarkanPerihal

        private List<AkNotaDebitKreditDikeluarkanPerihal> collectionPerihal = new List<AkNotaDebitKreditDikeluarkanPerihal>();
        public virtual void AddItemPerihal(
            int akNotaDebitKreditDikeluarkanId,
            decimal bil,
            string? perihal,
            decimal kuantiti,
            int? lHDNKodKlasifikasiId,
            int? lHDNUnitUkuranId,
            string? unit,
            EnLHDNJenisCukai enLHDNJenisCukai,
            decimal kadarCukai,
            decimal amaunCukai,
            decimal harga,
            decimal amaun
            )
        {
            AkNotaDebitKreditDikeluarkanPerihal line = collectionPerihal.FirstOrDefault(pp => pp.Bil == bil)!;

            if (line == null)
            {
                amaunCukai = Math.PriceFormatter.GetTaxAmount(harga, kuantiti, kadarCukai);
                collectionPerihal.Add(new AkNotaDebitKreditDikeluarkanPerihal
                {
                    AkNotaDebitKreditDikeluarkanId = akNotaDebitKreditDikeluarkanId,
                    Bil = bil,
                    Perihal = perihal,
                    Kuantiti = kuantiti,
                    LHDNKodKlasifikasiId = lHDNKodKlasifikasiId,
                    LHDNUnitUkuranId = lHDNUnitUkuranId,
                    Unit = unit,
                    EnLHDNJenisCukai = enLHDNJenisCukai,
                    KadarCukai = kadarCukai,
                    AmaunCukai = amaunCukai,
                    Harga = harga,
                    Amaun = Math.PriceFormatter.GetTotalPayableAmount(harga, kuantiti, amaunCukai)


                });
            }
        }

        public virtual void RemoveItemPerihal(decimal bil) => collectionPerihal.RemoveAll(l => l.Bil == bil);

        public virtual void ClearPerihal() => collectionPerihal.Clear();

        public virtual IEnumerable<AkNotaDebitKreditDikeluarkanPerihal> AkNotaDebitKreditDikeluarkanPerihal => collectionPerihal;
        //
    }
}
