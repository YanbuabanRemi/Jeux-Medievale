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
        public List<Village> listeVillage = new List<Village>();

        public string Nom { get => nom; }
        public int Somme { get => somme; set => somme = value; }
        public int Annee { get => annee; set => annee = value; }


        public Royaume(string nom)
        {
            this.nom = nom;
            Somme = 500;
            annee = 1400;
        }

        public override string ToString()
        {
            return "Royaume : " + Nom + " \nIl vous reste " + Somme + " pièces d'or " + "\nAnnée : " + annee + "\nVos Villages " + listeVillage.Count;
            
        }

        public void Vieillir()
        {
            annee++;
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
            Somme -= 350;
        }
    }
}
