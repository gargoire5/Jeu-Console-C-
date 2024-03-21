using Jeu_Console_C_;
using System;
using System.Collections.Generic;

//class Program
//{
/*static void Main()
{
    var Model = new Model();
    Console.WriteLine(Model.dingus);
}*/

public class Attaque

{
    public string Nom { get; set; }
    public int Degats { get; set; }

    public int ModificateurDegatsSuivant { get; set; } // Pour augmenter les dégâts de la prochaine attaque
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




// Enumération des types d'éléments. Eau bat Feu, Feu bat Plante, Plante bat Eau.
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
    public List<Attaque> Attaques { get; set; }

    public int ModificateurDegatsSuivant { get; set; }
    public float ReductionDegatsRecus { get; set; }

    public Techmon(string nom, TypeElement type)

    {
        Nom = nom;
        Type = type;
        PointsDeVie = 100; // Valeur de départ, peut varier
        Niveau = 1;
        Experience = 0;
        ExpPourNiveauSuivant = 100; // Exemple de valeur, à ajuster selon le système d'expérience
        Attaques = new List<Attaque>(); // Initialisation de la liste d'attaques
        ModificateurDegatsSuivant = 0;
        ReductionDegatsRecus = 0;
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
            Console.WriteLine($"{Nom} a atteint le niveau {Niveau} !");
        }
    }
    public void Attaquer(Techmon adversaire, Attaque attaque)

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
        adversaire.PointsDeVie -= degatsEffectifs;

        Console.WriteLine($"{this.Nom} utilise {attaque.Nom} sur {adversaire.Nom}, infligeant {degatsEffectifs} dégâts.");

        // Mettre à jour les modificateurs pour les prochaines attaques basées sur l'attaque utilisée
        this.ModificateurDegatsSuivant += attaque.ModificateurDegatsSuivant;
        adversaire.ReductionDegatsRecus += attaque.ReductionDegatsRecus;
    }
    public void AfficherInformations()

    {
        Console.WriteLine($"Nom: {Nom}");
        Console.WriteLine($"Points de Vie: {PointsDeVie}");
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






//}
