using System;
using System.Collections.Generic;
using System.Text;

namespace UD07
{
    class Ex06
    {
        public static void Ex_06()
        {
            Coche c1 = new Coche("Audi", "A1", 420, 8.23);

            Console.WriteLine(c1.marca);
            Console.WriteLine(c1.modelo);
            Console.WriteLine(c1.cilindrada);
            Console.WriteLine(c1.potencia);
        }
    }
}
