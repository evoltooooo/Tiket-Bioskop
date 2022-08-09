using System;

namespace Tiket_Bioskop
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("===Selamat datang di aplikasi pemesanan tiket===");
            Console.Write("Masukan Username : ");
            string username = Console.ReadLine();
            Console.Write("Masukan Password : ");
            string password = Console.ReadLine();

            Console.Clear();

            if (username.ToLower()== "ucok" && password== "ucok_ganteng")
            {
                Console.Clear();
                Menu(args);
            }
            else
            {
                Console.WriteLine("Who are you,hands in the air");
            }
        }
        public static void Menu(string[] args)
        {
            int pilihan,tiket; 
            
            Console.WriteLine("===Selamat datang ucok===");
            Console.WriteLine("Pilihan Film Hari Ini : ");
            Console.WriteLine("1. Ucok The Beginning");
            Console.WriteLine("2. The Fall of Ucok");
            Console.WriteLine("3. Ucok Redemption Arc");
            Console.Write("Anda mau menonton apa hari ini [Masukan Nomor] : ");
            pilihan=int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("==== Struk ====");

            if (pilihan == 1)
            {
                Console.Write("Berapa Tiket : ");
                tiket = int.Parse(Console.ReadLine());
                var harga = tiket* 35000;
                Console.WriteLine("Nama : Ucok");
                Console.WriteLine($"Tiket : {tiket}");
                Console.WriteLine($"Total harga =Rp.{harga}");
            }
            else if (pilihan == 2)
            {
                Console.Write("Berapa Tiket : ");
                tiket = int.Parse(Console.ReadLine());
                var harga = tiket * 40000;
                Console.WriteLine("Nama : Ucok");
                Console.WriteLine($"Tiket : {tiket}");
                Console.WriteLine($"Total harga =Rp.{harga}");
            }
            else if (pilihan == 3)
            {
                Console.Write("Berapa Tiket : ");
                tiket = int.Parse(Console.ReadLine());
                var harga = tiket * 50000;
                Console.WriteLine("Nama : Ucok");
                Console.WriteLine($"Tiket : {tiket}");
                Console.WriteLine($"Total harga =Rp.{harga}");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.WriteLine("=== Selamat Menikmati Film ===");
        }
    }
}
