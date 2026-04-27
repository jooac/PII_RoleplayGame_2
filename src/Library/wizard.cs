using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public class Wizard
    {
        public string Name{get;}
        public SpellsBook SpellsBook {get;}
        public Staff Staff{get;}
        public int AttackValue{get{ return SpellsBook.AttackValue + Staff.AttackValue;}}
        public int DefenseValue{get{ return SpellsBook.DefenseValue + Staff.DefenseValue;}}
        public int Health{get; private set;}

        public Wizard(string name)
        {
            Name = name;
            Health = 100;

            SpellsBook = new SpellsBook();
            Staff = new Staff(10,5);
            
        }

        public void ReceiveAttack(int power)
        {
            int remainingDamage = power - DefenseValue;
            if (remainingDamage > 0)
            {
                Health -= remainingDamage;
                if (Health < 0)
                {
                    Health = 0;
                }
            }
        }

        public void Cure()
        {
            Health = 100;
        }
        
    }
}