namespace pz_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double N, K, S;
            Console.WriteLine("введите N (N>0):");
            N = Convert.ToDouble(Console.ReadLine());
            K = 1;
            while (K <= N)
            {
                S = Math.Pow(2, K);
                if (S == N)
                Console.Write("{0}", K);               
                K++;
            }
            Console.Read();

                
        }
    }
}