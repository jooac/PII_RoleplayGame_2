using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public class SpellsBook
    {
        private ICollection<Spell> spells;
        public ICollection<Spell> Spells {get{return spells;}}
        public int AttackValue
        {
            get
            {
                return Spells.Sum(spell => spell.AttackValue);
            }
        }
        public int DefenseValue
        {
            get
            {
                return spells.Sum(s => s.DefenseValue);
            }
        }
        public SpellsBook()
        {
            spells = new List<Spell>();
            spells.Add(new Spell(10,5));
        }
    }
}