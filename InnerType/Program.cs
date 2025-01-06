using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();

            musteri.MusteriID = 1;
            musteri.tcKimlikNumarasi = "12345678901";
            musteri.isim = "Halil";
            musteri.soyisim = "Özcan";
            musteri.olusturmaTarihi = DateTime.Now;

            musteri.musteriAdresListe[0] = new MusteriAdres()
            {
                il = "Gaziantep",
                ilce = "Şehitkamil",
                adres = "adres ...",
                adresTip = "İş Yeri"

            };

            musteri.musteriAdresListe[0].MusteriAdresTestMetot();

            musteri.musteriSiparisBilgisisListe[0] = new MusteriSiparisBilgisi()
            {
                siparisNumarasi = "SIP00001"
            };

            musteri.musteriSiparisBilgisisListe[0].urunler[0] = new Urun()
            {
                urunId = 1,
                tanim = "Telefon",
                fiyat = 25000
            };

        }
    }
}
