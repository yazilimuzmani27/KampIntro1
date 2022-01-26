using System;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 86;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Ahmet";
            kurs2.IzlenmeOrani = 68;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Mehmet";
            kurs3.IzlenmeOrani = 96;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);
            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };
            foreach (var kurs in kurslar)
            {


                Console.WriteLine(kurs.KursAdi);
            }
            
        }
    }
    class Kurs
    {
        public int IzlenmeOrani { get; set; }
        public string Egitmen { get; set; }
        public string KursAdi { get; set; }



    }
}
