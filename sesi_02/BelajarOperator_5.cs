using System;

namespace sesi_02
{
    class belajarOperator_5
    {
        static void Main(string[] args)
        {
            int pertama, kedua, ketiga, total;
            double rata;

            Console.WriteLine("=== Menghitung Nilai ===");
            Console.Write("Masukkan nilai pertama : ");
            pertama = int.Parse(Console.ReadLine());

            Console.Write("Masukkan nilai kedua : ");
            kedua = int.Parse(Console.ReadLine());

            Console.Write("Masukkan nilai ketiga : ");
            ketiga = int.Parse(Console.ReadLine());

            total = pertama + kedua + ketiga;
            rata = total / 3.0;

            Console.WriteLine("Total nilai adalah "+total);
            Console.WriteLine("Rata - rata nilai adalah "+rata);
            Console.Read();
        }
    }
}