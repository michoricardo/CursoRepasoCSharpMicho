using System;

namespace Leccion8_DoWhile
{
    class Leccion8
    {
        static void Main(string[] args)
        {
            int numero = 1;
            Console.WriteLine("Inicia el do while\n");
            do
            {
                Console.WriteLine(numero + " -----Do while \n");
                numero++;
            } while (numero < 4);
            Console.WriteLine(numero + "Fin do while \n");
        }
    }
}
