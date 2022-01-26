using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar1
{
    internal class SepetManager1
    {
        //main convention
        public void Ekle(Product1 products)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi." + products.Adi);
        }
        public void Ekle2(string urunAdi,string aciklama , double fiyat)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi" + urunAdi);
        }
    }
}
