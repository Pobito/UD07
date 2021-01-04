using System;
using System.Collections.Generic;
using System.Text;

namespace UD07
{
    class Operaciones
    {
        public int num1 { get; set; }
        public int num2 { get; set; }

        public Operaciones(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        
        public static void Suma (int num1, int num2)
        {
            Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
        }
        public static void Resta(int num1, int num2)
        {
            Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
        }
        public static void Multi(int num1, int num2)
        {
            Console.WriteLine(num1 + " x " + num2 + " = " + (num1 * num2));
        }
        public static void Divi(int num1, int num2)
        {
            Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
        }
    }
}
