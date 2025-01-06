using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    internal class Musteri
    {
        // Tekil olarak kullanılan field;
        public int MusteriID{ get; set; }
        public string  tcKimlikNumarasi{ get; set; }
        public string isim{ get; set; }
        public string soyisim{ get; set; }

        public DateTime olusturmaTarihi { get; set; }

        public int kullaniciId { get; set; }


        // InerType gerektiren Fieldler

        public MusteriAdres[] musteriAdresListe;

        public MusteriIletisimBilgisi[] musteriIletisimBilgisiListe;

        public MusteriSiparisBilgisi[] musteriSiparisBilgisisListe;

        public Musteri()
        {
            musteriAdresListe = new MusteriAdres[5];
            musteriIletisimBilgisiListe = new MusteriIletisimBilgisi[3];
            musteriSiparisBilgisisListe = new MusteriSiparisBilgisi[10];
        }

    }
}
