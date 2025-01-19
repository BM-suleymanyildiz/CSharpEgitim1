using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kimlik kml = new Kimlik();
            kml.AD = "Süleyman";
            kml.SOYAD = "Yıldız";
            kml.MEMLEKET = "Gaziantep";
            Console.WriteLine(kml.AD);
            Console.WriteLine(kml.SOYAD);
            Console.WriteLine(kml.MEMLEKET);
            Console.WriteLine(kml.YAS);
            Console.WriteLine(kml.CINSIYET);
            Console.Read();

        }
    }
}
