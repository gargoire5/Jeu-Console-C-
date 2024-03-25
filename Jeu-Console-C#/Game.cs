/*using Jeu_Console_C_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeu_Console_C_
{
    public class Game
    {
        public Game() { }

        public int Health { get; protected set; }
        public void Team()
        {
            Techmons Gianni = new Techmons("Gianni", 20, TypeElement.Css, 5);
            Techmons Ewen = new Techmons("Ewen", 45, TypeElement.Python, 12);
            Techmons Enzo = new Techmons("Enzo", 12, TypeElement.C, 1);
            Techmons Kyllian = new Techmons("Kyllian", 62, TypeElement.Python, 17);
            Techmons Benjamin = new Techmons("Benjamin", 26, TypeElement.C, 7);
            Techmons Grégoire = new Techmons("Grégoire", 82, TypeElement.Css, 21);

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
            List<Techmons> pokemons = new List<Techmons> { Gianni, Ewen, Enzo, Kyllian, Benjamin, Grégoire };
            foreach (var pokemon in pokemons)
            {
                pokemon.AfficherInformations();
            }
        }
        public void Items()
        {
            Items Potions = new Items("Potion", "Rend 20 PV à un Pokemon");
            Items TechBalls = new Items("Techball", "Permet de capturer un pokemon");
        }

        // Dans Game.cs
        public void DemarrerCombat(Player joueur, List<Techmons> equipeAdverse)
        {
            int techmonActifJoueur = 0;
            int techmonActifAdversaire = 0;
            bool combatTermine = false;

            Console.WriteLine("Le combat commence!");

            while (!combatTermine)
            {
                Console.WriteLine("\n--- Tour du Joueur ---");
                Techmons techmonJoueur = joueur.TechmonsCaptures[techmonActifJoueur];
                Techmons techmonAdversaire = equipeAdverse[techmonActifAdversaire];

                // Le joueur choisit une attaque
                Attaque attaqueJoueur = techmonJoueur.ChoisirAttaque();
                techmonJoueur.Attaquer(techmonAdversaire, attaqueJoueur);

                if (techmonAdversaire.Health <= 0)
                {
                    Console.WriteLine($"{techmonAdversaire.Name} est vaincu!");
                    techmonActifAdversaire++;
                    if (techmonActifAdversaire >= equipeAdverse.Count)
                    {
                        Console.WriteLine("Vous avez gagné le combat!");
                        combatTermine = true;
                        break;
                    }
                }

                // Vérifie si le combat continue avant de passer au tour de l'adversaire
                if (!combatTermine)
                {
                    Console.WriteLine("\n--- Tour de l'Adversaire ---");
                    Attaque attaqueAdversaire = techmonAdversaire.ChoisirAttaqueAdversaire(); // Assumer cette méthode choisit aléatoirement
                    techmonAdversaire.Attaquer(techmonJoueur, attaqueAdversaire);

                    if (techmonJoueur.Health <= 0)
                    {
                        Console.WriteLine($"{techmonJoueur.Name} est vaincu!");
                        techmonActifJoueur++;
                        if (techmonActifJoueur >= joueur.TechmonsCaptures.Count)
                        {
                            Console.WriteLine("Vous avez perdu le combat!");
                            combatTermine = true;
                        }
                    }
                }
            }
        }

    }
}

*//*public class Game
{
    public List<Techmons> TechmonsDisponibles { get; private set; } = new List<Techmons>();
    public List<Items> ItemsDisponibles { get; private set; } = new List<Items>();

    public Game()
    {
        InitialiserTechmons();
        InitialiserItems();
    }

    private void InitialiserTechmons()
    {
        // Ajoute les Techmons à la liste TechmonsDisponibles ici...
    }

    private void InitialiserItems()
    {
        // Ajoute les items à la liste ItemsDisponibles ici...
    }
}*/

using System;
using System.Collections.Generic;

namespace Jeu_Console_C_
{
    public class Game
    {
        public List<Techmons> TechmonsDisponibles { get; private set; }

        public Game()
        {
            TechmonsDisponibles = new List<Techmons>();
            InitialiserTechmons();
        }

        private void InitialiserTechmons()
        {
            // Gianni et ses attaques
            Techmons gianni = new Techmons("Gianni", 100, TypeElement.Css, 1);
            gianni.AjouterAttaque(new Attaque("Le poulet est délicieux", 0, 50));
            gianni.AjouterAttaque(new Attaque("Purple", 40, 0, 0));//Attaque
            gianni.AjouterAttaque(new Attaque("Domain Expansion", 0, 10, 0.4f));//Boost def
            gianni.AjouterAttaque(new Attaque("I am Atomic", 70, 0, 0));//Attaque
            TechmonsDisponibles.Add(gianni);

            // Ewen et ses attaques
            Techmons ewen = new Techmons("Ewen", 120, TypeElement.Python, 1);
            ewen.AjouterAttaque(new Attaque("Dictature du délégué", 0, 10, 0.35f));//Debuff ou buff
            ewen.AjouterAttaque(new Attaque("Perdu batard", 50, 0, 0));//Attaque
            TechmonsDisponibles.Add(ewen);

            // Continuer à initialiser les autres Techmons ici...
        }

        public void DemarrerCombat(Player joueur, List<Techmons> equipeAdverse)
        {
            Console.WriteLine("Le combat commence !");

            // Simplification : Utilisation du premier Techmon de chaque équipe pour le combat
            Techmons techmonJoueur = joueur.TechmonsCaptures[0];
            Techmons techmonAdversaire = equipeAdverse[0];

            while (techmonJoueur.Health > 0 && techmonAdversaire.Health > 0)
            {
                // Tour du joueur
                Console.WriteLine($"Tour de {joueur.Name}:");
                techmonJoueur.AfficherAttaques();
                Console.WriteLine("Choisissez une attaque:");
                int choix = int.Parse(Console.ReadLine()) - 1;
                Attaque attaqueChoisie = techmonJoueur.Attaques[choix];
                techmonJoueur.Attaquer(techmonAdversaire, attaqueChoisie);

                if (techmonAdversaire.Health <= 0)
                {
                    Console.WriteLine($"{techmonAdversaire.Name} est vaincu !");
                    break; // Sortie de la boucle si l'adversaire est vaincu
                }

                // Tour de l'adversaire (simplifié pour cet exemple)
                Console.WriteLine($"Tour de l'adversaire ({techmonAdversaire.Name}):");
                attaqueChoisie = techmonAdversaire.Attaques[0]; // Simplification : l'adversaire choisit toujours la première attaque
                techmonAdversaire.Attaquer(techmonJoueur, attaqueChoisie);

                if (techmonJoueur.Health <= 0)
                {
                    Console.WriteLine($"{techmonJoueur.Name} est vaincu !");
                }
            }

            if (techmonJoueur.Health > 0)
            {
                Console.WriteLine("Vous avez gagné le combat !");
            }
            else
            {
                Console.WriteLine("Vous avez perdu le combat...");
            }
        }
    }
}
