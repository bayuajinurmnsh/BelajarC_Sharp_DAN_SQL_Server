using System;

namespace sesi_01
{
    class Program
    {

        static void Main(string[] args)
        {
            string fname, lname, alamat;
            int umur;
            int tanggal, bulan, tahun;

            Console.Write("Insert your first name   : ");
            fname = Console.ReadLine();
            Console.Write("Insert your last name    : ");
            lname = Console.ReadLine();
            Console.Write("Insert your address      : ");
            alamat = Console.ReadLine();

            Console.Write("\nInsert your birthdate \ndate                     : ");
            tanggal = int.Parse(Console.ReadLine());
            Console.Write("month                    : ");
            bulan = int.Parse(Console.ReadLine());
            Console.Write("year                     : ");
            tahun = int.Parse(Console.ReadLine());
            

            umur = DateTime.Now.Year - tahun;

            Console.WriteLine("");
            Console.WriteLine("Nama anda adalah     : "+fname+" "+lname);
            Console.WriteLine("Alamat anda di       : "+alamat);
            Console.WriteLine("Tanggal lahir anda   : "+tanggal+"-"+bulan+"-"+tahun);
            Console.WriteLine("Anda berumur         : "+umur+" Tahun");
            Console.WriteLine("");
            
        }
    }
}
