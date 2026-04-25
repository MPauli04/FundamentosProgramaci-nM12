using System;
using System.Security.Cryptography;

namespace TallerVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1.Escribir un algoritmo que permita llenar un vector[15] con números enteros, y luego
             encuentre y muestre el valor máximo y mínimo de los números ingresados.  */


            /* int[] numeros = new int[15];
             int numeroMayor = 0;
             int numeroMenor = 0;
             int posicionMayor = 0;
             int posicionMenor = 0;

             for (int i = 0; i < numeros.Length; i++) 
             {
                 Console.Write($"Ingrese el número {i + 1}: ");
                 numeros[i] = int.Parse(Console.ReadLine());

                 if (i == 0) {
                     numeroMayor = numeros[i];
                     numeroMenor = numeros[i];
                 } else {
                     if (numeros[i] > numeroMayor) {
                         numeroMayor = numeros[i];
                         posicionMayor = i;
                     }
                     if (numeros[i] < numeroMenor) {
                         numeroMenor = numeros[i];
                         posicionMenor = i;
                     }
                 }
             }

             Console.WriteLine($"El número mayor es: {numeroMayor} ");
             Console.WriteLine($"El número menor es: {numeroMenor} ");*/

            /*2.Escribir un algoritmo que permita:
                a.Crear dos vectores del mismo tamaño.
                b.Llenarlos con números.
                c.Comparar posición por posición.
                d.Indicar cuántos elementos son iguales*/

            /* 
              int tamaño = 5;
              int[] vector1 = new int[tamaño];
              int[] vector2 = new int[tamaño];
              int contadorIguales = 0;

              Console.WriteLine($"Ingresa {tamaño} números para el primer vector:");
              for (int i = 0; i < tamaño; i++)
              {
                  Console.Write($"Vector 1 - Posición {i}: ");
                  vector1[i] = int.Parse(Console.ReadLine());
              }

              Console.WriteLine($"\nIngresa {tamaño} números para el segundo vector:");
              for (int i = 0; i < tamaño; i++)
              {
                  Console.Write($"Vector 2 - Posición {i}: ");
                  vector2[i] = int.Parse(Console.ReadLine());
              }

              for (int i = 0; i < tamaño; i++)
              {
                  if (vector1[i] == vector2[i])
                  {
                      contadorIguales++;
                  }
              }

              Console.WriteLine("La cantidad de elementos iguales es: " + contadorIguales);
  */


            /* 3.Escribe un algoritmo que permita ingresar caracteres en un vector, y luego invierta el
             orden de los elementos del vector. Se deben mostrar lo dos vectores. */


            /*int tamaño = 6;
            char[] vectorOriginal = new char[tamaño];
            char[] vectorInvertido = new char[tamaño];

            Console.WriteLine($"Ingresa {tamaño} caracteres para el vector:");
            for (int i = 0; i < tamaño; i++)
            {
                Console.Write($"Posición {i}: ");
                vectorOriginal[i] = Console.ReadKey().KeyChar;
                Console.WriteLine(); 
            }

            int j = 0;
            for (int i = tamaño - 1; i >= 0; i--)
            {
                vectorInvertido[j] = vectorOriginal[i];
                j++;
            }

            Console.WriteLine("\n--- Vector Original ---");
            for (int i = 0; i < tamaño; i++)
            {
                Console.Write($"[{vectorOriginal[i]}] ");
            }

            Console.WriteLine("\n\n--- Vector Invertido ---");
            for (int i = 0; i < tamaño; i++)
            {
                Console.Write($"[{vectorInvertido[i]}] ");
            }
            Console.WriteLine();*/


            /*4.Crea un algoritmo que llene un vector[20] con números enteros positivos aleatorios entre
              0 y 50.Luego le debe pedir al usuario un número para buscar en el vector. Si encuentra el
              número, se debe mostrar en pantalla: la posición en que se encuentra el número, y el
              vector resaltando el número en un color diferente.Si no se encuentra el número, se debe
              devolver y mostrar - 1.*/

            int[] vector = new int[20];
            Random aleatorio = new Random();
            int posicionEncontrada = -1;

            for (int i = 0; i < 20; i++)
            {
                vector[i] = aleatorio.Next(0, 51);
            }

            Console.Write("Ingrese el número que desea buscar (0-50): ");
            int numeroBuscado = int.Parse(Console.ReadLine());

            for (int i = 0; i < 20; i++)
            {
                if (vector[i] == numeroBuscado)
                {
                    posicionEncontrada = i;
                    break;
                }
            }

            // 4. Mostrar resultados
            if (posicionEncontrada != -1)
            {
                Console.WriteLine($"\nEl número se encuentra en la posición: {posicionEncontrada}");
                Console.WriteLine("Vector:");

                for (int i = 0; i < 20; i++)
                {
                    if (i == posicionEncontrada)
                    {

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"[{vector[i]}] ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write($"{vector[i]} ");
                    }
                }
                Console.WriteLine();
            }
            else
            {

                Console.WriteLine("\n-1");
                Console.WriteLine("El número no se encuentra en el vector.");
            }

        }
    }
    
}
