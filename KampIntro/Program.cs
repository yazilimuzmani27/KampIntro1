using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //don't repeat yourself
            string kategotiEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }

            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Stabil Butonu");
            }
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarlar Butonu");
            }
            else if (sistemeGirisYapmisMi == false)
            {
                Console.WriteLine( "Giriş Yapınız");
            }
            Console.WriteLine(kategotiEtiketi);
            Console.WriteLine(ogrenciSayisi);
            Console.WriteLine(faizOrani);

           


        }
    }
}
