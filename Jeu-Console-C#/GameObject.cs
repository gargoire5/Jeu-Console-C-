using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu_Console_C_
{

    public enum TypeElement
    {
        Css,
        Python,
        C
    }

    internal class GameObject
    {
        public string Name { get; protected set; }
        public int Health { get; set; }
        public int MaxHeath { get; set; }
        public int Quantity { get; set; } = 0;
        public int Niveau { get; protected set; }
        public int Experience { get; protected set; }
        public int ExpPourNiveauSuivant { get; protected set; }
        public TypeElement Type { get; protected set; }
        public List<Attaque> Attaques { get; protected set; }
        public int ModificateurDegatsSuivant { get; protected set; }
        public float ReductionDegatsRecus { get; protected set; }
        public string Effect { get; protected set; }

        public GameObject(string name, int health, int maxheath, TypeElement type, int niveau)
        {
            Name = name;
            Type = type;
            Health = health;
            MaxHeath = maxheath;
            Niveau = niveau;
            Experience = 0;
            ExpPourNiveauSuivant = 100;
            Attaques = new List<Attaque>();
            ModificateurDegatsSuivant = 0;
            ReductionDegatsRecus = 0;
        }

        public GameObject(string name)
        {
            Name = name;
        }

        public GameObject(string name, string effect, int quantity)
        {
            Name = name;
            Effect = effect;
            Quantity = quantity;
        }

        public GameObject(string name, TypeElement type, int niveau) : this(name)
        {
        }
    }
}
