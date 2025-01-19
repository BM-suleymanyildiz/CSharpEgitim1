using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console5
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Bilgileri Giriniz ");
            Console.Write("Ad: ");
            string ad = Console.ReadLine();
            Console.Write("Soyad: ");
            string soyad = Console.ReadLine();
            Console.Write("Yaş: ");
            int yas= Convert.ToInt16(Console.ReadLine());
            Console.Write("Meslek: ");
            string meslek = Console.ReadLine();



            Ogrenci ogrenci = new Ogrenci(ad,soyad,yas,meslek);
            Console.Read();
        }
    }
}
