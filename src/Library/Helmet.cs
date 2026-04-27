using System;

namespace Library
{
    /// <summary>
    /// Representa un item de defensa Casco.
    /// Tiene un valor de defensa para reducir el daño recibido.
    /// </summary>
    public class Helmet
    {
        private int defense;
        public int Defense
        {
            get{return defense;} set{defense = value;}
        }
        public Helmet(int defense)
        {
            this.Defense = defense ;
        }
        public void ReduceDefense (int amount)
        {
            this.defense -= amount ;
            if (this.defense < 0)
            {
                this.defense = 0;
            }
        }
    }
}