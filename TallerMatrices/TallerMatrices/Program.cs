using System;

namespace TallerMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {/*1.Desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre por
            pantalla la suma de los elementos de cada columna.*//*

            int filas = 10;  
            int columnas = 20;
            int[,] matriz = new int[filas, columnas];

            Random rnd = new Random();

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++) 
                {
                    matriz[i, j] = rnd.Next(1, 20);
                }

            }
            for (int j = 0; j < columnas; j++) // Primero recorremos columnas
            {
                int sumaColumna = 0;
                for (int i = 0; i < filas; i++) // Luego recorremos las filas de esa columna
                {
                    sumaColumna += matriz[i, j];
                }

                Console.WriteLine($"Columna {j+1}: {sumaColumna}");
            }


            Console.ReadLine();*/


            /*2.Desarrollar un programa que crea una matriz de n filas * m columnas, el usuario ingresa
            caracteres en cada posición de la matriz hasta llenarla. El programa debe intercambiar la
            primera fila con la última fila de la matriz. Al final se debe imprimir la matriz original, y la
            matriz con el intercambio de filas.*/


            /*Console.Write("Ingrese el número de filas (n): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de columnas (m): ");
            int m = int.Parse(Console.ReadLine());

            char[,] matriz = new char[n, m];


            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < m; c++)
                {
                    Console.Write($"Ingrese caracter para la posición [{f},{c}]: ");
                    // Leemos la línea y tomamos solo el primer caracter
                    matriz[f, c] = Console.ReadKey().KeyChar;
                    Console.WriteLine(); // Salto de línea para que no se amontone
                }
            }


            Console.WriteLine("\n--- Matriz Original ---");
            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < m; c++)
                {
                    Console.Write(matriz[f, c] + " ");
                }
                Console.WriteLine();
            }


            for (int c = 0; c < m; c++)
            {
                char temporal = matriz[0, c];
                matriz[0, c] = matriz[n - 1, c];
                matriz[n - 1, c] = temporal;
            }


            Console.WriteLine("\n--- Matriz con Filas Intercambiadas ---");
            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < m; c++)
                {
                    Console.Write(matriz[f, c] + " ");
                }
                Console.WriteLine();

            }
*/

            /*3.Crear un algoritmo que cuente la frecuencia de cada número del 1 al 10 en una matriz de
                    5x5 llena de números aleatorios.
                    El algoritmo debe permitir: 
                     Usa la función Random para generar los números aleatorios.
                     Crea un arreglo adicional para almacenar la frecuencia de cada número.
                     Mostrar la matriz y el nuevo arreglo con la frecuencia de cada número*/

            /* int[,] matriz = new int[5, 5];
             int[] frecuencias = new int[10]; 
             Random aleatorio = new Random();

             for (int f = 0; f < 5; f++) 
             {
                 for (int c = 0; c < 5; c++) 
                 {
                     int numeroCualquiera = aleatorio.Next(1, 11); 
                     matriz[f, c] = numeroCualquiera;

                     frecuencias[numeroCualquiera - 1]++;
                 }
             }


             Console.WriteLine("--- Matriz Aleatoria 5x5 ---");
             for (int f = 0; f < 5; f++)
             {
                 for (int c = 0; c < 5; c++)
                 {
                     Console.Write(matriz[f, c].ToString().PadLeft(4));
                 }
                 Console.WriteLine();
             }


             Console.WriteLine("\n--- Frecuencia de Números ---");
             for (int i = 0; i < frecuencias.Length; i++)
             {
                 Console.WriteLine($"Número {i + 1}: se repite {frecuencias[i]} veces");
             }*/

            /*4.Crea un algoritmo que represente un tablero de juego de 5x5 donde se coloquen 3 "X" en
            posiciones aleatorias.Luego, el algoritmo le debe permitir al usuario intentar adivinar la
            posición de una "X".*/


            
            char[,] tablero = new char[5, 5];
            Random aleatorio = new Random();

            
            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    tablero[f, c] = '.';
                }
            }

            
            int xColocadas = 0;
            while (xColocadas < 3)
            {
                int filaA = aleatorio.Next(0, 5);
                int colA = aleatorio.Next(0, 5);

               
                if (tablero[filaA, colA] != 'X')
                {
                    tablero[filaA, colA] = 'X';
                    xColocadas++;
                }
            }

            
            Console.WriteLine("--- ¡Adivina dónde está la X! ---");
            Console.WriteLine("El tablero es de 5x5 (Coordenadas de 0 a 4)");

            Console.Write("Ingresa la FILA (0-4): ");
            int filaUsuario = int.Parse(Console.ReadLine());

            Console.Write("Ingresa la COLUMNA (0-4): ");
            int colUsuario = int.Parse(Console.ReadLine());

            Console.WriteLine("\nRevelando posición...");

            if (tablero[filaUsuario, colUsuario] == 'X')
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("¡FELICIDADES! Encontraste una de las X.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Lo siento, ahí no había nada.");
            }

            Console.WriteLine("\nTablero Final:");
            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    if (f == filaUsuario && c == colUsuario)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write($" {tablero[f, c]} ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write($" {tablero[f, c]} ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
