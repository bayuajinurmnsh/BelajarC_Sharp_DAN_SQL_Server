using System;

namespace sesi_02
{
    class HitungNilai4_8
    {
        public static void Main(String[] args)
        {
            Console.Write("\nEnter your name  : ");
            string name = Console.ReadLine();

            Console.Write("Enter Your age   : ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Your Password    : ");
            string pass = Console.ReadLine();
            pass = pass.ToLower();

            bool isAdult = age > 18;
            bool isPassword = pass == "ocbc";

            if(isAdult && isPassword)
            {
                Console.WriteLine($"Welcome to the club {name}\n");
            }
            else
            {
                Console.WriteLine($"Sorry {name}!, you still a bocil\n");
            }
        }

    }
}