using System;
using System.Collections.Generic;
using System.Text;

namespace Exo.Classes
{
    class Royaume
    {
        private string nom;
        private int somme;
        private int annee;
        private int impot;
        public List<Village> listeVillage = new List<Village>();
        public List<Villageois> listeVillageois = new List<Villageois>();

        public string Nom { get => nom; }
        public int Somme { get => somme; set => somme = value; }
        public int Annee { get => annee; set => annee = value; }
        public int Impot { get => impot; set => impot = value; }

        public Royaume(string nom)
        {
            this.nom = nom;
            Somme = 500;
            annee = 1400;
        }

        public override string ToString()
        {
            return "Royaume : " + Nom + " \nIl vous reste " + Somme + " pièces d'or " + "\nAnnée : " + annee + "\nVillages :" + listeVillage.Count + "\nPaysans :" + listeVillageois.Count;
            
        }

        public void Vieillir()
        {
            annee++;
            foreach(Village v in listeVillage)
            {
                v.Vieillir();
            }

            int nbVillageois = listeVillageois.Count;
            if (nbVillageois != 0)
                somme += nbVillageois * 30;
        }

        public void AfficherVillage()
        {
            foreach(Village v in listeVillage)
            {

                Console.WriteLine(v.nom);
            } 
        }

        public void AcheterVillage()
        {
            if (somme >= 350) {
            Somme -= 350;
            Console.WriteLine("Nom du village :");
            Village v = new Village(Console.ReadLine());
            listeVillage.Add(v);
            Console.Clear();
            Console.WriteLine("Village Créé");
            }
            else
            {
                Console.WriteLine("Vous n'avez pas assez d'argent");
            }
        }

        public void AcheterVillgeois()
        {
            if (somme >= 50 && listeVillage.Count != 0)
            {
                Somme -= 50;
                Console.WriteLine("Un villageois de plus travaille désormais pour vous ");
                Villageois v = new Villageois();
                listeVillageois.Add(v);
            }
            else if (listeVillage.Count == 0)
            {
                Console.WriteLine("Vous ne possédez pas de village !");
            }
            else
            {
                Console.WriteLine("Vous n'avez pas assez d'argent !");
            }
        }

        public void PreleverImpot()
        {
            Impot = 0;
            if (listeVillage.Count != 0) { 
            foreach(Village v in listeVillage)
            {
                Impot += v.PreleverImpot();
            }
            Somme += Impot;
            Console.WriteLine("Vous avez prelevé les impôts, vous avez maintenant" + somme + " pièce d'or");
            }
            else
            {
                Console.WriteLine("Vous ne possédez pas de village, vous ne pouvez donc pas prélever les impôts !");
            }
        }
    }
}
