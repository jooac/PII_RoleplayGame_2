using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public class SpellsBook
    {
        ICollection<Spell> Spells {get;}
        public int AttackValue {get;}
        public int DefenseValue {get;}
    }
}