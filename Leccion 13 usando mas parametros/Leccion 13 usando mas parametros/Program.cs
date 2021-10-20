using System;

namespace Leccion_13_usando_mas_parametros
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            decimal num2 = (decimal)2.5; //castear el valor
            string hola = "hola!";
            string texto = "como estas?";
            Console.WriteLine("Hola desde el main");
            saludar(num1, num2, hola, texto);
        }

        static void saludar(int n1, decimal n2, string t1, string t2)
        {
            Console.WriteLine("el int n1:" + n1 + "\n");
            Console.WriteLine("el decimal n2:" + n2 + "\n");
            Console.WriteLine("el hola t1:" + t1 + "\n");
            Console.WriteLine("el texto t2:" + t2 + "\n");
        }

    }
}
