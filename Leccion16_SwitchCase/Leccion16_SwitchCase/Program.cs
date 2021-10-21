using System;

namespace Leccion16_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Switch case con opcion de tipo caracter

            Console.WriteLine("\n Opcion a: Imprimir mi nombre:  ");
            Console.WriteLine("\n Opcion b: Imprimir mi apodo:  ");
            Console.WriteLine("\n Opcion c: Imprimir mi profesion:  ");

            char opc = Convert.ToChar(Console.ReadLine()); //se tiene que convertir a char

            switch(opc){
                case 'a':
                    Console.WriteLine("\nMi nombre es Ricardo ");
                    break;
                case 'b':
                    Console.WriteLine("\n Mi apodo es Micho ");
                    break;
                case 'c':
                    Console.WriteLine("\n Soy Inge ");
                    break;
                default:
                    Console.WriteLine("Pon una opcion valida, no seas nefasto(a) -.- ");
                    break;
            }

        }
    }
}
