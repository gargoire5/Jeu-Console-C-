using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Jeu_Console_C_
{
    public class Player
    {
        public int playerX { get; set; }
        public int playerY { get; set; }
        public string Name { get; set; }
        public Player(int X, int Y, string name)
        {
            playerX = X;
            playerY = Y;
            Name = name;
            TechmonsCaptures = new List<Techmons>();

        }
        public List<Techmons> TechmonsCaptures { get; set; }
        public List<Techmons> TechmonsChoisisPourLeCombat { get; private set; } = new List<Techmons>();

        public void CapturerTechmon(Techmons techmon)
        {
            TechmonsCaptures.Add(techmon);
            Console.WriteLine($"{Name} a capturé {techmon.Name}!");
        }
        public void AjouterTechmonPourLeCombat(Techmons techmon)
        {
            TechmonsChoisisPourLeCombat.Add(techmon); // Ajoute le Techmon à la liste des choix pour le combat
        }
        /* public void CapturerTechmons(Techmons Techmons)
         {
             TechmonsCaptures.Add(Techmons);
             Console.WriteLine($"{Name} a capturé {Techmons.Name}!");
         }*/
    }
}



