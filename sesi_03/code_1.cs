using System;

namespace sesi_03
{
    class Code_1
    {
        static void Main(string[] args)
        {
            int a,b;
            do{
                
                Console.Write("Masukkan nilai a : ");
                a = int.Parse(Console.ReadLine());

                Console.Write("Masukkan nilai b : ");
                b = int.Parse(Console.ReadLine());

                if(a > b)
                {
                    Console.WriteLine(" a lebih besar dari b, nilai benar");
                }
                else if(a == b)
                {
                    Console.WriteLine(" a sama dengan b, nilai benar");
                }
                else{
                    Console.WriteLine(" Try Again \n");
                }
            }
            while (a < b);
        }
    }
}