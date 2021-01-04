using System;
using System.Collections.Generic;
using System.Text;

namespace UD07
{
    class Password
    {
        public const int LONG = 8;
        public int longitud { get; set; }
        public string contraseña { get; set; }

        public Password()
        {
            longitud = LONG;
        }

        public Password(int longitud)
        {
            this.longitud = longitud;
        }
        public int getLongitud()
        {
            return longitud;
        }
        public void setLongitud(int longitud)
        {
            this.longitud = longitud;
        }
        public String getContraseña()
        {
            return contraseña;
        }
        public String generaPassword()
        {
            String password = "";
            for (int i = 0; i < longitud; i++)
            {
                Random rnd = new Random();
                int eleccion = rnd.Next(1,4);

                if (eleccion == 1)
                {
                    char minusculas = (char)((int)rnd.Next() * (123 - 97) + 97);
                    password += minusculas;
                }
                else
                {
                    if (eleccion == 2)
                    {
                        char mayusculas = (char)((int)rnd.Next() * (91 - 65) + 65);
                        password += mayusculas;
                    }
                    else
                    {
                        char numeros = (char)((int)rnd.Next() * (58 - 48) + 48);
                        password += numeros;
                    }
                }
            }
            return password;
        }
    }
}
