using System;

namespace ConsoleApp1 //Este es el del proyecto
{
    class Program //cada clase es como un programa
        // tipos de datos int, double (decimales normales), decimal (alta precision), char, string, bool
    {
        static void Main(string[] args)
        {// todo lo que esta entre estas llaves, se va a ejecutar
            int cajaEntero = 15;
            int cajaEnteroNegativo = -2;
            double numero1 = 4.5;
            decimal dinero = (decimal)250.445884;//(esto es castear la variable);
            char letra = 'R';
            string nombre = "richi el mejor"; // a diferencia de otros lenguajes, debe ser comilla doble en string
            bool verdis = true;
            Console.WriteLine(nombre);


            Console.WriteLine("Hello World!");
        }
    }
}
