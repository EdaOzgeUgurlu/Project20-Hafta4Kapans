using TeknolojiMagazasi;

// Ana program sınıfı
class Program
{
    // Programın giriş noktası
    static void Main(string[] args)
    {
        // Kullanıcının devam edip etmeyeceğini kontrol eder
        bool devam = true;

        // Kullanıcı devam ettiği sürece döngü devam eder
        while (devam)
        {
            // Kullanıcıdan telefon veya bilgisayar üretmek için seçim yapması istenir
            Console.WriteLine("Telefon üretmek için 1'e, Bilgisayar üretmek için 2'ye basınız.");
            string secim = Console.ReadLine();

            // Kullanıcının seçimi telefon üretimi ise
            if (secim == "1")
            {
                // Yeni bir Telefon nesnesi oluşturulur
                Telefon telefon = new Telefon();
                // Kullanıcıdan telefon bilgileri alınır
                Console.Write("Seri Numarası: ");
                telefon.SerialNumber = Console.ReadLine();
                Console.Write("Ürün Adı: ");
                telefon.ProductName = Console.ReadLine();
                Console.Write("Açıklama: ");
                telefon.Description = Console.ReadLine();
                Console.Write("İşletim Sistemi: ");
                telefon.OperatingSystem = Console.ReadLine();
                Console.Write("TR Lisanslı (true/false): ");
                telefon.TrLisansli = bool.Parse(Console.ReadLine());

                // Telefon bilgileri yazdırılır ve kullanıcıya bilgi verilir
                telefon.BilgileriYazdir();
                telefon.UrunAdiGetir();
                Console.WriteLine("Telefon başarıyla üretildi!");
            }
            // Kullanıcının seçimi bilgisayar üretimi ise
            else if (secim == "2")
            {
                // Yeni bir Bilgisayar nesnesi oluşturulur
                Bilgisayar bilgisayar = new Bilgisayar();
                // Kullanıcıdan bilgisayar bilgileri alınır
                Console.Write("Seri Numarası: ");
                bilgisayar.SerialNumber = Console.ReadLine();
                Console.Write("Ürün Adı: ");
                bilgisayar.ProductName = Console.ReadLine();
                Console.Write("Açıklama: ");
                bilgisayar.Description = Console.ReadLine();
                Console.Write("İşletim Sistemi: ");
                bilgisayar.OperatingSystem = Console.ReadLine();
                Console.Write("USB Giriş Sayısı (2 veya 4): ");
                bilgisayar.UsbGirisSayisi = int.Parse(Console.ReadLine());
                Console.Write("Bluetooth (true/false): ");
                bilgisayar.Bluetooth = bool.Parse(Console.ReadLine());

                // Bilgisayar bilgileri yazdırılır ve kullanıcıya bilgi verilir
                bilgisayar.BilgileriYazdir();
                bilgisayar.UrunAdiGetir();
                Console.WriteLine("Bilgisayar başarıyla üretildi!");
            }
            // Geçersiz seçim durumunda kullanıcı bilgilendirilir
            else
            {
                Console.WriteLine("Geçersiz seçim! Lütfen 1 veya 2 girin.");
                continue;
            }

            // Kullanıcıya başka bir ürün üretmek isteyip istemediği sorulur
            Console.Write("Başka bir ürün üretmek ister misiniz? (evet/hayır): ");
            string devamMi = Console.ReadLine().ToLower();
            devam = devamMi == "evet"; // Kullanıcının cevabına göre döngü devam eder
        }

        // Program sonlandığında kullanıcıya veda mesajı
        Console.WriteLine("İyi günler!");
    }
}