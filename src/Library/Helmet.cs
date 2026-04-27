using System;
using System.Dynamic;

namespace Library
{
    public class Helmet
    {
        private int defense;
        public int Defense
        {
            get{return defense;} set{defense = value;}
        }
        public Helmet (int defense)
        {
            this.Defense = defense;
        }
    }
}