using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknolojiMagazasi
{
    // Telefon sınıfı, BaseMakine sınıfından miras alır
    public class Telefon : BaseMakine
    {
        // TR lisanslı olup olmama durumunu temsil eden özellik
        public bool TrLisansli { get; set; }

        // Bilgileri yazdıran metot, üst sınıftan miras alınan özellikleri de yazdırır
        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir(); // Ortak bilgileri yazdır
            // Telefonun TR lisans durumu yazdırılır
            Console.WriteLine($"TR Lisanslı: {TrLisansli}");
        }

        // Ürün adını döndüren metot
        public override void UrunAdiGetir()
        {
            // Telefonun adını konsola yazdır
            Console.WriteLine($"Telefonunuzun adı ---> {ProductName}");
        }
    }
}