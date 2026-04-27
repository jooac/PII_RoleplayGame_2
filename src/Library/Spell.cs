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

        public Spell(int attackValue, int defenseValue)
        {
            AttackValue = attackValue;
            DefenseValue = defenseValue;
        }
    }
}