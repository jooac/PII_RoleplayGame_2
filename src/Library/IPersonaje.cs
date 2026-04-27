namespace Library {
    public interface IPersonaje
    {
        string Name {get;}
        int Health {get;}

        void RecieveAttack(IPersonaje enemy);
        
    }
}