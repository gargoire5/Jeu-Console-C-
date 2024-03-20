using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu_Console_C_
{
    internal class GameObject
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackDamage { get; set; }

        public GameObject (string name, int health, int attackDamage)
        {
            Name = name;
            Health = health;
            AttackDamage = attackDamage;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0)
            {
                Health = 0;
            }
        }

        public void Attack(GameObject target) 
        {
            target.TakeDamage(AttackDamage);
            Console.WriteLine($"{Name} attaque {target.Name} et inflige {AttackDamage} dégât");
        }
    }
}
