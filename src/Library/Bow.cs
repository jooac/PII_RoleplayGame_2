using System;
using System.Dynamic;

namespace Ucu.Poo.RolePlayGame
{
    public class Bow
    {
        private int attack;
        public int Attack 
        {
            get{return attack;} set{attack = value;}
        }
        public Bow (int attack)
        {
            this.Attack = attack;
        }
    }
}