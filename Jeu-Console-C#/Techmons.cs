/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu_Console_C_
{
    internal class Techmons : GameObject
    {
        public Techmons(string name, int health, TypeElement type, int niveau) : base(name, health, type, niveau)
        {

        }

        // ajouter une attaque à Pokémon
        public void AjouterAttaque(Attaque attaque)

        {
            Attaques.Add(attaque);
        }

        //gagner expérience et peut etre augmenter de niveau
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

            
            degatsBase += this.ModificateurDegatsSuivant;

            float augmentation = 1 + (attaque.AugmentationDegatsPourcentage / 100.0f);
            int degatsEffectifs = (int)(degatsBase * augmentation);

            
            degatsEffectifs = (int)(degatsEffectifs * (1 - adversaire.ReductionDegatsRecus));

            
            this.ModificateurDegatsSuivant = 0;
            adversaire.ReductionDegatsRecus = 0;

           
            adversaire.Health -= degatsEffectifs;

            Console.WriteLine($"{this.Name} utilise {attaque.Nom} sur {adversaire.Name}, infligeant {degatsEffectifs} dégâts.");

            
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

            Console.WriteLine(); //ajoute ligne pour visibilite
        }
        
        public Attaque ChoisirAttaque()
        {
            Console.WriteLine($"Choisissez une attaque pour {Name}:");
            for (int i = 0; i < Attaques.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {Attaques[i].Nom} (Dégâts: {Attaques[i].Degats})");
            }
            int choix = int.Parse(Console.ReadLine()) - 1;
            return Attaques[choix];
        }

        public Attaque ChoisirAttaqueAdversaire()
        {
            //choix d'attaque par l'adversaire (IA)
            Random rnd = new Random();
            int choix = rnd.Next(Attaques.Count);
            return Attaques[choix];
        }

    }
}
*/
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
