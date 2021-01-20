using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //kategoriEtiketi değer tutucu
            string kategoriEtiketi = "kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYaptiMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Oku");
            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış oku");
            }
            else
            {
                Console.WriteLine("eşit oku");
            }

            if(sistemeGirisYaptiMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap..");
            }

            Console.WriteLine(kategoriEtiketi);



        }
    }
}
