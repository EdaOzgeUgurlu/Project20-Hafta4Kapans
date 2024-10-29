using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknolojiMagazasi
{
    // BaseMakine sınıfı, ortak özellikleri ve metotları tanımlar.
    public abstract class BaseMakine
    {
        // Üretim tarihi
        public DateTime ProduceDate { get; protected set; }
        // Seri numarası
        public string SerialNumber { get; set; }
        // Ürün adı
        public string ProductName { get; set; }
        // Ürün açıklaması
        public string Description { get; set; }
        // İşletim sistemi
        public string OperatingSystem { get; set; }

        // Ortak bilgileri yazdıran metot
        public virtual void BilgileriYazdir()
        {
            Console.WriteLine($"Üretim Tarihi: {ProduceDate}"); // Üretim tarihini yazdır
            Console.WriteLine($"Seri Numarası: {SerialNumber}"); // Seri numarasını yazdır
            Console.WriteLine($"Ürün Adı: {ProductName}"); // Ürün adını yazdır
            Console.WriteLine($"Açıklama: {Description}"); // Açıklamayı yazdır
            Console.WriteLine($"İşletim Sistemi: {OperatingSystem}"); // İşletim sistemini yazdır
        }

        // Soyut metot: Ürün adı getirme, alt sınıflarda uygulanması zorunludur
        public abstract void UrunAdiGetir();

        // Constructor: Üretim tarihini otomatik olarak atar
        protected BaseMakine()
        {
            ProduceDate = DateTime.Now; // Üretim tarihi, nesne oluşturulurken şu anki tarih olarak atanır
        }
    }
}