using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Gra_w_kosci
{
    class uklad
    {
        public List<Kosc> uklad5 = new List<Kosc>();

        Random rnd = new Random();

        public void uklad_losuj()
        {
            for (int i = 0; i < 6; i++)
            {
                int los = rnd.Next(1, 7);
                uklad5.Add(new Kosc(los));
            }
        }

        

    }
}
