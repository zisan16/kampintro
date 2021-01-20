using System;
using System.Collections.Generic;
using System.Text;

namespace Methodlar
{
    class sepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi :" +urun.Adi);
        }
        public void Ekle2(string adi, string aciklama, double fiyat, int StokAdedi)
        {
            Console.WriteLine("tebrikler sepete eklendi :" + adi);
        }
    }
}
