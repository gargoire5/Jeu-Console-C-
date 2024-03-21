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
        Gianni.AjouterAttaque(new Attaque("Le poulet est délicieux", 0, 50));//Boost attaque
        Gianni.AjouterAttaque(new Attaque("Purple", 40, 0, 0));//Attaque
        Gianni.AjouterAttaque(new Attaque("Domain Expansion", 0, 10, 0.4f));//Boost def
        Gianni.AjouterAttaque(new Attaque("I am Atomic", 70, 0, 0));//Attaque


        Ewen.AjouterAttaque(new Attaque("Dictature du délégué", 0, 10, 0.35f));//Debuff ou buff
        Ewen.AjouterAttaque(new Attaque("Perdu batard", 50, 0, 0));//Attaque

        Enzo.AjouterAttaque(new Attaque("Mais elle a 12ans", 60, 0, 0));// Attaque
        Enzo.AjouterAttaque(new Attaque("Je suis un faux cul", 0, 10, 0.5f));// Buff

        Kyllian.AjouterAttaque(new Attaque("Je suis coach", 0, 10, 0.35f));
        Kyllian.AjouterAttaque(new Attaque("Dans ton crane", 65, 0, 0));

        Benjamin.AjouterAttaque(new Attaque("Been Shilling", 0, 10, 0.5f));
        Benjamin.AjouterAttaque(new Attaque("Gojo Satoru", 0, 60, 0.35f));
        Benjamin.AjouterAttaque(new Attaque("Fatal Tacle", 70, 0, 0));

        Grégoire.AjouterAttaque(new Attaque("Rentre Dans Ton Pays", 40, 0, 0));
        Grégoire.AjouterAttaque(new Attaque("Je construirai un mur", 0, 80, 0.05f));



        // Simule l'ajout d'expérience

        //Gianni.GagnerExperience(50);
        //Ewen.GagnerExperience(120); // ça devrait suffire pour augmenter de niveau
        //Enzo.GagnerExperience(30);

        // Pour démonstration : Affiche les informations de chaque Pokémon
        List<Techmon> pokemons = new List<Techmon> { Gianni, Ewen, Enzo, Kyllian, Benjamin, Grégoire };
        foreach (var pokemon in pokemons)
        {
            pokemon.AfficherInformations();
        }
    }


}
