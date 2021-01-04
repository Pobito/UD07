using System;
using System.Collections.Generic;
using System.Text;

namespace UD07
{
    class Ex05
    {
        public static void Ex_05()
        {
            Libro l1 = new Libro("Cervantes", "Don quijote", "España");

            Console.WriteLine(l1.autor);
            Console.WriteLine(l1.titulo);
            Console.WriteLine(l1.ubicacion);
        }
    }
}
