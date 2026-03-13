using System;


namespace _10.EjercicioWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int acumulador = 0;
            int numero = 0; 
            Console.WriteLine("Ingrese un numero entero positivo: ");
            numero = int.Parse(Console.ReadLine());

            while (numero >= 0)
            { 
                acumulador += numero;
                Console.WriteLine("Ingrese un numero entero positivo: ");
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"La suma de los numeros ingresados es: {acumulador}");
        }
    }
}
