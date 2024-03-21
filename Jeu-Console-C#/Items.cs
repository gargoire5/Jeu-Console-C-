using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeu_Console_C_
{
    internal class Items : GameObject
    {
        public Items(string name, string effect) : base(name, effect)
        {

        }

        public virtual void PotionUse()
        {
            
            Health += 20;

            //Console.WriteLine($"Health Upgraded by {Health});
        }
    }
}