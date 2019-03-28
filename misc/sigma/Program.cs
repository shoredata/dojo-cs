using System;

namespace sigma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sigma: ");
            int result=0;

            for (int idx = 1; idx<=int.Parse(args[0]); idx++)
            {
                result += idx;
            }
            Console.WriteLine(result);
        }
    }
}
