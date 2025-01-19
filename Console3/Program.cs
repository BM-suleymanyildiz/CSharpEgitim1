using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            odev1 ks = new odev1();
            Console.Write("İsim Giriniz: ");
            string ad = Console.ReadLine();

            Console.Write("Soyisim Giriniz: ");
            string soyad = Console.ReadLine();

            Console.Write("Yaş Giriniz: ");
            string yas = Console.ReadLine();

            Console.Write("Meslek Giriniz: ");
            string meslek = Console.ReadLine();

            ks.bilgi(ad, soyad, yas, meslek);
            Console.Read();
        }
    }
}
