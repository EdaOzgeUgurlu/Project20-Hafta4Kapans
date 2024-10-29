using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknolojiMagazasi
{
    // Bilgisayar sınıfı, BaseMakine sınıfından miras alır
    public class Bilgisayar : BaseMakine
    {
        private int usbGirisSayisi; // USB giriş sayısı

        // USB giriş sayısını kontrol eden özellik
        public int UsbGirisSayisi
        {
            get { return usbGirisSayisi; } // USB giriş sayısını döndür
            set
            {
                // Değer 2 veya 4 ise atanır, aksi halde hata mesajı verir
                if (value == 2 || value == 4)
                {
                    usbGirisSayisi = value; // Geçerli değer
                }
                else
                {
                    Console.WriteLine("USB giriş sayısı yalnızca 2 veya 4 olabilir. -1 atanıyor.");
                    usbGirisSayisi = -1; // Geçersiz değer
                }
            }
        }

        // Bluetooth özelliği
        public bool Bluetooth { get; set; } // Bluetooth olup olmama durumu

        // Bilgileri yazdıran metot, üst sınıftan miras alınan özellikleri de yazdırır
        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir(); // Ortak bilgileri yazdır
            // Bilgisayarın özel bilgilerini yazdır
            Console.WriteLine($"USB Giriş Sayısı: {UsbGirisSayisi}");
            Console.WriteLine($"Bluetooth: {Bluetooth}");
        }

        // Ürün adını döndüren metot
        public override void UrunAdiGetir()
        {
            // Bilgisayarın adını konsola yazdır
            Console.WriteLine($"Bilgisayarınızın adı ---> {ProductName}");
        }
    }
}