using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public class Spell
    {
        public int AttackValue {get;}
        public int DefenseValue {get;}

        public Spell(string name, int power)
        {
            this.AttackValue = power;
            this.DefenseValue = power / 2; // El valor de defensa es la mitad del valor de ataque
        }
    }
}