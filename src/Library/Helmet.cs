namespace Library
{
    public class Helmet : IDefenseItem
    {
        public int DefenseValue { get; private set; }

        public Helmet(int defenseValue)
        {
            this.DefenseValue = defenseValue;
        }
    }
}