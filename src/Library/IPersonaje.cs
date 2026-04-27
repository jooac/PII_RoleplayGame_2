namespace Library {
    public interface IPersonaje
    {
        string Name {get;}
        int Health {get;}

        void Attack( IPersonaje enemy) ;
    }
}