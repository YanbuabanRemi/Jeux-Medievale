using System;
using System.Collections.Generic;
using System.Text;

namespace Exo.Classes
{
    class Jeux
    {
        private string nom;
        private Royaume royaume;
        

        public string Nom { get => nom; set => nom = value; }
        internal Royaume Royaume { get => royaume; set => royaume = value; }

        public Jeux(string n, Royaume r)
        {
            nom = n;
            royaume = r;

        }

        

        public void JeuxMenu(Royaume r)
        {
            Console.Clear();
            int choix;
            do
            {
                Console.WriteLine("---------------------------------Menu-------------------------------------\n");
                Console.WriteLine("1 - Acheter un village (350PO)\n2 - Acheter un paysan (50PO)\n3 - Prélever les impôts\n4 - Fin de Tour\n0 - Quitter le jeux\n");
                Console.WriteLine(r.ToString() + "\n");
                choix = Convert.ToInt32(Console.ReadLine());
                switch (choix)
                {
                    case 1:
                        Console.Clear();
                        r.AcheterVillage();
                        break;
                    case 2:
                        Console.Clear();
                        r.AcheterVillgeois();
                        break;
                    case 3:
                        Console.Clear();
                        r.PreleverImpot();
                        break;
                    case 4:
                        Console.Clear();
                        r.Vieillir();

                        break;
                    default:
                        Console.WriteLine("Error 404");
                        break;

                }


            } while (choix != 0);

            Console.ReadLine();
        }
    }
}
