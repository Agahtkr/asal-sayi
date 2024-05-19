using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asal_sayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İki sayı girin:");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            bool asalMi = true;

                if (a < 2)
                    a = 2;

                if (b < 2)
                    Console.WriteLine("İkinci sayıyı ikiden büyük bir değer girin.");

            for (; a <= b; a++)
            {
                for(int i = 2; i <= Math.Sqrt(a) && asalMi; i++)
                {
                    if (a % i == 0)
                        asalMi = false;
                }
                if (asalMi)
                    Console.WriteLine(a);
                asalMi = true;
            }
            Console.ReadKey();
        }
    }
}
