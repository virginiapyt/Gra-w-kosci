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

        public int OczkaProperty
        {
            get { return oczka; }
            set { oczka = value; }
        }

        private int zablokowany;

        public int ZablokowanyProperty
        {
            get { return zablokowany; }
            set { zablokowany = value; }
        }

        public Kosc(int oczka)
        {
            this.oczka = oczka;
            this.zablokowany =0;
        }
    }
}
