using System;

namespace sesi_03
{
    class Code_2
    {
        static void Main(string[] args)
        {
            int nilai;
            string nama;
            Console.Write("Masukkan nama anda : ");
            nama = Console.ReadLine();
            do{
                
                Console.Write("Masukkan nilai : ");
                nilai = int.Parse(Console.ReadLine());

                if(nilai > 80)
                {
                    Console.WriteLine($" Selamat {nama}! Kamu dapat nilai A");
                }
                else if(nilai >=60 && nilai <=80)
                {
                    Console.WriteLine($" Selamat {nama}! Kamu dapat B, next time harus A ya!");
                }
                else{
                    Console.WriteLine($" Try Again {nama} \n");
                }
            }
            while (nilai < 60);
        }
    }
}