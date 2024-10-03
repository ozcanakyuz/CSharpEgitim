using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        private static string turkLirasi;

        static void Main(string[] args)
        {
            //Console.Write("Hello World!");
            


            double applePrice, bananaPrice, orangePrice;
            Console.OutputEncoding = Encoding.UTF8;

            turkLirasi = "₺";
            applePrice = 14.85;
            bananaPrice = 20.95;
            orangePrice = 45;

            Console.WriteLine("--- Elma Birim Fiyatı: " + applePrice + turkLirasi);
            Console.WriteLine("--- Muz Birim Fiyatı: " + bananaPrice + turkLirasi);
            Console.WriteLine("--- Portakal Birim Fiyatı: " + orangePrice + turkLirasi);
            
            
            Console.Read();
        }
    }
}
