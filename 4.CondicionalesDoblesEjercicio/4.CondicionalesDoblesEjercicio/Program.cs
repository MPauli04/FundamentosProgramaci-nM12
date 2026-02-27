using System;

namespace _4.CondicionalesDoblesEjercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pedir un número entero al usuario//

            Console.Write("Ingresa un número entero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Verificar si el número es positivo, negativo o cero
            if (numero > 0)
            {
                Console.WriteLine("El número es positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("El número es negativo.");
            }
            else
            {
                Console.WriteLine("El número es cero.");
            }
        }
    }
}
