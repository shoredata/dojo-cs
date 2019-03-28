using System;

namespace FirstCSConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable to interpolate
            string place = "Coding Dojo";
            //Interpolated string, note the $
            string message = $"Hello {place}";
            // Displaying final message
            Console.WriteLine(message);        

            Random rand = new Random();
            for(int val = 1; val <= 10; val++)
            {
                //Prints the next random value between 2 and 8
                Console.WriteLine("Random .. {0} of {1}: {2}", val, 10, rand.Next(2,8));
            }


        }
    }
}
