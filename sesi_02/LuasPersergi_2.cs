using System;

namespace sesi_02
{
    class LuasPersegi_2
    {
        static void Main(string[] args)
        {
            float panjang, lebar;
            float luas, keliling;
            
            Console.WriteLine("\nMenghitung Luas Persegi Panjang");
            Console.Write("Masukkan panjang     : ");
            panjang = float.Parse(Console.ReadLine());

            Console.Write("Masukkan lebar       : ");
            lebar = float.Parse(Console.ReadLine());

            luas = panjang * lebar ;
            keliling = 2 * (panjang+lebar);

            Console.WriteLine("Keliling persegi panjang adalah "+keliling);
            Console.WriteLine("Luas persegi panjang adalah "+luas+"\n");
        }
    }
}