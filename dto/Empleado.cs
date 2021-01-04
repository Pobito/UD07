using System;
using System.Collections.Generic;
using System.Text;

namespace UD07
{
    class Empleado
    {
        public int sueldo { get; set; }
        public string nombre { get; set; }

        public Empleado(string nombre, int sueldo)
        {
            this.sueldo = sueldo;
            this.nombre = nombre;
        }
        public static void DatosEmp(string nombre, int sueldo)
        {
            Console.WriteLine("Hola " + nombre);
            Console.WriteLine("Tu sueldo es: " + sueldo);
        }
        public static void ComprovarSueldo(int sueldo)
        { 
            if (sueldo > 3000)
            {
                Console.WriteLine("Deves pagar impuestos");
            }
            else
            {
                Console.WriteLine("No deves pagar impuestos");
            }
        }
    }
}
