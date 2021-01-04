using System;
using System.Collections.Generic;
using System.Text;

namespace UD07.dto
{
    class Persona2
    {
        private string nombre;
        private int edad;
        private string dni;// Numero + letra
        private const char sexo = 'h';
        private double peso;
        private string altura;

        public Persona2()
        {
        }

        public Persona2(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public Persona2(string nombre, int edad, string dni, double peso, string altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
            this.peso = peso;
            this.altura = altura;
        }
    }
}
