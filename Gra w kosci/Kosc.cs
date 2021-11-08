using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_w_kosci
{
    class Kosc
    {
        private int oczka;
        private string obrazek;

        public int Oczka
        {
            get { return oczka; }
            set { oczka = value; }
        }

        private int zablokowany;

        public int Zablokowany
        {
            get { return zablokowany; }
            set { zablokowany = value; }
        }

        public string Obrazek
        {
            get { return obrazek; }
            set { obrazek = value; }
        }

        public Kosc(int oczka)
        {
            this.oczka = oczka;
            this.zablokowany =0;

            switch (oczka){
                case 1:
                    this.obrazek = "/Recources/kostka1.png";break;
                case 2:
                    this.obrazek = "/Recources/kostka2.png"; break;
                case 3:
                    this.obrazek = "/Recources/kostka3.png"; break;
                case 4:
                    this.obrazek = "/Recources/kostka4.png"; break;
                case 5:
                    this.obrazek = "/Recources/kostka5.png"; break;
                case 6:
                    this.obrazek = "/Recources/kostka6.png"; break;


            }

           
        }
    }
}
