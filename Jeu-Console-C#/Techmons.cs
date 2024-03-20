using Jeu_Console_C_;
using System;
using System.Collections.Generic;

class Program
{
    /*static void Main()
    {
        var Model = new Model();
        Console.WriteLine(Model.dingus);
    }*/
    
    static void Main(string[] args)
    {
        // Création des Pokémon
        Techmon Gianni = new Techmon("Gianni", TypeElement.Css);
        Techmon Ewen = new Techmon("Ewen", TypeElement.Python);
        Techmon Enzo = new Techmon("Enzo", TypeElement.C);
        Techmon Kyllian = new Techmon("Kyllian", TypeElement.Python);
        Techmon Benjamin = new Techmon("Benjamin", TypeElement.C);
        Techmon Grégoire = new Techmon("Grégoire", TypeElement.Css);

        // Ajout d'attaques pour chaque Pokémon
        Gianni.AjouterAttaque("Le poulet est délicieux");//Boost attaque
        Gianni.AjouterAttaque("Purple");//Attaque
        Gianni.AjouterAttaque("Domain Expansion");//Boost hp
        Gianni.AjouterAttaque("I am Atomic");//Attaque

        Ewen.AjouterAttaque("Dictature du délégué");//Debuff ou buff
        Ewen.AjouterAttaque("Perdu batard");//Attaque

        Enzo.AjouterAttaque("Mais elle a 12ans");// Attaque
        Enzo.AjouterAttaque("Je suis un faux cul");// Buff

        Kyllian.AjouterAttaque("Je suis coach");
        Kyllian.AjouterAttaque("Dans ton crane");

        Benjamin.AjouterAttaque("Been Shilling");
        Benjamin.AjouterAttaque("Gojo Satoru");
        Benjamin.AjouterAttaque("Fatal Tacle");

        Grégoire.AjouterAttaque("Rentre Dans Ton Pays");
        Grégoire.AjouterAttaque("Je construirai un mur");



        // Simule l'ajout d'expérience

        Gianni.GagnerExperience(50);
        Ewen.GagnerExperience(200); // ça devrait suffire pour augmenter de niveau
        Enzo.GagnerExperience(30);
        Kyllian.GagnerExperience(70);
        Benjamin.GagnerExperience(20);
        Grégoire.GagnerExperience(40);

        // Pour démonstration : Affiche les informations de chaque Pokémon
        List<Techmon> pokemons = new List<Techmon> { Gianni, Ewen, Enzo, Kyllian, Benjamin, Grégoire };
        foreach (var pokemon in pokemons)
        {
            Console.WriteLine($"{pokemon.Nom} - Niveau: {pokemon.Niveau}, Exp: {pokemon.Experience}/{pokemon.ExpPourNiveauSuivant}, PV: {pokemon.PointsDeVie}");
            Console.WriteLine($"Attaques: {string.Join(", ", pokemon.Attaques)}");
            Console.WriteLine(); // Ajoute une ligne vide pour la lisibilité
        }
    }


}
