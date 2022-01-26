using System;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirme Kampı";
            string kurs2 = "Proglamaya Giriş Kursu";
            string kurs3 = "Java Kampı";

            //çok fazla değişken old. bunlar değişkenlerde tutulmaz. Array'lerde tutulur.
            //Array = Dizi

            string[] kurslar = new string[] { "Yazılım Geliştirme Kampı", "Proglamaya Giriş Kursu", "Java Kampı","C#" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]); 
            }

           //kurs yazmamızınsebebi dizideki her bir elemana takma ad veriyoruz. Kurs yerine herhangi bir şey de yazılabilirdi.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

        }
    }
}
