using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Adres
    {
        public string Cadde { get; set; } // Cadde/Sokak bilgisi
        public string Mahalle { get; set; } // Mahalle bilgisi
        public string Ilce { get; set; } // İlçe bilgisi
        public string Sehir { get; set; } // Şehir bilgisi
        public string PostaKodu { get; set; } // Posta Kodu
        public string Ulke { get; set; } // Ülke bilgisi
    }
}
