using System;

namespace sesi_02
{
    class StudyCase
    {
        public static void Main(String[] args)
        {
            //biodata
            string username, password, sex;
            int umur;
            
            bool isMarriage = false;

            //aritmatika
            int pertama, kedua, ketiga, total;
            double rata;

            //biodata
            Console.Write("username : ");
            username = Console.ReadLine();

            Console.Write("Password : ");
            password = Console.ReadLine();

            Console.Write("Umur : ");
            umur = int.Parse(Console.ReadLine());
            
            Console.Write("Jenis kelamin : ");
            sex = Console.ReadLine();

            Console.WriteLine("=== Menghitung Nilai ===");
            Console.Write("Masukkan nilai pertama : ");
            pertama = int.Parse(Console.ReadLine());

            Console.Write("Masukkan nilai kedua : ");
            kedua = int.Parse(Console.ReadLine());

            Console.Write("Masukkan nilai ketiga : ");
            ketiga = int.Parse(Console.ReadLine());

            if(username=="bayu" && password=="ocbc" && isMarriage != true)
            {

                Console.WriteLine($"username {username}");
                Console.WriteLine(password);
                Console.WriteLine(umur);
                Console.WriteLine(sex);

                total = pertama + kedua + ketiga;
                rata = total / 3.0;

                Console.WriteLine("Total nilai adalah "+total);
                Console.WriteLine("Rata - rata nilai adalah "+rata);
            }
                        
        }
    }
}