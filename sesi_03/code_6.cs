using System;

namespace sesi_03
{
    class Logic_7
    {
        static void Main(string[] args)
        {
            int batas;

            Console.Write("Masukkan batas looping : ");
            batas = int.Parse(Console.ReadLine());

            for(int i = 1; i <= batas; i++)
            {
                Console.WriteLine($"Iterasi ke {i}");
            }
        }
    }
}