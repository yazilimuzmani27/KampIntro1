using System;

namespace Metotlar1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string UrunAdi = "Elma";
            double Fiyati = 15;
            string Aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            Product1 urun1 = new Product1();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Product1 urun2 = new Product1();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "diyarnakır karpuzu";
            urun2.StokAdedi = 11;

            Product1[] product = new Product1[] {urun1,urun2 };
            foreach (Product1 urunler in product)
            {
                Console.WriteLine(urunler.Adi);
                Console.WriteLine(urunler.Fiyati);
                Console.WriteLine(urunler.Aciklama);
                Console.WriteLine(urunler.StokAdedi);
                Console.WriteLine("----------------------");
            }
            Console.WriteLine("-----------------Metotlar----------");

            SepetManager1 sepetManager = new SepetManager1();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            Console.WriteLine("---------------------------------------------------------------");

            sepetManager.Ekle2("elma" , "Yeşil Elma" , 15);
            sepetManager.Ekle2("armut", "Yeşil armut", 12);
            sepetManager.Ekle2("karpuz", "diyarbakır karpuzu", 80);


        }
    }
}


//Tekrar tekrar kullanılabilirliği sağlayan yapılardır METOTLAR...