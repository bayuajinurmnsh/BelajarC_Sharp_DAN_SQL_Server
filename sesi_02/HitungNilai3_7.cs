using System;

namespace sesi_02
{
    class HitungNilai3_7
    {
        static void Main(string[] args)
        {
            int nilai1, nilai2 = 0;

            Console.Write("jumlah nilai1 = ");
            nilai1 = int.Parse(Console.ReadLine());
            Console.Write("jumlah nilai 2 = ");
            nilai2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nHasil perbandingan : ");
            Console.WriteLine($"nilai1 > nilai2 : {nilai1 > nilai2}");
            Console.WriteLine($"nilai1 >= nilai2 : {nilai1 >= nilai2}");
            Console.WriteLine($"nilai1 < nilai2 : {nilai1 < nilai2}");
            Console.WriteLine($"nilai1 <= nilai2 : {nilai1 <= nilai2}");
            Console.WriteLine($"nilai1 == nilai2 : {nilai1 == nilai2}");
            Console.WriteLine($"nilai1 != nilai2 : {nilai1 != nilai2}\n");
            
        }
    }
}