using System;
using System.Collections.Generic;
using System.Text;

namespace Exo.Classes
{
    class Village : Royaume
    {
        public List<Roturier> ListRoturier = new List<Roturier>();

        int impot;

        public Village(string n) : base(n)
        {
            Roturier r = new Roturier();
            ListRoturier.Add(r);
        }

        public void Vieillir()
        {
            foreach(Roturier r in ListRoturier)
            {
                r.Vieillir();                             
            }
        }

        
        public int PreleverImpot()
        {          
            foreach(Roturier r in ListRoturier)
            {
                impot += r.PreleverImpotRoturier();
            }
            return impot;
        }
    }
}
