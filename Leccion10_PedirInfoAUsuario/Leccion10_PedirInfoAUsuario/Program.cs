using System;

namespace Leccion10_PedirInfoAUsuario
{
    class Leccion10
    {
        static void Main(string[] args)
        {
            string nombreUsuario = "";
            Console.WriteLine("Favor de poner su nombre");
            nombreUsuario = Console.ReadLine();
            Console.WriteLine("Juguemos a las sumas vato: " + nombreUsuario + "\n");
            Console.WriteLine("Ingresa un numero \n");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa OTRO \n");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int resultado = n1 + n2;
            Console.WriteLine("La suma es: " + resultado);



        }
    }
}
