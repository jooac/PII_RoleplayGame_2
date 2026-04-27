using System;
using System.Runtime.CompilerServices;

namespace Library
{
    /// <summary>
    /// Esta clase representa a un personaje "Arquero".
    /// Tiene la responsabilidad de tener nombre, vida y metodos de ataque/defensa.
    /// Por este motivo cumple con SRP y Expert.
    /// Además colabora con Dagger y Shield, para atacar y defenderse.
    /// </summary>
    public class Dwarf
    {
        private string name;
        public string Name
        {
            get{return name;} set{name = value;}
        }
        private int health;
        public int Health
        {
            get{return health;} set{health = value;}
        }
        private Axe axe ;
        private Shield shield ;
        public Dwarf (string name)
        {
            this.Name = name;
            this.Health = 100;

            axe = new Axe(50);
            shield = new Shield(50);
        }
        public int DefenseValue
        {
            get{return this.shield.Defense;}
        }
        public int AttackValue
        {
            get{return this.axe.Damage;}
        }
        public void ReceiveAttack (int power)
        {
            int remaininDamage = power - this.DefenseValue;
            if (remaininDamage <= 0)
            {
                this.shield.ReduceDefense(power);
            }
            else
            {
                this.shield.ReduceDefense(this.DefenseValue); 
                this.Health -= remaininDamage;
            }
            if (this.Health < 0)
            {
                this.Health = 0;
            }
        }
    }
}