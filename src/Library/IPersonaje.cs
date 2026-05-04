namespace Library {
    public interface IPersonaje
    {
        string Name {get;}
        int Health {get;}
        int AttackValue {get;}
        void ReceiveAttack(IPersonaje enemy);
    }
}