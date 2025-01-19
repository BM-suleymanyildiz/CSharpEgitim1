using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            islem islem = new islem();
            islem.topla(2,5);
            islem.fark(5, 3);
            islem.carp(5,7);
            islem.bolum(80,16);
            islem.kare(6);
            Console.Read();
        }
    }
}
