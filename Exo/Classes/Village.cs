using System;
using System.Collections.Generic;
using System.Text;

namespace Exo.Classes
{
    class Village : Royaume
    {
        public List<Roturier> ListRoturier = new List<Roturier>();

        public Village(string n) : base(n)
        {
            Roturier r = new Roturier();
            ListRoturier.Add(r);
        }
    }
}
