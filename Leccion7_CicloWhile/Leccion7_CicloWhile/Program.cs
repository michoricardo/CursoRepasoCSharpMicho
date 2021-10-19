using System;

namespace Leccion7_CicloWhile
{
    class leccion7
    {
        static void Main(string[] args)
        {
            int numero = 1;
            while (numero < 5)
            {
               Console.WriteLine("antes: " + numero);
                numero++;
                Console.WriteLine("despues: " + numero);
            }
        }
    }
}
