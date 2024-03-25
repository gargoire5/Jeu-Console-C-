/*using Jeu_Console_C_;
using System;

*//*class Program
{
    static void Main(string[] args)
    {
        var sceneManager = new SceneManager();
        sceneManager.Update();
    }
}*//*

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenue dans le jeu Techmon!");
        Console.Write("Entrez votre nom de joueur : ");
        string nameJoueur = Console.ReadLine();

        Player joueur = new Player(nameJoueur);
        Console.WriteLine($"Bonjour, {joueur.Name}!");
        Console.WriteLine("Appuyez sur la touche Échap pour quitter.");

        while (Console.ReadKey(true).Key != ConsoleKey.Escape)
        {
            
        }

        // Exemple de comment capturer un Pokémon (tu devras remplacer cela par ta logique de jeu)
        //Techmons Gianni = new Techmons("Gianni", 20, TypeElement.Css, 5);
        //joueur.CapturerTechmons(Gianni);

        // Pour afficher les Pokémon capturés
        *//*Console.WriteLine("Pokémon capturés :");
        foreach (var Techmons in joueur.TechmonsCaptures)
        {
            Console.WriteLine(Techmons.Name);
        }*//*
    }
}

*/

using Jeu_Console_C_;
using System;
using System.Collections.Generic;

class Program
{
    static Game jeu;
    static Player joueur;
    static List<Techmons> equipeAdverse = new List<Techmons>();
    static Random rnd = new Random();

    static void Main(string[] args)
    {
        InitialiserJeu();
        CreerJoueur();
        SelectionnerTechmonsJoueur();
        GenererEquipeAdverse();
        DemarrerCombat();
    }

    static void InitialiserJeu()
    {
        jeu = new Game();
        // Ici, tu peux ajouter des initialisations supplémentaires si nécessaire.
    }

    static void CreerJoueur()
    {
        Console.WriteLine("Bienvenue dans le jeu Techmon!");
        Console.Write("Entrez votre nom de joueur : ");
        string nomJoueur = Console.ReadLine();
        joueur = new Player(nomJoueur);
        Console.WriteLine($"Bonjour, {joueur.Name}!");
    }

    static void SelectionnerTechmonsJoueur()
    {
        // Exemple simplifié : le joueur sélectionne les deux premiers Techmons disponibles.
        // Dans un cas réel, tu voudrais afficher une liste et laisser le joueur choisir.
        joueur.CapturerTechmon(jeu.TechmonsDisponibles[0]);
        joueur.CapturerTechmon(jeu.TechmonsDisponibles[1]);
        Console.WriteLine("Vous avez sélectionné vos Techmons pour le combat.");
    }

    static void GenererEquipeAdverse()
    {
        // Exemple simplifié : choisir deux Techmons aléatoires comme adversaires.
        while (equipeAdverse.Count < 2)
        {
            Techmons adversaire = jeu.TechmonsDisponibles[rnd.Next(jeu.TechmonsDisponibles.Count)];
            if (!equipeAdverse.Contains(adversaire))
            {
                equipeAdverse.Add(adversaire);
            }
        }
        Console.WriteLine("Une équipe adverse a été générée.");
    }

    static void DemarrerCombat()
    {
        Console.WriteLine("Le combat commence !");
        jeu.DemarrerCombat(joueur, equipeAdverse); // Assure-toi que Game contient une méthode DemarrerCombat.

        // Après le combat
        Console.WriteLine("Le combat est terminé. Appuyez sur la touche Échap pour quitter ou une autre touche pour continuer.");
        if (Console.ReadKey(true).Key == ConsoleKey.Escape)
        {
            return; // Quitte le programme si la touche Échap est pressée.
        }
        // Ici, tu pourrais retourner au menu principal ou permettre d'autres actions post-combat.
    }
}
