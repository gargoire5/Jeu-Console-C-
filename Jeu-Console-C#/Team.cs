using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeu_Console_C_
{
    internal class Team
    {
        private List<Techmons> techmons = new List<Techmons>();

        public void AddPokemon(Techmons techmon)
        {
            if (techmons.Count < 6) 
            {
                techmons.Add(techmon);
                Console.WriteLine($"Le Pokémon {techmon.Name} a été ajouté à l'équipe.");
            }
            else
            {
                Console.WriteLine("L'équipe est déjà complète. Vous ne pouvez pas ajouter de nouveaux Pokémon.");
            }
        }

        
        public void RemovePokemon(Techmons techmon)
        {
            techmons.Remove(techmon);
            Console.WriteLine($"Le Pokémon {techmon.Name} a été retiré de l'équipe.");
        }

        
        public void DisplayTeam()
        {
            Console.WriteLine("Équipe Pokémon :");
            foreach (var techmon in techmons)
            {
                Console.WriteLine($"- {techmon.Name}");
            }
        }
    }
}