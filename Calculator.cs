using System;

namespace CaclulatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pilih Menu Kalkulator : \n");
            Console.WriteLine("1. Penjumlahan\n" +
                "2. Pengurangan\n" +
                "3. Perkalian\n" +
                "4. Pembagian\n");
            Console.Write("Input Nomor Menu [1...4] : ");

            int pilihan = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input Nilai a : ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Input Nilai b : ");
            int b = int.Parse(Console.ReadLine());

            switch (pilihan)
            {
                case 1:
                    Console.WriteLine("Hasil Penjumlahan {0} + {1} = {2}",a,b,penjumlahan(a, b));
                    break;
                case 2:
                    Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}",a,b,pengurangan(a, b));
                    break;
                case 3:
                    Console.WriteLine("Hasil Perkalian {0} * {1} = {2}",a,b,perkalian(a, b));
                    break;
                case 4:
                    Console.WriteLine("Hasil Pembagian {0} / {1} = {2}",a, b, pembagian(a, b));
                    break;
                default:
                    Console.WriteLine("Maaf, menu yang Anda pilih tidak tersedia");
                    break;
            }

            Console.WriteLine("Tekan sembarang key untuk keluar...");
            Console.ReadKey();

        }

        static int penjumlahan(int a, int b)
        {
            return a + b;
        }

        static int pengurangan(int a, int b)
        {
            return a - b;
        }

        static int perkalian(int a, int b)
        {
            return a * b;
        }

        static double pembagian(double a, double b)
        {
            return a / b;
        }
    }
}
