namespace Library
{
    /// <summary>
    /// Representa un item de ataque Arco, aporta
    /// un valor de daño de ataque del personaje
    /// </summary>
    public class Bow
    {
        public int Damage {get; set;}
        public Bow( int damage)
        {
            this.Damage = damage ;
        }
    }
}