using System;
using System.Dynamic;

namespace Ucu.Poo.RolePlayGame
{
    public class Axe
    {
        private int attack;
        public int Attack
        {
            get { return attack; } 
            set { attack = value; }
        }
        public Axe(int attack)
        {
            this.Attack = attack;
        }
    }
}