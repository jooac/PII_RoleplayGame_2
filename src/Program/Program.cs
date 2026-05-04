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
            Wizard wizard1 = new Wizard("El mago Nacho");
            Console.WriteLine(wizard1.Name, wizard1.Health, wizard1.AttackValue, wizard1.DefenseValue );
            

        }
    }

}
