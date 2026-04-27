namespace Library
{
    /// <summary>
    /// Representa un item de ataque Daga, aporta
    /// un valor de daño de ataque del personaje
    /// </summary>
    public class Dagger
    {
        public int Damage {get; set;}
        public Dagger( int damage)
        {
            this.Damage = damage ;
        }
    }
}