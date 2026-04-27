namespace Library
{
    /// <summary>
    /// Representa un item de ataque Arco, aporta
    /// un valor de daño de ataque del personaje
    /// </summary>
    public class Axe
    {
        public int Damage {get; set;}
        public Axe( int damage)
        {
            this.Damage = damage ;
        }
    }
}