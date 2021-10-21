using System;

namespace Leccion14_OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 4;

            if (num1 == 5 && num2 == 4)
            {
                Console.WriteLine("Condicion del AND cumplida \n");
            }
            if (num1 == 3 || num2 == 2)
            {
                Console.WriteLine("Condicion del OR cumplida \n");
            }
            bool opcion = true;
            if (!opcion == false)
            {
                Console.WriteLine("La opcion es diferente a falso");
            }

            else
            {
                Console.WriteLine("Ninguna condicion se cumplio");
            }
            
        }
    }
}
