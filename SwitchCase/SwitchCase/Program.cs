namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Komutlar: Git, Dur.");
                Console.WriteLine("Bir komut giriniz:");
                string komut = Console.ReadLine().ToLower().Trim();
                switch (komut)
                {
                    case "git":
                        Console.WriteLine("Yeşil Işık");
                        Console.WriteLine("");
                        break;
                    case "dur":
                        Console.WriteLine("Kırmızı Işık");
                        Console.WriteLine("");
                        break;
                    default:
                        Console.WriteLine("Yanlış Komut");
                        Console.WriteLine("");
                        break;
                }
            }
            
        }
    }
}
