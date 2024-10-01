bool yeniTatil = true;

while (yeniTatil)
{
    // Lokasyon Seçimi
    string lokasyon = "";
    while (true)
    {
        Console.WriteLine("Merhaba ben Tatil Uygulaması Yol arkadaşın. Bodrum, Marmaris, Çeşme. Hangi lokasyona gitmek istersin?");
        lokasyon = Console.ReadLine().ToLower();

        if (lokasyon == "bodrum" || lokasyon == "marmaris" || lokasyon == "çeşme")
        {
            break;
        }
        else
        {
            Console.WriteLine("Hatalı giriş yaptınız. Lütfen Bodrum, Marmaris veya Çeşme yazınız.");
        }
    }

    // Paket fiyatları
    int lokasyonFiyati = 0;
    if (lokasyon == "bodrum") lokasyonFiyati = 4000;
    else if (lokasyon == "marmaris") lokasyonFiyati = 3000;
    else if (lokasyon == "çeşme") lokasyonFiyati = 5000;

    // Kişi Sayısı
    Console.WriteLine("Kaç kişi için tatil planlamak istiyorsunuz?");
    int kisiSayisi = int.Parse(Console.ReadLine());

    // Ulaşım Seçimi
    int ulasimFiyati = 0;
    while (true)
    {
        Console.WriteLine("Tatiline nasıl gitmek istiyorsunuz?");
        Console.WriteLine("1 - Kara yolu (Kişi başı gidiş-dönüş 1500 TL)");
        Console.WriteLine("2 - Hava yolu (Kişi başı gidiş-dönüş 4000 TL)");
        string ulasim = Console.ReadLine();

        if (ulasim == "1")
        {
            ulasimFiyati = 1500;
            break;
        }
        else if (ulasim == "2")
        {
            ulasimFiyati = 4000;
            break;
        }
        else
        {
            Console.WriteLine("Hatalı giriş yaptınız. Lütfen 1 veya 2 olarak seçim yapınız.");
        }
    }

    // Toplam fiyat hesaplama
    int toplamFiyat = (lokasyonFiyati + ulasimFiyati) * kisiSayisi;

    // Sonuçları yazdırma
    Console.WriteLine("\nTatil Özeti:");
    Console.WriteLine("Lokasyon: " + lokasyon);
    Console.WriteLine("Kişi Sayısı: " + kisiSayisi);
    Console.WriteLine("Toplam Tutar: " + toplamFiyat + " TL\n");

    // Başka bir tatil planlamak isteyip istemediği
    Console.WriteLine("Başka bir tatil planlamak istiyor musunuz? (E/H)");
    string devamMi = Console.ReadLine().ToLower();

    if (devamMi != "e")
    {
        Console.WriteLine("İyi günler dileriz!");
        yeniTatil = false;
    }
}
