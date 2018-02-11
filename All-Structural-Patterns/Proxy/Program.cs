
using System;

namespace Proxy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IImage image1 = new ProxyImage("HiRes_10MB_Photo1");
            IImage image2 = new ProxyImage("HiRes_20MB_Photo2");
            // выполняется загрузка
            image1.Display();
            // загрузка не выполняется
            image1.Display();
            // выполняется загрузка
            image2.Display();
            // загрузка не выполняется
            image2.Display();
            // загрузка не выполняется
            image1.Display();

            Console.ReadLine();
        }
    }
}