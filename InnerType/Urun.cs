using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    internal class Urun
    {
        public int urunId { get; set; }
        public string tanim { get; set; }
        public decimal fiyat { get; set; }

        public Urun()
        {
            Console.WriteLine("Urun Yapıcı Metot Çalıştı");
        }

        public void UrunTestMetot()
        {
            Console.WriteLine("Ürün Test Metot");
        }
    }
}
