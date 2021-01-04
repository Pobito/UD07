using System;
using System.Collections.Generic;
using System.Text;

namespace UD07
{
    class Persona
    {
        public string nombre { get; set; }

        public Persona()
        {
            this.nombre = nombre;
        }

        public static void Saludar(string nombre)
        {
            Console.WriteLine("Hola, soy " + nombre);
        }
    }
}
