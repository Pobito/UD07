using System;
using System.Collections.Generic;
using System.Text;

namespace UD07
{
    class Ex02
    {
        public static void Ex_02()
        {
            Empleado e1 = new Empleado("adrian", 2500);

            Empleado.DatosEmp(e1.nombre, e1.sueldo);
            Empleado.ComprovarSueldo(e1.sueldo);
        }
    }
}
