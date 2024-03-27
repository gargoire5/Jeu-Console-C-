using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu_Console_C_
{
    internal class Techmons : GameObject
    { 

        public Techmons(string name, int health, int maxhealth ,TypeElement type, int niveau) : base(name, type, niveau)
        {
            Health = health;
            MaxHeath = maxhealth;
            Type = type;
            Niveau = niveau;
        }

        // Méthode pour ajouter une attaque à ce Pokémon
        public void AjouterAttaque(Attaque attaque)

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
                // Augmenter ExpPourNiveauSuivant selon une certaine logique
                ExpPourNiveauSuivant *= 2; // Exemple simple
                Console.WriteLine($"{Name} a atteint le niveau {Niveau} !");
            }
        }
        public void Attaquer(Techmons adversaire, Attaque attaque)

        {
            int degatsBase = attaque.Degats;

            // Si l'attaque courante bénéficie d'un bonus de dégâts de la précédente attaque
            degatsBase += this.ModificateurDegatsSuivant;

            // Calculer l'augmentation des dégâts en pourcentage
            float augmentation = 1 + (attaque.AugmentationDegatsPourcentage / 100.0f);
            int degatsEffectifs = (int)(degatsBase * augmentation);

            // Appliquer la réduction des dégâts basée sur l'adversaire (si pertinent)
            degatsEffectifs = (int)(degatsEffectifs * (1 - adversaire.ReductionDegatsRecus));

            // Réinitialiser les modificateurs après leur utilisation
            this.ModificateurDegatsSuivant = 0;
            adversaire.ReductionDegatsRecus = 0;

            // Appliquer les dégâts à l'adversaire
            adversaire.Health -= degatsEffectifs;

            Console.WriteLine($"{this.Name} utilise {attaque.Nom} sur {adversaire.Name}, infligeant {degatsEffectifs} dégâts.");

            // Mettre à jour les modificateurs pour les prochaines attaques basées sur l'attaque utilisée
            this.ModificateurDegatsSuivant += attaque.ModificateurDegatsSuivant;
            adversaire.ReductionDegatsRecus += attaque.ReductionDegatsRecus;
        }
        public void AfficherInformations()
        {
            Console.WriteLine($"Nom: {Name}");
            Console.WriteLine($"Points de Vie: {Health}");
            Console.WriteLine($"Niveau: {Niveau}");
            Console.WriteLine($"Expérience: {Experience}/{ExpPourNiveauSuivant}");
            Console.WriteLine("Attaques:");

            foreach (var attaque in Attaques)
            {
                List<string> effets = new List<string>();
                if (attaque.Degats > 0)
                {
                    effets.Add($"Dégâts: {attaque.Degats}");
                }
                if (attaque.AugmentationDegatsPourcentage > 0)
                {
                    effets.Add($"augmente les dégâts de la prochaine attaque de {attaque.AugmentationDegatsPourcentage}%");
                }
                if (attaque.ReductionDegatsRecus > 0)
                {
                    effets.Add($"réduit les dégâts reçus de la prochaine attaque de {attaque.ReductionDegatsRecus * 100}%");
                }

                string descriptionEffets = string.Join(", ", effets);
                Console.WriteLine($"- {attaque.Nom} ({descriptionEffets})");
            }

            Console.WriteLine(); // Ajoute une ligne vide pour la lisibilité
        }
    }
}
