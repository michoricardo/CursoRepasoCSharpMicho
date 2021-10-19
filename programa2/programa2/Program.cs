using System;

namespace programa2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 100;
            int numero2 = 20;

            if(numero1 < numero2)
            {
                Console.WriteLine("Ya me acorde de los if");
            }
            else
            {
                Console.WriteLine("El valor mayor es: " + numero1);
            }
        }
    }
}
