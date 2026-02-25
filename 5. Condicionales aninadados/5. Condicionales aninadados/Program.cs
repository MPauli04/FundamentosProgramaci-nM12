using System;

namespace _5.Condicionales_aninadados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Diseñar un algoritmo que lea tres numeros A, B y C visualice en pantalla el valor más grande. el usuario debe ingresar;
             tres valores diferentes.*/
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            Console.WriteLine("Ingrese el primer numero: ");
            num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número");
            num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer número");
            num3 = Int32.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine($"El numero mayor es: {num1}");
                }
                else
                {
                    Console.WriteLine($"El numero mayor es: {num3}");
                }

            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine($"El numero mayor es: {num2}");
                }
                else
                {
                    Console.WriteLine($"El numero mayor es: {num3}");
                }
            }
        }
    }
}
