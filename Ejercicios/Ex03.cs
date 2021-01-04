using System;
using System.Collections.Generic;
using System.Text;

namespace UD07
{
    class Ex03
    {
        public static void Ex_03()
        {
            Operaciones o1 = new Operaciones(10, 5);

            Operaciones.Suma(o1.num1, o1.num2);
            Operaciones.Resta(o1.num1, o1.num2);
            Operaciones.Multi(o1.num1, o1.num2);
            Operaciones.Divi(o1.num1, o1.num2);
        }
    }
}
