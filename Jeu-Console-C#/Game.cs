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
            TechmonsDisponibles.Add(new Techmons("Techmon1", 100, TypeElement.Css, 1));
            TechmonsDisponibles.Add(new Techmons("Techmon2", 120, TypeElement.Python, 2));
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
            /*if (joueur == null || joueur.TechmonsCaptures == null || equipeAdverse == null)
            {
                Console.WriteLine("Erreur : Une référence null a été trouvée.");
                return; // Quitte la méthode pour éviter l'erreur
            }

            if (joueur.TechmonsCaptures.Count == 0 || equipeAdverse.Count == 0)
            {
                Console.WriteLine("Combat impossible à démarrer : un des joueurs n'a pas de Techmons.");
                return;
            }*/

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
                        // Ajoute ici l'inventaire
                        break;
                    default:
                        Console.WriteLine("Action non valide. Veuillez choisir une option valide.");
                        continue; // Reprend le tour sans avancer dans le combat
                }


                /*Console.WriteLine($"Tour de {joueur.Name} avec {techmonJoueur.Name}:");
                techmonJoueur.AfficherAttaques();
                Console.WriteLine("Choisissez une attaque:");
                int choix = int.Parse(Console.ReadLine()) - 1;
                Attaque attaqueChoisie = techmonJoueur.Attaques[choix];
                techmonJoueur.Attaquer(techmonAdversaire, attaqueChoisie);*/
                Console.WriteLine($"Tour de {joueur.Name} avec {techmonJoueur.Name} (PV: {techmonJoueur.Health}):");
                techmonJoueur.AfficherAttaques();
                int choix;
                Attaque attaqueChoisie;

                while (true) 
                {
                    Console.WriteLine("Choisissez une attaque:");
                    if (int.TryParse(Console.ReadLine(), out choix) && choix > 0 && choix <= techmonJoueur.Attaques.Count)
                    {
                        attaqueChoisie = techmonJoueur.Attaques[choix - 1]; // Les indices de liste commencent à 0
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Choix invalide. Veuillez sélectionner une attaque valide.");
                    }
                }

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
                attaqueChoisie = techmonAdversaire.Attaques[indexAttaqueAdversaire];               
                techmonAdversaire.Attaquer(techmonJoueur, attaqueChoisie); 
                

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
