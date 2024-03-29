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
            int restoredHealth = 20;

            /*if (techmons.Health < techmons.MaxHeath)
            {
                restoredHealth = Math.Min(techmons.MaxHeath - techmons.Health, restoredHealth);

                techmons.Health += restoredHealth;

                Console.WriteLine($"La potion a restauré {restoredHealth} HP à {techmons.Name}");
            }
            else
            {
                Console.WriteLine($"{techmons.Name} n'a pas besoin de restauré ces HP");
            }*/

        }
    }

    internal class Potion : Items
    {
        public Potion(string name, string effect, int quantity) : base(name, effect, quantity)
        {
        }
    }
}
