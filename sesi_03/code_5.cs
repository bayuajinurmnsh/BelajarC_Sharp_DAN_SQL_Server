using System;

namespace sesi_03
{
    class Logic_6
    {
        static void Main(string[] args)
        {
            int a;

            Console.Write("Masukkan nilai : ");
            a = int.Parse(Console.ReadLine());

            while(a <= 20)
            {
                Console.WriteLine("Nilai a sekarang : "+a);
                a +=1;
            }
        }
    }
}