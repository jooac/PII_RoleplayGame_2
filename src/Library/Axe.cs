namespace Library
{
    public class Axe : IAttackItem
    {
        public int AttackValue { get; private set; }

        public Axe(int attackValue)
        {
            this.AttackValue = attackValue;
        }
    }
}