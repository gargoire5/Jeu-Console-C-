using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu_Console_C_
{
    public enum TypeElement
    {
        Css,
        Python,
        C
    }

    // Classe de base pour les Pokémon
    public class Techmon
    {
        public string Nom { get; set; }
        public int PointsDeVie { get; set; }
        public int Niveau { get; set; }
        public int Experience { get; set; }
        public int ExpPourNiveauSuivant { get; set; }
        public TypeElement Type { get; set; }
        public List<string> Attaques { get; set; }

        public Techmon(string nom, TypeElement type)
        {
            Nom = nom;
            Type = type;
            PointsDeVie = 100; // Valeur de départ, peut varier
            Niveau = 1;
            Experience = 0;
            ExpPourNiveauSuivant = 50; // Exemple de valeur, à ajuster selon le système d'expérience
            Attaques = new List<string>(); // Initialisation de la liste d'attaques
        }

        // Méthode pour ajouter une attaque
        public void AjouterAttaque(string attaque)
        {
            Attaques.Add(attaque);
        }

        // Méthode pour gagner de l'expérience et potentiellement augmenter de niveau
        public void GagnerExperience(int exp)
        {
            Experience += exp;
            if (Experience >= ExpPourNiveauSuivant)
            {
                Niveau++;
                Experience -= ExpPourNiveauSuivant;
                // Augmenter ExpPourNiveauSuivant
                ExpPourNiveauSuivant *= 2; // Exemple simple
                Console.WriteLine($"{Nom} a atteint le niveau {Niveau} !");
            }
        }

    }
}



