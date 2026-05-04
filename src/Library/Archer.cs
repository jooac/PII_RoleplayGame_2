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
    public class Archer : IPersonaje
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
        private Bow bow ;
        private Helmet helmet ;
        public Archer (string name)
        {
            this.Name = name;
            this.Health = 100;

            bow = new Bow(50);
            helmet = new Helmet(50);
        }
        public int DefenseValue
        {
            get{return this.helmet.Defense;}
        }
        public int AttackValue
        {
            get{return this.bow.Damage;}
        }
        public void ReceiveAttack (int power)
        {
            int remainingDamage = power - this.DefenseValue;
            if (remainingDamage <= 0)
            {
                this.helmet.ReduceDefense(power);
            }   
            else
            {
                this.helmet.ReduceDefense(this.DefenseValue); 
                this.Health -= remainingDamage;
            }
            if (this.Health < 0)
            {
                this.Health = 0;
            }
        }
        public void ReceiveAttack(IPersonaje enemy)
        {
            this.ReceiveAttack(enemy.AttackValue);
        }
    }
}