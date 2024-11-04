using System.ComponentModel.DataAnnotations;

namespace SPMB_T.__Domain.Entities._Enums
{
    public enum EnKlasifikasiPerkhidmatan
    {
        [Display(Name = "Pengangkutan")]
        Pengangkutan = 1,
        [Display(Name = "Bakat dan Seni")]
        BakatDanSeni = 2,
        [Display(Name = "Sains")]
        Sains = 3,
        [Display(Name = "Pendidikan")]
        Pendidikan = 4,
        [Display(Name = "Ekonomi")]
        Ekonomi = 5,
        [Display(Name = "Sistem Maklumat")]
        SistemMaklumat = 6,
        [Display(Name = "Pertanian")]
        Pertanian = 7,
        [Display(Name = "Kemahiran")]
        Kemahiran = 8,
        [Display(Name = "Kejuruteraan")]
        Kejuruteraan = 9,
        [Display(Name = "Keselamatan dan Pertahanan Awam")]
        KeselamatanDanPertahananAwam = 10,
        [Display(Name = "Perundangan dan Kehakiman")]
        PerundanganDanKehakiman = 11,
        [Display(Name = "Tadbir dan Diplomatik")]
        TadbirDanDiplomatik = 12,
        [Display(Name = "Pentadbiran dan Sokongan")]
        PentadbiranDanSokongan = 13,
        [Display(Name = "Penyelidikan dan Pembangunan")]
        PenyelidikanDanPembangunan = 14,
        [Display(Name = "Sosial")]
        Sosial = 15,
        [Display(Name = "Perubatan dan Kesihatan")]
        PerubatanDanKesihatan = 16,
        [Display(Name = "Kewangan")]
        Kewangan = 17
    }
}