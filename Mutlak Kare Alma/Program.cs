using System;

namespace Mutlak_Kare_Alma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı sayısını girin: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int Farklılıkların_Toplamı = 0;
            long Farkların_Kareleri_Toplamı = 0;

            Console.WriteLine("Numaraları girin:");
            for (int i = 0; i < n; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num < 67)
                {
                    Farklılıkların_Toplamı += 67 - num;
                }
                else
                {
                    Farkların_Kareleri_Toplamı += (num - 67) * (num - 67);
                }
                Console.WriteLine($"farklılıkların toplamı: {Farklılıkların_Toplamı}");
                Console.WriteLine($"farkların karelerinin toplamıdır: {Farkların_Kareleri_Toplamı}");
            }
            Console.ReadKey();

           
        }
    }
}
