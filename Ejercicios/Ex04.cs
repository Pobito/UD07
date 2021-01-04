using System;
using System.Collections.Generic;
using System.Text;

namespace UD07
{
    class Ex04
    {
        public static void Ex_04()
        {
            Persona p1 = new Persona();

            Console.WriteLine("Dime tu nombre");
            p1.nombre = Console.ReadLine();
            Persona.Saludar(p1.nombre);
        }
    }
}
