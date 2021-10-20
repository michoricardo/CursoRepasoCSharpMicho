using System;

namespace Leccion12_Funciones
{
    class leccion12
    {
        static void Main(string[] args)//funcion principal
        {
            Console.WriteLine("Favor de poner su nombre\n");
            string nombre=Console.ReadLine();
            saludar(nombre);
            asciiFunction();
            int num = 3;
            
            //int numero = devolverNum();
            //Console.WriteLine("Ejecutando la funcion de num: " + numero);
            //numero sera 2
            parametroPorValor(num);
            Console.WriteLine("Imprimiendo parametro por valor \n" + num);
            Console.WriteLine("---------------------------------------\n");
            parametroPorRef(ref num);
            Console.WriteLine("Imprimiendo parametro por referencia \n" + num);
        }
        static void asciiFunction()
        {
            Console.WriteLine(@"(             )
 `--(_   _)--'
      Y-Y
     /@@ \
    /     \
    `--'.  \             ,
        |   `.__________/) ");
            Console.WriteLine("\n\n");
        }
        static void parametroPorValor(int num)
        {
            num *= 2;
            // el valor de num se afecta solo en esta funcion
         
            
        }
        static void parametroPorRef(ref int num)
        {
            num *= 2;
           
            //el valor de num se afecta globalmente
        }

        static void saludar(string neim) { //static porque esta funcion pertenece al mismo bloque que la clase leccion12 del proyecto leccion12_funciones
            Console.WriteLine("Hellow madafakar " + neim + "\n");
        }
        static int devolverNum()
        {
            int num1 = 1;
            int num2 = 1;
            int result = num1 + num2;
            //regresa un numero
            return result;
        }
    }
}
