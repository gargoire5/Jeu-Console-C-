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
    }
}