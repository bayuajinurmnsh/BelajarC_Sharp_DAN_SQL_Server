using System;

namespace sesi_02
{
    class Program_1
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("\nHello World");
            Console.WriteLine("Hello Bayu Aji Nurmansah");
            Console.WriteLine("Selamat Datang di Program Bootcamp OCBC");
            Console.WriteLine("Tahap 1 saya akan belajar C# \n");

            int jumlahSemuaBarang;
            string namaCustomer = "Foxi";
            int harga1=10, harga2=20, harga3=30;
            int jumlah1 = 5, jumlah2=10, jumlah3=15;
            int barang1, barang2, barang3, total;

            barang1 = jumlah1*harga1;
            barang2 = jumlah2*harga2;
            barang3 = jumlah3*harga3;

            total = barang1+barang2+barang3;
            jumlahSemuaBarang = jumlah1+jumlah2+jumlah3;

            Console.WriteLine("Nama Customer    : "+namaCustomer);
            Console.WriteLine(namaCustomer+" Membeli barang 1 dengan jumlah "+jumlah1+" dengan harga dasar "+harga1+ " yang harus dibayar = "+barang1);
            Console.WriteLine(namaCustomer+" Membeli barang 2 dengan jumlah "+jumlah2+" dengan harga dasar "+harga2+ " yang harus dibayar = "+barang2);
            Console.WriteLine(namaCustomer+" Membeli barang 3 dengan jumlah "+jumlah3+" dengan harga dasar "+harga3+ " yang harus dibayar = "+barang3+"\n");

            Console.WriteLine("Total harga semua barang adalah "+total);
            Console.WriteLine("Jumlah semua barang adalah "+jumlahSemuaBarang+"\n");

        }
    }
}
