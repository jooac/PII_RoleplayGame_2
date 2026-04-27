using System;

namespace Ucu.Poo.RolePlayGame
{
    public class Dwarf
    {
        private string name; 
        public string Name
        {
            get { return name; } 
            set { name = value; }
        }

        private int health;
        public int Health
        {
            get { return health; } 
            set { health = value; }
        }
        
        private int attackvalue;
        public int AttackValue
        {
            get { return attackvalue; } 
            set { attackvalue = value; }
        }

        private int defensevalue;
        public int DefenseValue
        {
            get { return defensevalue; } 
            set { defensevalue = value; }
        }

        private Axe axe;
        private Shield shield;
        private Helmet helmet;

        public void RecieveAttack(int power)
        {
            if (DefenseValue >= power)
            {
                DefenseValue -= power;
            }
            else
            {                
                int remainingDamage = power - DefenseValue;
                DefenseValue = 0;
                Health -= remainingDamage;

                if (Health < 0)
                {
                    Health = 0;
                }
            }
        }

        private void UpdateStats()
        {
            AttackValue = axe.Attack;
            DefenseValue = shield.Defense + helmet.Defense;
        }

        public void Cure()
        {
            Health = 100;
        }

        public Dwarf(string name)
        {
            this.Name = name;
            this.Health = 100;
            this.AttackValue = 0;
            this.DefenseValue = 0;

            axe = new Axe(50);
            shield = new Shield(50);
            helmet = new Helmet(50);

            UpdateStats();
        }
    }
}