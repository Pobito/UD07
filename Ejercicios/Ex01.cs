using System;
using System.Collections.Generic;
using System.Text;

namespace UD07
{
    class Ex01
    {
        public static void Ex_01()
        {
            Alumno a1 = new Alumno("adrian", 19);

            Alumno.PedirEdad(a1.nombre, a1.edad);
            Alumno.MayorEdad(a1.edad);

        }
    }
}
