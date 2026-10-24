using System.Security.Cryptography.X509Certificates;

namespace Dongu
{
    internal class Program
    {
        public static int kacTaneBes, kacTaneUc;
        public static int sayi = 1;
        static void Main(string[] args)
        {
            for (int i = 1; i <= 1000; i++)
            {
                int ucKontrol = sayi % 3;
                int besKontrol = sayi % 5;
                if (ucKontrol == 0)
                {
                    kacTaneUc++;
                }
                if (besKontrol == 0)
                {
                    kacTaneBes++;
                }
                sayi++;
            }
            Console.WriteLine(kacTaneUc.ToString());
            Console.WriteLine(kacTaneBes.ToString());
        }
    }
}
