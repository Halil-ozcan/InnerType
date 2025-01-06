using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    internal class MusteriIletisimBilgisi
    {
        public int iletisimTip { get; set; }

        public string alanKodu { get; set; }
        public string numara { get; set; }
        public bool aktifPasif { get; set; }

        public void MusteriIletisimBilgisiTestMetot()
        {
            Console.WriteLine("Musteri İletişim Bilgileri Test Metot");
        }
    }
}
