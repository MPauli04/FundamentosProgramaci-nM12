using System;


namespace _19.Arreglos_Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[,] numeros = new int[2, 3]; //el primer numero es la cantidad de filas y el segundo numero es la cantidad de columnas

            numeros[0, 0] = 12;
            numeros[0, 1] = 13;
            numeros[0, 2] = 14;
            numeros[1, 0] = 15;
            numeros[1, 1] = 16;
            numeros[1, 2] = 17;

            string[,] nombres =
                        {
                                {"Juan Pedro", "Santiago"},
                                { "Matilde", "Susana"},
                                { "Laura", "Isabela"},
                        };
            //el rango es la multiplicacion de filas por columnas, en este caso 2*3=6

            //Recorrer matriz para llenarla 
            char[,] simbolos = new char[2, 5];

            for (int i = 0; i < 2; i++) //Recorre las filas
            {

                for (int j = 0; j < 5; j++) //recorre las columnas
                {
                    Console.WriteLine($"Ingrese el simbolo para la posicion [{i},{j}]");
                    simbolos[i, j] = char.Parse(Console.ReadLine());

                }
            }
            Console.Clear();

            //Recorrer matriz para recuperar los datos
            for (int i = 0; i < simbolos.GetLength(0); i++) //GetLength(0) devuelve la cantidad de filas
            {
                for (int j = 0; j < simbolos.GetLength(1); j++) //GetLength(1) devuelve la cantidad de columnas
                {
                    Console.Write($" | [{i},{j}]: {simbolos[i, j]} | ");
                }
                Console.WriteLine();
            }*/


            //Escribe un programa que realice la suma de dos matrices de dimensiones 2x3.

            /*Requisitos del programa:

            Solicita al usuario que ingrese los elementos de la primera matriz de 2 filas y 3 columnas.

            Solicita al usuario que ingrese los elementos de la segunda matriz de las mismas dimensiones(2x3).

            Calcula la matriz suma, resultado de sumar cada elemento correspondiente de las dos matrices.

            Muestra la matriz resultante de la suma en formato de matriz(2 filas, 3 columnas).*/

             int[,] matriz1 = new int[2, 3];
             int[,] matriz2 = new int[2, 3];
             int[,] sumaMatriz = new int[2, 3];

            for (int i = 0; i < 2; i++) //Recorre las filas
            {

                for (int j = 0; j < 3; j++) //recorre las columnas
                {
                    Console.WriteLine($"Ingrese el elemento para la posicion [{i},{j}] de la primera matriz:");
                    matriz1[i, j] = int.Parse(Console.ReadLine());

                }
            }

            for (int k = 0; k < 2; k++) //Recorre las filas
            {
                for (int l = 0; l < 3; l++) //recorre las columnas
                {
                    Console.WriteLine($"Ingrese el elemento para la posicion [{k},{l}] de la segunda matriz:");
                    matriz2[k, l] = int.Parse(Console.ReadLine());
                }
            }

            //Calcular la suma de las dos matrices

            Console.WriteLine("La matriz resultante de la suma es: ");

            for (int i = 0; i < 2; i++) //Recorre las filas
            {
                for (int j = 0; j < 3; j++) //recorre las columnas
                {
                    sumaMatriz[i, j] = matriz1[i, j] + matriz2[i, j];
                    Console.Write($" | [{i},{j}]: {sumaMatriz[i, j]} | ");
                }
                Console.WriteLine();
            }

            /*Desarrolla un algoritmo que realice las siguientes tareas:
            
                    Capturar los nombres de cuatro empleados ingresados por teclado.    

                    Para cada empleado, capturar los sueldos recibidos durante los últimos 3 meses.

                    Calcular y mostrar el total acumulado de sueldos que ha recibido cada empleado en ese período.

                    Identificar y mostrar el nombre del empleado con el mayor sueldo acumulado, junto con el monto total que recibio. */


            string[,] empleados = new string[4, 4];
                string[] nombresEmpleados = new string[4];
                float[] sueldosAcumulados = new float[4];
        }
    }
}
