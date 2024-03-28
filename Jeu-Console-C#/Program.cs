/*using Jeu_Console_C_;
using System;


{
    static void Main(string[] args)
    {
        var sceneManager = new SceneManager();
        sceneManager.Update();
    }


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

        // Exemple de comment capturer un Pokémon
        //Techmons Gianni = new Techmons("Gianni", 20, TypeElement.Css, 5);
        //joueur.CapturerTechmons(Gianni);

        // afficher Pokémon capturé
        Console.WriteLine("Pokémon capturés :");
        foreach (var Techmons in joueur.TechmonsCaptures)
        {
            Console.WriteLine(Techmons.Name);
        }
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
        // initialisations
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
        Console.WriteLine("Choisissez deux Techmons pour votre équipe (entrez le numéro) :");

        for (int i = 0; i < jeu.TechmonsDisponibles.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {jeu.TechmonsDisponibles[i].Name}");
        }

        int choix1 = ObtenirChoixJoueur(jeu.TechmonsDisponibles.Count);
        int choix2 = ObtenirChoixJoueur(jeu.TechmonsDisponibles.Count, choix1);

        joueur.CapturerTechmon(jeu.TechmonsDisponibles[choix1 - 1]);
        joueur.CapturerTechmon(jeu.TechmonsDisponibles[choix2 - 1]);

        Console.WriteLine("Vous avez sélectionné vos Techmons pour le combat.");
    }

    static int ObtenirChoixJoueur(int max, int exclusion = -1)
    {
        int choix;
        do
        {
            Console.WriteLine("Entrez le numéro de votre choix :");
            if (!int.TryParse(Console.ReadLine(), out choix) || choix < 1 || choix > max || choix == exclusion)
            {
                Console.WriteLine("Choix invalide, veuillez réessayer.");
                choix = -1; // la boucle doit continue en cas de choix invalide.
            }
        }
        while (choix == -1);
        return choix;
    }

    static void GenererEquipeAdverse()
    {
        //deux Techmons aléatoires comme adversaires.
        Random rnd = new Random();
        while (equipeAdverse.Count < 2)
        {
            Techmons adversaire = jeu.TechmonsDisponibles[rnd.Next(jeu.TechmonsDisponibles.Count)];
            if (!equipeAdverse.Contains(adversaire))
            {
                equipeAdverse.Add(adversaire);
                Console.WriteLine($"Adversaire choisi : {adversaire.Name}");
            }
        }
        Console.WriteLine("Une équipe adverse a été générée.");
        /*foreach (Techmons techmon in equipeAdverse)
        {
            Console.WriteLine(techmon.Name);
        }*/
    }

    static void DemarrerCombat()
    {
        //Console.WriteLine("Le combat commence !");
        jeu.DemarrerCombat(joueur, equipeAdverse); 

        // Après le combat
        Console.WriteLine("Le combat est terminé. Appuyez sur la touche Échap pour quitter ou une autre touche pour continuer.");
        if (Console.ReadKey(true).Key == ConsoleKey.Escape)
        {
            return; // Quitte le programme si Echap est appuyer.
        }
        //  retourner au menu principal ou permettre d'autres actions post-combat(capturer pokemon )???
    }
}
