using System;

namespace Leccion6_CondicionalStringChar
{
    class leccion6
    {
        static void Main(string[] args)
        {
            string texto = "Hola";
            string texto2 = "hola";
            //Condicional normal
            if (texto == texto2)
            {
                Console.WriteLine("Texto es igual a texto2 condicional normal");
            }
            else
            {
                Console.WriteLine("Los textos son diferentes condicional normal");
            }
            //Condicional con metodo del string
            if (texto.Equals(texto2))
            {
                Console.WriteLine("Texto es igual a texto2 condicional metodo string");
            }
            else
            {
                Console.WriteLine("Los textos son diferentes condicional metodo string");
            }

            //Condicional caracteres
            char car1 = 'R';
            char car2 = 'S';
            if (car1 == car2)
            {
                Console.WriteLine("son iguales");
            }
            else
            {
                Console.WriteLine("son diferentes");

            }
        }
    }
}
