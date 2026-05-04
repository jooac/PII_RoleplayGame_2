//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using System.Security.Cryptography.X509Certificates;
using Library;

namespace Ucu.Poo.RolePlayGame
{
    /// <summary>
    /// Programa principal.
    /// </summary>
    public static class Program
    {
        public static void Main()
        {
            Wizard wizard1 = new Wizard("Nacho");
            Elve elve1 = new Elve("Legolas");
            Archer archer1 = new Archer("Leonardo");
            Dwarf dwarf1 = new Dwarf("Joaco");
            Shield shield1 = new Shield(10);
            Axe axe1 = new Axe(15);
            Spell spell1 = new Spell(20, 5);
            Staff staff1 = new Staff(10, 10);
            SpellsBook spellsBook1 = new SpellsBook();
            spell1 = new Spell(20, 5);
            staff1 = new Staff(10, 10);
            
            Console.WriteLine($"El mago {wizard1.Name} tiene {wizard1.Health} puntos de vida.");
            Console.WriteLine($"El elfo {elve1.Name} tiene {elve1.Health} puntos de vida.");
            Console.WriteLine($"El arquero {archer1.Name} tiene {archer1.Health} puntos de vida.");
            Console.WriteLine($"El enano {dwarf1.Name} tiene {dwarf1.Health} puntos de vida."); 

            //wizard1.ReceiveAttack(30);
            wizard1.ReceiveAttack(elve1.AttackValue);
            Console.WriteLine($"El mago {wizard1.Name} tiene {wizard1.Health} puntos de vida después de recibir un ataque de 30 puntos.");  
            Console.WriteLine($"El mago {wizard1.Name} tiene un valor de ataque de {wizard1.AttackValue}.");
            Console.WriteLine($"El mago {wizard1.Name} tiene un valor de defensa de {wizard1.DefenseValue}.");
            wizard1.Cure();
            wizard1.ReceiveAttack(elve1.AttackValue);
            Console.WriteLine($"El mago {wizard1.Name} tiene {wizard1.Health} puntos de vida después de recibir un ataque de 50 puntos.");
            Console.WriteLine($"El mago {wizard1.Name} tiene {wizard1.Health} puntos de vida después de curarse.");
            

        }
    }

}
