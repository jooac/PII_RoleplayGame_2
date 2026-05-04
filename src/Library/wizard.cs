using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public class Wizard : IPersonaje
    {
        public string Name{get;}
        public SpellsBook SpellsBook {get;}
        public Staff Staff{get;}
        public int AttackValue{get{ return SpellsBook.AttackValue + Staff.AttackValue;}}
        public int DefenseValue{get{ return SpellsBook.DefenseValue + Staff.DefenseValue;}}
        public int Health{get; private set;}

        public void ReceiveAttack(int power)
        {
            int remainingDamage = power - this.DefenseValue;
            if (remainingDamage <= 0)
            {
                this.Health -= power;
            }   
            
            if (this.Health < 0)
            {
                this.Health = 0;
            }
        }

        public Wizard(string name)
        {
            Name = name;
            Health = 100;

            SpellsBook = new SpellsBook();
            Staff = new Staff();
        }

        public void ReceiveAttack(IPersonaje enemy)
        {
            this.ReceiveAttack(enemy.AttackValue);
        }
        

        public void Cure()
        {
            this.Health = 100;
        }
        
    }
}