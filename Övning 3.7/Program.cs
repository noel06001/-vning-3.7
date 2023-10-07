using System;

namespace Övning_3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int ålder  = int.Parse(Console.ReadLine());

            if ((ålder >= 10 && ålder <=18) || ålder >= 65)
            {
                Console.WriteLine("Du får rabatt på kaffet.");
            }
            else
            {
                Console.WriteLine("Tyvärr så får du ingen rabatt på ditt kaffe.");
                Console.ReadKey();
            }
        }
    }
}
