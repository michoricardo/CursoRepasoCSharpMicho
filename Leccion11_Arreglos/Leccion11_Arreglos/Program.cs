using System;

namespace Leccion11_Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Para hacer un arreglo, necesitas ver que tipo de datos va a almacenar el arreglo y tambien definir su longitud
            int[] arreglo1 = new int[4];
            Console.WriteLine(arreglo1.Length); //para ver la longitud de ese arreglo
            arreglo1[0] = 3;
            arreglo1[1] = 4;
            arreglo1[2] = 37;
            arreglo1[3] = 30;

            for (int cont = 0; cont < arreglo1.Length; cont++)
            {
                Console.WriteLine(arreglo1[cont]);
            }

        }
    }
}
