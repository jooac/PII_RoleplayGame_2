namespace Library
{
    public class Dwarf
    {
        private int health = 100;

        public Dwarf(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public IAttackItem Axe { get; set; }

        public IDefenseItem Shield { get; set; }

        public IDefenseItem Helmet { get; set; }

        public int AttackValue
        {
            get
            {
                if (Axe != null)
                {
                    return Axe.AttackValue;
                }
                else
                {
                    return 0;
                }
            }
        }

        public int DefenseValue
        {
            get
            {
                int total = 0;

                if (Shield != null)
                {
                    total += Shield.DefenseValue;
                }

                if (Helmet != null)
                {
                    total += Helmet.DefenseValue;
                }

                return total;
            }
        }

        public int Health
        {
            get { return this.health; }
            private set { this.health = value < 0 ? 0 : value; }
        }

        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }

        public void Cure()
        {
            this.Health = 100;
        }
    }
}