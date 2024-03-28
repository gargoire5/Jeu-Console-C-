using Scenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeu_Console_C_
{
    internal class Team
    {
        private List<Techmons> techmons = new List<Techmons>();
        private int selectedTechmonsIndex = 0;

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

        public void ClearTeamDisplay()
        {
            Console.Clear();
        }


        public void RemovePokemon(Techmons techmon)
        {
            techmons.Remove(techmon);
            Console.WriteLine($"Le Pokémon {techmon.Name} a été retiré de l'équipe.");
        }

        public void RemoveHp(Techmons techmons, int damage)
        {
            techmons.Health -= damage;

            if(techmons.Health < 0)
            {
                techmons.Health = 0;
            }
        }

        public void MoveSelectionUp()
        {
            selectedTechmonsIndex = Math.Max(0, selectedTechmonsIndex - 1);
        }

        public void MoveSelectionDown()
        {
            selectedTechmonsIndex = Math.Min(techmons.Count - 1, selectedTechmonsIndex + 1);
        }

        public Techmons GetSelectedTechmons()
        {
            if (techmons.Count == 0)
            {
                Console.WriteLine("L'équipe est vide.");
                return null;
            }

            // Vérifie que l'index sélectionné est dans les limites de l'équipe
            if (selectedTechmonsIndex >= 0 && selectedTechmonsIndex < techmons.Count)
            {
                return techmons[selectedTechmonsIndex];
            }
            else
            {
                Console.WriteLine("Aucun Pokémon sélectionné.");
                return null;
            }
        }

        public void DisplayTeam()
        {
            Console.WriteLine("Équipe Pokémon :");
            Console.WriteLine();

            for (int i = 0; i < techmons.Count; i++)
            {

                if (i == selectedTechmonsIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }

                Techmons CurrentTechmon = techmons[i];
                Console.WriteLine($"{i + 1}. {CurrentTechmon.Name} ({CurrentTechmon.Health}/{CurrentTechmon.MaxHeath}) HP {CurrentTechmon.Type} {CurrentTechmon.Niveau}");

                Console.ResetColor();
            }
        }
    }
}