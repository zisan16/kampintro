using System;

namespace Methodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            //type safe -- tip güvenliği
            Urun[] urunler = new Urun[] { urun1, urun2 };
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------");
            }
            Console.WriteLine("---------Metotlar");

            sepetManager sptManeger = new sepetManager();
            sptManeger.Ekle(urun1);
            sptManeger.Ekle(urun2);

            sptManeger.Ekle2("armut", "yeşil armut", 12, 10);
            sptManeger.Ekle2("armut", "sarı armut", 10, 8);

        }
    }
}
