using Exo.Classes;
using System;

namespace Exo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------Bienvenue sur le super jeux Médiévale------------------");
            Console.WriteLine("--------------------Quel est le nom de votre Royaume ?-------------------");
            Royaume R1 = new Royaume(Console.ReadLine());

            Console.Clear();
            

            int choix;
            do
            {
                Console.WriteLine("---------------------------------Menu-------------------------------------\n");
                Console.WriteLine("1 - Acheter un village\n2 - Acheter un paysan\n3 - Prélever les impôts\n4 - Fin de Tour\n0 - Quitter le jeux\n");
                Console.WriteLine(R1.ToString() + "\n");
                choix = Convert.ToInt32(Console.ReadLine());
                switch (choix)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Nom du village :");
                        Village v = new Village(Console.ReadLine());
                        R1.listeVillage.Add(v);
                        R1.AcheterVillage();
                        Console.WriteLine("Village Créé");

                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Paysan acheté");
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Impôts");
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
