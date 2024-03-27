using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeu_Console_C_
{
    internal class Items : GameObject
    {
        public Items(string name, string effect, int quantity) : base(name, effect, quantity)
        {
    
        }

        public virtual void UseItem(Techmons techmons)
        {
            Console.WriteLine($"Vous utilisé {Name} et {Effect} sur {techmons.Name}");
        }

        public virtual void UsePotion(Techmons techmons)
        {
            techmons.Health += 20;
            Console.WriteLine($"Vous utilisé {Name} et restaure 20 PV à {techmons.Name}. Sa maintenant de {techmons.Health} PV");
        }
    }

    internal class Potion : Items
    {
        public Potion(string name, string effect, int quantity) : base(name, effect, quantity)
        {
        }
    }
}