using Exo.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Exo
{
    class Program
    {
        public static List<Jeux> listeJeux = new List<Jeux>();

        static void Main(string[] args)
        {
            

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("-----------------------------------------Bienvenue sur le super jeux Médiévale---------------------------------\n\n");

            Console.WriteLine("1 - Nouvelle partie\n2 - Charger un partie\n3 - Quitter");
            int choix = Convert.ToInt32(Console.ReadLine());

            switch (choix)
            {
                case 1:
                    NewGame();
                    break;
                case 2:
                    ContinuGame();
                    break;
                case 3:
                    Console.WriteLine("Error 404");
                    break;
                
            }
            Console.ReadLine();
            
        }

        static void NewGame()
        {
            Console.WriteLine("Quel est le nom de votre partie ?");
            string PartiName = Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("-------------------------------------------Quel est le nom de votre Royaume ?----------------------------------\n");
            Royaume R1 = new Royaume(Console.ReadLine());
            Jeux j = new Jeux(PartiName, R1);
            Console.Clear();
            listeJeux.Add(j);
            StreamWriter writer = new StreamWriter("Jeux.txt");
            writer.WriteLine(JsonConvert.SerializeObject(listeJeux));
            writer.Close();
            j.JeuxMenu();
        }

        static void ContinuGame()
        {
            Console.WriteLine("Quel partie souhaitez-vous continuer ?");
            List<Jeux> listeJeuxFromJson = new List<Jeux>();
            if (File.Exists("Jeux.txt"))
            {
                StreamReader reader = new StreamReader("Jeux.txt");
                listeJeuxFromJson = JsonConvert.DeserializeObject<List<Jeux>>(reader.ReadToEnd());
                reader.Close();
            }
            foreach(Jeux j in listeJeuxFromJson)
            {
                Console.WriteLine(j.Nom);
            }
            string choixGame = Console.ReadLine();
            foreach (Jeux j in listeJeuxFromJson)
                {
                if (choixGame == j.Nom)
                    j.JeuxMenu();
                }
        }
    }
}
