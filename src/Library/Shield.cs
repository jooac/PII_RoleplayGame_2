namespace Library
{
    public class Shield : IDefenseItem
    {
        public int DefenseValue { get; private set; }

        public Shield(int defenseValue)
        {
            this.DefenseValue = defenseValue;
        }
    }
}