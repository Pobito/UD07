using System;
using System.Collections.Generic;
using System.Text;

namespace UD07.dto
{
    class Serie
    {
        public const int NUMTEMP_DEF = 3;
        public const bool ENTREGA_DEF = false;
        public string titulo { get; set; }
        public int numTemp { get; set; }
        public bool entrega { set; get; }
        public string genero { get; set; }
        public string creador { set; get; }

        public Serie()
        {
            this.numTemp = NUMTEMP_DEF;
        }

        public Serie(string titulo, string creador)
        {
            this.titulo = titulo;
            this.numTemp = NUMTEMP_DEF;
            this.creador = creador;
        }

        public Serie(string titulo, int numTemp, bool entrega, string genero, string creador)
        {
            this.titulo = titulo;
            this.numTemp = numTemp;
            this.entrega = entrega;
            this.genero = genero;
            this.creador = creador;
        }
    }
}
