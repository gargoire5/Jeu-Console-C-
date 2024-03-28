using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeu_Console_C_
{
    public class Attaque

    {
        public string Nom { get; set; }
        public int Degats { get; set; }

        //public float ModificateurDegatsSuivant { get; set; } // Pour augmenter les dégâts de la prochaine attaque
        public float AugmentationDegatsPourcentage { get; set; }
        public float ReductionDegatsRecus { get; set; } // Pourcentage de réduction des dégâts de la prochaine attaque reçue

        public Attaque(string nom, int degats, float augmentationDegatsPourcentage = 0, float reductionDegatsRecus = 0)

        {
            Nom = nom;
            Degats = degats;
            AugmentationDegatsPourcentage = augmentationDegatsPourcentage;
            ReductionDegatsRecus = reductionDegatsRecus;
        }
    }
}
