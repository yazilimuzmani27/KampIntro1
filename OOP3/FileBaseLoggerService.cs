﻿using System;

namespace OOP3
{
    internal class FileBaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya Loglandı");
        }
    }
}
