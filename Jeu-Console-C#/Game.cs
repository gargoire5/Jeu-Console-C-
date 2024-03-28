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

            // Affiche les informations de chaque Pokémon
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

                // joueur choisit attaque
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

                // Vérifie si combat continue avant tour de l'adversaire
                if (!combatTermine)
                {
                    Console.WriteLine("\n--- Tour de l'Adversaire ---");
                    Attaque attaqueAdversaire = techmonAdversaire.ChoisirAttaqueAdversaire(); //choisi aléatoirement
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
using System.Xml.Linq;

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
            
            Techmons gianni = new Techmons("Gianni", 100, TypeElement.Css, 1);
            gianni.AjouterAttaque(new Attaque("Le poulet est délicieux", 0, 50));
            gianni.AjouterAttaque(new Attaque("Purple", 40, 0, 0));//Attaque
            gianni.AjouterAttaque(new Attaque("Domain Expansion", 0, 10, 0.4f));//Boost def
            gianni.AjouterAttaque(new Attaque("I am Atomic", 70, 0, 0));//Attaque
            TechmonsDisponibles.Add(gianni);

            
            Techmons ewen = new Techmons("Ewen", 100, TypeElement.Python, 1);
            ewen.AjouterAttaque(new Attaque("Dictature du délégué", 0, 10, 0.35f));//Debuff ou buff
            ewen.AjouterAttaque(new Attaque("Perdu batard", 50, 0, 0));//Attaque
            TechmonsDisponibles.Add(ewen);

            
            Techmons enzo = new Techmons("Enzo", 100, TypeElement.C, 1);
            enzo.AjouterAttaque(new Attaque("Mais elle a 12ans", 60, 0, 0));// Attaque
            enzo.AjouterAttaque(new Attaque("Je suis un faux cul", 0, 10, 0.5f));// Buff
            TechmonsDisponibles.Add(enzo);

            Techmons grégoire = new Techmons("Grégoire", 100, TypeElement.Css, 1);
            grégoire.AjouterAttaque(new Attaque("Rentre Dans Ton Pays", 40, 0, 0));
            grégoire.AjouterAttaque(new Attaque("Je construirai un mur", 0, 80, 0.05f));
            TechmonsDisponibles.Add(grégoire);

            Techmons kyllian = new Techmons("Kyllian", 100, TypeElement.Python, 1);
            kyllian.AjouterAttaque(new Attaque("Je suis coach", 0, 10, 0.35f));
            kyllian.AjouterAttaque(new Attaque("Dans ton crane", 65, 0, 0));
            TechmonsDisponibles.Add(kyllian);

            Techmons benjamin = new Techmons("Benjamin", 100, TypeElement.C, 1);
            benjamin.AjouterAttaque(new Attaque("Been Shilling", 0, 10, 0.5f));
            benjamin.AjouterAttaque(new Attaque("Gojo Satoru", 0, 60, 0.35f));
            benjamin.AjouterAttaque(new Attaque("Fatal Tacle", 70, 0, 0));
            TechmonsDisponibles.Add(benjamin);
        }
        public void AfficherTechmonsDisponibles()
        {
            Console.WriteLine("Choisissez un Techmon :");
            for (int i = 0; i < TechmonsDisponibles.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {TechmonsDisponibles[i].Name}");
            }
        }

        public Techmons ChoisirTechmon()
        {
            AfficherTechmonsDisponibles();
            Console.WriteLine("Entrez le numéro du Techmon choisi:");
            int choix = Convert.ToInt32(Console.ReadLine()) - 1; // -1 pour correspondre à l'indexation de la liste (démarrant à 0)

            if (choix >= 0 && choix < TechmonsDisponibles.Count)
            {
                return TechmonsDisponibles[choix];
            }
            else
            {
                Console.WriteLine("Choix invalide, veuillez réessayer.");
                return ChoisirTechmon(); 
            }
        }

        public void DemarrerCombat(Player joueur, List<Techmons> equipeAdverse)
        {
            Console.WriteLine("Le combat commence !");

            int indexTechmonJoueurActuel = 0;
            int indexTechmonActuelAdversaire = 0;
            Techmons techmonJoueur = joueur.TechmonsCaptures[indexTechmonJoueurActuel];
            Techmons techmonAdversaire = equipeAdverse[indexTechmonActuelAdversaire];

            while (indexTechmonJoueurActuel < joueur.TechmonsCaptures.Count && indexTechmonActuelAdversaire < equipeAdverse.Count)
            {

                Console.WriteLine($"Tour de {joueur.Name} || {techmonJoueur.Name} || {techmonJoueur.Health} Pv || Niv {techmonJoueur.Niveau} || Type : {techmonJoueur.Type} ||:");
                Console.WriteLine("1. Combattre");
                Console.WriteLine("2. Fuir");
                Console.WriteLine("3. Inventaire");
                Console.Write("Choisissez une action: ");
                int action = int.Parse(Console.ReadLine());

                switch (action)
                {
                    case 1: // Combattre
                        
                       
                        
                        break;
                    case 2: // Fuir
                        Console.WriteLine($"{joueur.Name} a choisi de fuir le combat.");
                        return; // Termine le combat
                    case 3: // Inventaire
                        Console.WriteLine("Ouverture de l'inventaire...");
                        // Ajoute ici la logique pour gérer l'inventaire
                        break;
                    default:
                        Console.WriteLine("Action non valide. Veuillez choisir une option valide.");
                        continue; // Reprend le tour sans avancer dans le combat
                }

                
                Console.WriteLine($"Tour de {joueur.Name} avec {techmonJoueur.Name}:");
                techmonJoueur.AfficherAttaques();
                Console.WriteLine("Choisissez une attaque:");
                int choix = int.Parse(Console.ReadLine()) - 1;
                Attaque attaqueChoisie = techmonJoueur.Attaques[choix];
                techmonJoueur.Attaquer(techmonAdversaire, attaqueChoisie);

                if (techmonAdversaire.Health <= 0)
                {
                    //Console.WriteLine($"{techmonAdversaire.Name} est vaincu !");
                    indexTechmonActuelAdversaire++;
                    if (indexTechmonActuelAdversaire < equipeAdverse.Count)
                    {
                        techmonAdversaire = equipeAdverse[indexTechmonActuelAdversaire];
                        Console.WriteLine($"{techmonAdversaire.Name} entre dans le combat !");
                    }
                }

                // Vérifier si le combat est terminé avant le tour de l'adversaire
                if (indexTechmonActuelAdversaire >= equipeAdverse.Count) break;

                // Tour de l'adversaire
                Console.WriteLine($"Tour de l'adversaire || {techmonAdversaire.Name} || {techmonAdversaire.Health} Pv || Niv {techmonAdversaire.Niveau} || Type : {techmonAdversaire.Type} ||:");
                Random rnd = new Random();
                int indexAttaqueAdversaire = rnd.Next(techmonAdversaire.Attaques.Count);

                // Sélectionne l'attaque basée sur l'index aléatoire
                attaqueChoisie = techmonAdversaire.Attaques[indexAttaqueAdversaire];

                // L'adversaire attaque le Techmon du joueur avec l'attaque sélectionnée
                techmonAdversaire.Attaquer(techmonJoueur, attaqueChoisie); // L'adversaire choisit la première attaque pour simplifier
                
                

                if (techmonJoueur.Health <= 0)
                {
                    //Console.WriteLine($"{techmonJoueur.Name} est vaincu !");
                    indexTechmonJoueurActuel++;
                    if (indexTechmonJoueurActuel < joueur.TechmonsCaptures.Count)
                    {
                        techmonJoueur = joueur.TechmonsCaptures[indexTechmonJoueurActuel];
                        Console.WriteLine($"{joueur.Name} envoie {techmonJoueur.Name} au combat !");
                    }
                }

                // Vérifier si le combat est terminé après le tour de l'adversaire
                if (indexTechmonJoueurActuel >= joueur.TechmonsCaptures.Count)
                {
                    Console.WriteLine("Vous avez perdu le combat...");
                    break;
                }
            }

            if (indexTechmonActuelAdversaire >= equipeAdverse.Count)
            {
                Console.WriteLine("Vous avez gagné le combat !");
            }
        }

    }
}
