using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    internal class MusteriAdres
    {
        public string  adresTip { get; set; }
        public string  il { get; set; }
        public string ilce { get; set; }
        public string adres { get; set; }

        public MusteriAdres()
        {
            Console.WriteLine("Musteri Adres Yapıcı Metot Çalıştı");
        }

        public void MusteriAdresTestMetot()
        {
            Console.WriteLine("Mutseri Adres Test Metot");
        }
    }
}
