using System;

namespace _18.EjercicioArreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*18.Llenar un arreglo con 15 palabras ingresadas por teclado, luego invertir el contenido del arreglo
               y mostrar por pantalla los elementos del arreglo original y los elementos del arreglo invertido.*/

            string[] palabrasOriginal = new string[15];

            Console.WriteLine("Por favor, ingresa 15 palabras:");

            
            for (int i = 0; i < palabrasOriginal.Length; i++)
            {
                Console.Write($"Palabra {i + 1}: ");
                palabrasOriginal[i] = Console.ReadLine();
            }

            
            string[] palabrasInvertidas = (string[])palabrasOriginal.Clone();

            
            Array.Reverse(palabrasInvertidas);

            
            Console.WriteLine("\n--- Arreglo Original ---");
            Console.WriteLine(string.Join(", ", palabrasOriginal));

            Console.WriteLine("\n--- Arreglo Invertido ---");
            Console.WriteLine(string.Join(", ", palabrasInvertidas));

        }
    }
}
