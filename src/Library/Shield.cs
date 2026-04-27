using System;
using System.Dynamic;

namespace Ucu.Poo.RolePlayGame
{
    public class Shield
    {
        private int defense;
        public int Defense
        {
            get {return defense;} set {defense = value;}
        }
        public Shield(int defense)
        {
            this.Defense = defense;
        }
    }
}