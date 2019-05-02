using System;
using System.Collections.Generic;
using System.Text;

namespace Exo.Classes
{
    class Jeux
    {
        private string nom;

        

        public string Nom { get => nom; }

        public Jeux(string n, Royaume r)
        {
            nom = n;
        }

        

        public void JeuxMenu()
        {
            

            Console.Clear();


            int choix;
            do
            {
                //Console.Clear();
                Console.WriteLine("---------------------------------Menu-------------------------------------\n");
                Console.WriteLine("1 - Acheter un village (350PO)\n2 - Acheter un paysan (50PO)\n3 - Prélever les impôts\n4 - Fin de Tour\n0 - Quitter le jeux\n");
                Console.WriteLine(R1.ToString() + "\n");
                choix = Convert.ToInt32(Console.ReadLine());
                switch (choix)
                {
                    case 1:
                        Console.Clear();
                        R1.AcheterVillage();
                        break;
                    case 2:
                        Console.Clear();
                        R1.AcheterVillgeois();
                        break;
                    case 3:
                        Console.Clear();
                        R1.PreleverImpot();
                        break;
                    case 4:
                        Console.Clear();
                        R1.Vieillir();

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
