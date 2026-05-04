namespace Library
{
    public class Helmet : IDefenseItem
    {
        public int DefenseValue { get; private set; }

        public Helmet(int defenseValue)
        {
            this.DefenseValue = defenseValue;
        }

        public void reduceDefense(int amount)
        {
            this.DefenseValue -= amount;
            if (this.DefenseValue < 0)
            {
                this.DefenseValue = 0;
            }
        }
    }
}