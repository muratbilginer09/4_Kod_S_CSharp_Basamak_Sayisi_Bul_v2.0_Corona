using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kod_S_CSharp_Basamak_Sayısı_Bul_v2._0_Gloster
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayi;

            Console.Write("Sayıyı Giriniz:");

            sayi = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Basamak Sayısı={0}",sayi.Length);

            Console.ReadKey();

        }
    }
}
