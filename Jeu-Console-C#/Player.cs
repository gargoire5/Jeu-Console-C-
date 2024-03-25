using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeu_Console_C_
{
    public class Player
    {
        public string Name { get; set; }
        public List<Techmons> TechmonsCaptures { get; set; }

        public Player(string name)
        {
            Name = name;
            TechmonsCaptures = new List<Techmons>();
        }
        public void CapturerTechmon(Techmons techmon)
        {
            TechmonsCaptures.Add(techmon);
            Console.WriteLine($"{Name} a capturé {techmon.Name}!");
        }

        /* public void CapturerTechmons(Techmons Techmons)
         {
             TechmonsCaptures.Add(Techmons);
             Console.WriteLine($"{Name} a capturé {Techmons.Name}!");
         }*/
    }
}



