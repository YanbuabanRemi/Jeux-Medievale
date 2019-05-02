using Exo.Classes;
using System;

namespace Exo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("-----------------------------------------Bienvenue sur le super jeux Médiévale---------------------------------\n\n");
            Console.WriteLine("-------------------------------------------Quel est le nom de votre Royaume ?----------------------------------\n");
            Royaume R1 = new Royaume(Console.ReadLine());

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
