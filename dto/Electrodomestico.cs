using System;
using System.Collections.Generic;
using System.Text;

namespace UD07
{
    class Electrodomestico
    {
        public const string COLOR_DEF = "blanco";
        public const char CONSUM_DEF = 'F';
        public const double PRECIO_DEF = 100;
        public const double PESO_DEF = 5;

        public double precioBase {get; set;}
        public string color { get; set; }
        public char consumoEng { get; set; }
        public double peso { get; set; }

        public void comprobarColor(String color)
        {
            string[] colores = { "blanco", "negro", "rojo", "azul", "gris" };
            bool encontrado = false;

            for (int i = 0; i < colores.Length && !encontrado; i++)
            {

                if (colores[i].Equals(color))
                {
                    encontrado = true;
                }

            }

            if (encontrado)
            {
                this.color = color;
            }
            else
            {
                this.color = COLOR_DEF;
            }
        }
        public Electrodomestico()
        {
            this.precioBase = PRECIO_DEF;
            this.peso = PESO_DEF;
            this.consumoEng = CONSUM_DEF;
            this.color = COLOR_DEF;
        }
        
        public Electrodomestico(double precioBase, double peso, char consumoEnergetico, String color)
        {
            this.precioBase = precioBase;
            this.peso = peso;
            this.consumoEng = consumoEng;
            comprobarColor(color);
        }
        public Electrodomestico(double precioBase, double peso)
        {
            this.precioBase = precioBase;
            this.peso = peso;
        }
    }
}
