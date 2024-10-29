# TeknolojiMagazası Projesi

TeknolojiMagazası, kullanıcıların telefon ve bilgisayar gibi teknolojik ürünleri oluşturmasına olanak tanıyan bir konsol uygulamasıdır. Kullanıcı, ürün bilgilerini girdikten sonra uygulama, oluşturulan ürünle ilgili bilgileri ekrana yazdırır. Bu proje, C# dilinde geliştirilmiştir ve .NET platformunda çalışmaktadır.

## İçindekiler

- [Proje Tanımı](#proje-tanımı)
- [Özellikler](#özellikler)
- [Gereksinimler](#gereksinimler)
- [Kurulum](#kurulum)
- [Kullanım](#kullanım)
- [Kod Yapısı](#kod-yapısı)
  - [Sınıflar](#sınıflar)
  - [Metotlar](#metotlar)
- [Hata Ayıklama](#hata-ayıklama)

## Proje Tanımı

Bu proje, kullanıcıların telefon ve bilgisayar üretme sürecini simüle eden bir uygulamadır. Kullanıcı, ürünlerin temel bilgilerini girer ve uygulama bu bilgileri saklar, ardından kullanıcıya yazdırır.

## Özellikler

- Kullanıcı dostu konsol arayüzü
- Telefon ve bilgisayar üretimi
- Ürün bilgileri için kullanıcıdan giriş alma
- Ürün bilgilerini konsolda yazdırma
- TR lisansı durumu ve Bluetooth gibi özel özellikler
- Üretim tarihini otomatik olarak atama

## Gereksinimler

- **Yazılım Gereksinimleri**:
  - .NET SDK (3.1 veya üzeri)
  - Bir metin editörü veya IDE (Visual Studio, Visual Studio Code, Rider vb.)

- **Donanım Gereksinimleri**:
  - Minimum 4 GB RAM
  - İşletim sistemi olarak Windows, macOS veya Linux

## Kurulum

1. **Projeyi Klonlayın**:
   ```bash
   git clone https://github.com/kullaniciadi/TeknolojiMagazasi.git
   cd TeknolojiMagazasi
   ```

2. **Gerekli Bağımlılıkları Yükleyin**:
   Bağımlılıklar otomatik olarak yüklenecektir. Eğer elle yüklemeniz gerekiyorsa:
   ```bash
   dotnet restore
   ```

3. **Projeyi Çalıştırın**:
   ```bash
   dotnet run
   ```

## Kullanım

1. Uygulama başlatıldığında, kullanıcıdan telefon üretmek için `1` veya bilgisayar üretmek için `2` tuşlaması istenir.
2. Seçim yapıldıktan sonra, kullanıcıdan ilgili ürün bilgileri istenir:
   - **Telefon için**:
     - Seri Numarası
     - Ürün Adı
     - Açıklama
     - İşletim Sistemi
     - TR Lisanslı (true/false)
   - **Bilgisayar için**:
     - Seri Numarası
     - Ürün Adı
     - Açıklama
     - İşletim Sistemi
     - USB Giriş Sayısı (2 veya 4)
     - Bluetooth (true/false)
3. Kullanıcı tüm bilgileri girdikten sonra, uygulama bu bilgileri ekrana yazdırır.
4. Kullanıcı, başka bir ürün üretmek isteyip istemediğini belirtir. İsterse uygulama yeniden başlar.
5. Geçersiz bir seçim yapılırsa, kullanıcı bilgilendirilir ve tekrar seçim yapması istenir.

## Kod Yapısı

### Sınıflar

- **BaseMakine**: Ürünler için ortak özellikleri ve metotları tanımlar.
  - `ProduceDate`: Üretim tarihi, otomatik olarak atanır.
  - `SerialNumber`: Seri numarası, kullanıcı tarafından girilir.
  - `ProductName`: Ürün adı, kullanıcı tarafından girilir.
  - `Description`: Ürün açıklaması, kullanıcı tarafından girilir.
  - `OperatingSystem`: İşletim sistemi, kullanıcı tarafından girilir.
  - `BilgileriYazdir()`: Ortak bilgileri yazdıran metot.
  - `UrunAdiGetir()`: Soyut metot, alt sınıflar tarafından uygulanması zorunludur.

- **Telefon**: BaseMakine sınıfından miras alır ve telefonla ilgili ek özellikler içerir.
  - `TrLisansli`: TR lisans durumu, kullanıcı tarafından girilir.
  - `BilgileriYazdir()`: Telefon bilgilerini yazdırır.
  - `UrunAdiGetir()`: Telefonun adını döndürür.

- **Bilgisayar**: BaseMakine sınıfından miras alır ve bilgisayarla ilgili ek özellikler içerir.
  - `UsbGirisSayisi`: USB giriş sayısı, kullanıcı tarafından girilir (sadece 2 veya 4).
  - `Bluetooth`: Bluetooth durumu, kullanıcı tarafından girilir.
  - `BilgileriYazdir()`: Bilgisayar bilgilerini yazdırır.
  - `UrunAdiGetir()`: Bilgisayarın adını döndürür.

- **Program**: Uygulamanın giriş noktasıdır ve kullanıcı etkileşimini yönetir.

### Metotlar

- `BilgileriYazdir()`: Ürün bilgilerini ekrana yazdırmak için kullanılır.
- `UrunAdiGetir()`: Ürün adını almak için kullanılır.

## Hata Ayıklama

Eğer uygulamanız çalışmıyorsa veya beklenmeyen bir hata alıyorsanız, aşağıdaki adımları izleyin:

1. **Hata Mesajlarını Kontrol Edin**: Konsolda görünen hata mesajlarını dikkatlice okuyun.
2. **Gerekli Bağımlılıkları Yükleyin**: .NET SDK'nın yüklü olduğundan emin olun.
3. **Kodu Gözden Geçirin**: Herhangi bir sözdizim hatası veya mantıksal hata olup olmadığını kontrol edin.
4. **GitHub İssues**: Hala sorun yaşıyorsanız, proje sayfasındaki "Issues" sekmesine bakın veya yeni bir sorun bildirin.
