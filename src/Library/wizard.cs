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

        public void RecieveAttack(IPersonaje enemy)
        {
            ReceiveAttack(enemy);
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
            ReceiveAttack(enemy);
        }
        

        public void Cure()
        {
            Health = 100;
        }
        
    }
}