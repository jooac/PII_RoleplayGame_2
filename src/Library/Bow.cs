using System;
using System.Dynamic;

namespace Library
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