namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 30001);
            Console.WriteLine(i>>5);
            Console.WriteLine(i= i * -1);
        }
    }
}
