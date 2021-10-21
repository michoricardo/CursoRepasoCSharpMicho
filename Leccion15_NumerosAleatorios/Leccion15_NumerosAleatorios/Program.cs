using System;

namespace Leccion15_NumerosAleatorios
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numerorandom = new Random(); //es un objeto de tipo Random
            int primerNumero = numerorandom.Next(0, 400); //el next retorna un entero no negativo entre un rango
            Console.WriteLine("\nEl numero calculado entre 0 y 400 es: " + primerNumero);

            double segundoNumero = numerorandom.NextDouble(); //Imprime double sin el rango
            Console.WriteLine("\nUn numero decimal sin rango es este: " + segundoNumero);
        }
    }
}
