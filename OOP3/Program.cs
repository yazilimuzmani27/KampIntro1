using System;
using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasıtKrediManager = new TasıtKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            
            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileBaseLoggerService(); 


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager , databaseLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasıtKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
