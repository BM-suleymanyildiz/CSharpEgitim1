using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class islem
    {
        public int topla(int s1, int s2)
        {
            int s3 = s1 + s2;
            Console.WriteLine("Sonuç: " + s3);
            return s1 + s2;
        }
        public int kare(int a)
        {
            int sonuc = a * a;
            Console.WriteLine("Sonuç: " + sonuc);
            return sonuc;
        }
        public int fark(int a, int b)
        {
            int sonuc = a - b;
            Console.WriteLine("Sonuç: " + sonuc);

            return sonuc;
        }
        public int carp(int a, int b)
        {
            int sonuc = a *b;
            Console.WriteLine("Sonuç: " + sonuc);

            return sonuc;
        }
        public int bolum (int a,int b)
        {
            int sonuc = a / b;
            Console.WriteLine("Sonuç: " + sonuc);

            return sonuc;
        }

    }
}
