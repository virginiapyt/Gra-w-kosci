using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_w_kosci
{
    class Wynik
    {
        private int punkty;

        public int Punkty
        {
            get { return punkty; }
            set { punkty = value; }
        }

        private string nazwa;

        public string Nazwa
        {
            get { return nazwa; }
            set { nazwa = value; }
        }

        private bool zapisany;

       
        public bool Zapisany
        {
            get { return zapisany; }
            set { zapisany = value; }
        }

        public Wynik( string nazwa)
        {
            Punkty = 0;
            Nazwa = nazwa;
            Zapisany = false;
        }
    }
}
