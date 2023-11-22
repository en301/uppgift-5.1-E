using System;

namespace upggift_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in 5 namn");

            string[] namn = new string[5];
            for (int i = 0; i < 5; i++)
            {
                namn[i] = Console.ReadLine();
            }
            for (int j = 0;j  < 5;j++)
            {
                Console.WriteLine(namn[j]);
            }
            Console.ReadKey();
        }
    }
}
