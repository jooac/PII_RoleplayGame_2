namespace Library
{
    public interface IItem
    {
    }

    public interface IAttackItem : IItem
    {
        int AttackValue { get; }
    }

    public interface IDefenseItem : IItem
    {
        int DefenseValue { get; }
    }
}