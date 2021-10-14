using System;

namespace sesi_02
{
    class belajarString_4
    {
        static void Main(string[] args)
        {
            string nama;
            int umur;

            Console.WriteLine("=== PROGRAM PENDAFTARAN PENDUDUK ===");
            Console.Write("Masukkan Nama : ");
            nama = Console.ReadLine();

            Console.Write("Masukkan alamat : ");
            var alamat = Console.ReadLine();

            Console.Write("Masukkan Umur : ");
            umur = int.Parse(Console.ReadLine());

            Console.WriteLine("\nTerimakasih");
            Console.WriteLine("Data Berikut");
            Console.WriteLine($"Nama : {nama}");
            Console.WriteLine($"Alamat : {alamat}");
            Console.WriteLine($"Umur : {umur} tahun");
            Console.WriteLine($"Data sudah disimpan");
        }
    }
}