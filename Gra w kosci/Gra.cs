using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_w_kosci
{
    class Gra
    {
        public List<Kosc> uklad5 = new List<Kosc>();
        public List<Wynik> wyniki = new List<Wynik>();

        public Gra()
        {
            wyniki.Add(new Wynik("jedynki"));
            wyniki.Add(new Wynik("dwojki"));
            wyniki.Add(new Wynik("trojki"));
            wyniki.Add(new Wynik("czworki"));
            wyniki.Add(new Wynik("piatki"));
            wyniki.Add(new Wynik("szostki"));
            wyniki.Add(new Wynik("trzy_jendakowe"));
            wyniki.Add(new Wynik("cztery_jendakowe"));
            wyniki.Add(new Wynik("ful"));
            wyniki.Add(new Wynik("malystrit"));
            wyniki.Add(new Wynik("duzystrit"));
            wyniki.Add(new Wynik("general"));
            wyniki.Add(new Wynik("szansa"));
            for (int i = 0; i < 6; i++)
            {
                int los = rnd.Next(1, 7);
                uklad5.Add(new Kosc(0));
            }
        }   
            
            

        Random rnd = new Random();

        public void uklad_losuj()
        {
            for (int i = 0; i < 6; i++)
            {
              if (uklad5[i].Zablokowany==false)
                uklad5[i].Oczka =  rnd.Next(1, 7);
            }
        }
        



        
    }
}
