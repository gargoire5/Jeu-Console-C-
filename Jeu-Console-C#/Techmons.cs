using System;
using System.Collections.Generic;

namespace Jeu_Console_C_
{
    public class Techmons : GameObject
    {
        // Propriétés déjà définies dans la base GameObject je crois
        
        public List<Attaque> Attaque { get; private set; }

        public Techmons(string name, int health, TypeElement type, int niveau) : base(name, health, type, niveau)
        {
            Attaques = new List<Attaque>();
        }

        public void AjouterAttaque(Attaque attaque)
        {
            Attaques.Add(attaque);
        }

        public void GagnerExperience(int exp)
        {
            Experience += exp;
            while (Experience >= ExpPourNiveauSuivant)
            {
                Niveau++;
                Experience -= ExpPourNiveauSuivant;
                ExpPourNiveauSuivant = CalculerExpPourNiveauSuivant(Niveau);
                Console.WriteLine($"{Name} a atteint le niveau {Niveau} !");
            }
        }
        public void AfficherAttaques()
        {
            Console.WriteLine($"|| {Name} || {Health} Pv || Niv {Niveau} || Type : {Type} ||:");
            Console.WriteLine("Attaques disponibles:");

            for (int i = 0; i < Attaques.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{Attaques[i].Nom}: Dégâts: {Attaques[i].Degats}, Augmente Dégâts: {Attaques[i].AugmentationDegatsPourcentage}%, Réduit Dégâts Reçus: {Attaques[i].ReductionDegatsRecus * 100}%");
            }

        }

        private int CalculerExpPourNiveauSuivant(int niveau)
        {
            return 100 * niveau; // Simplification pour l'exemple
        }

        /*public void Attaquer(Techmons adversaire, Attaque attaque)
        {
            int degatsEffectifs = attaque.Degats;
            // Ajoute ici la logique pour calculer les effets de type
            adversaire.Health -= degatsEffectifs;
            Console.WriteLine($"{Name} utilise {attaque.Nom} et inflige {degatsEffectifs} points de dégâts à {adversaire.Name}.");
        }*/

        //public float ModificateurDegatsSuivant { get; set; } = 0;
        public float AugmentationDegatsPourcentage { get; set; } = 0;
        public void Attaquer(Techmons adversaire, Attaque attaque)
        {
            //int degatsBase = attaque.Degats;
            int degatsEffectifs = attaque.Degats + (int)(attaque.Degats * (this.AugmentationDegatsPourcentage / 100.0));

            adversaire.Health -= degatsEffectifs; // Applique les dégâts à l'adversaire

            Console.WriteLine($"{Name} utilise {attaque.Nom} infligeant {degatsEffectifs} dégâts à {adversaire.Name}.");
            if (adversaire.Health <= 0)
            {
                Console.WriteLine($"{adversaire.Name} est vaincu !");
            }
            AugmentationDegatsPourcentage = 0;
            if (attaque.AugmentationDegatsPourcentage > 0)
            {
                AugmentationDegatsPourcentage = attaque.AugmentationDegatsPourcentage;
            }
            // après l'attaque, réinitialise ou ajuste les modificateurs selon l'attaque utilisée
            //this.AugmentationDegatsPourcentage = attaque.AugmentationDegatsPourcentage; 

            
            //this.AugmentationDegatsPourcentage = 0;

            // Vérifier si l'adversaire est vaincu
            /*if (adversaire.Health <= 0)
            {
                Console.WriteLine($"{adversaire.Name} est vaincu !");
            }*/
        }




        // Extension: Affichage des informations du Techmon, incluant les attaques et leurs effets (je crois ya plus besoin)
        public void AfficherInformations()
        {
            Console.WriteLine($"Nom: {Name}, Type: {Type}, Niveau: {Niveau}, PV: {Health}");
            Console.WriteLine("Attaques disponibles:");
            foreach (var attaque in Attaques)
            {
                Console.WriteLine($"- {attaque.Nom}: Dégâts: {attaque.Degats}, Augmente Dégâts: {attaque.AugmentationDegatsPourcentage}%, Réduit Dégâts Reçus: {attaque.ReductionDegatsRecus * 100}%");
            }
        }

    }
}
