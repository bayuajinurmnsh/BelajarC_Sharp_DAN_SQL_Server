using System;

namespace sesi_03
{
    class Code_3
    {
        static void Main(string[] args)
        {
            string username;
            string password;
            bool UNameTrue;
            bool passTrue;
            do{
                Console.Write("Masukkan Username : ");
                username = Console.ReadLine();

                Console.Write("Masukkan Password : ");
                password = Console.ReadLine();

                UNameTrue = username == "bayu";
                passTrue  = password == "ocbc";

                if(UNameTrue && passTrue)
                {
                    Console.WriteLine("Anda berhasil login");
                }
                else
                {
                    Console.WriteLine("Try again !\n");
                }

            }while(UNameTrue != true || passTrue != true);
        }
    }
}