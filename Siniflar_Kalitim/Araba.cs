using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar_Kalitim
{
    internal class Araba : ArabaDetay
    {
        public int hiz;
        public string renk;
        public char durum;
        public double motor;
        public int fiyat;
        private int yil;
        private string Marka;

        public int YIL
        {
            get { return yil; }
            set { yil = Math.Abs(value); }
        }

        public string MARKA
        {
            get { return Marka; }
            set { Marka = value.ToUpper(); }
        }
    }
}
