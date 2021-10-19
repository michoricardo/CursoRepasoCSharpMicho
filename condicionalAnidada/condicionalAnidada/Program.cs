using System;

namespace condicionalAnidada
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;
            int num3 = 30;
            int num4 = 40;
        if(num1 == num2){
                Console.WriteLine("El numero "+ num1 + "Es igual a : " + num2);
            }
        else if(num1 == num3){
                Console.WriteLine("El numero " + num1 + "Es igual a : " + num3);
            }
        else if(num1 == num4)
            {
                Console.WriteLine("El numero " + num1 + "Es igual a : " + num4);
            }
            else
            {
                Console.WriteLine("El numero " + num1 + "no es igual a ningun numero");
            }
        }
    }
}
