using System.Security.Cryptography.X509Certificates;

namespace pz_5
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("1 задание");
            for (int i = 30; i <= 120; i+= 3)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("3 задание");
            int n = 6;
            int m = 4;

            for (int i = 0; i < m; i++)
            {
                for (int x = 0; x < n; x++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }

            Console.WriteLine("4 задание");
            int y = 0;
            for (int i = 0; i < 100; i++)
            {
                if (y == i%7)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("5 задание");
            for (int i = 4, j = 50; j - i !=12; i++, j--)
            {
                Console.WriteLine(i + "    " + j);
            }


        }
    }
}