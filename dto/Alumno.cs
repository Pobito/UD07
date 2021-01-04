using System;
using System.Collections.Generic;
using System.Text;

namespace UD07
{
    class Alumno
    {
        // Atributos
        public int edad { get; set; }
        public string nombre { get; set; }

        // Constructores
        public Alumno(string nombre, int edad)
        {
            this.edad = edad;
            this.nombre = nombre;
        }

        public static void PedirEdad(string nombre, int edad)
        {
            Console.WriteLine("Hola " + nombre);
            Console.WriteLine("Tu edad es: " + edad);
        }
        public static void MayorEdad(int edad)
        {
            if(edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad");
            }
            else
            {
                Console.WriteLine("No eres mayor de edad");
            }
        }
    }
}
