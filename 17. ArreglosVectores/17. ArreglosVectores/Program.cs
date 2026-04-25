using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.ArreglosVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] numeros = new int[5]; //El rango de este vector es 5 y va de 0 a 4
            numeros[0] = 10; //Posición 1, indice 0, valor 10
            numeros[1] = 20; //Posición 2, indice 1, valor 20
            numeros[2] = 30; //Posición 3, indice 2, valor 30
            numeros[3] = 40; //Posición 4, indice 3, valor 40
            numeros[4] = 50; //Posición 5, indice 4, valor 50

            //numeros[5] = 60; //Posición 6, indice 5, valor 60 (fuera del rango del vector que es 5)//

            //cada posicion se trata como una varible (o sea numeros en este vcaso)

            Console.WriteLine($"El valor almacenado en la posición 3, con indice 2 es: {numeros[2]}");

            string[] nombres = new string[5]; //manera de inicializar vectores de tipo string (y tambien para cualquier tipo de dato), el rango es 5 y va de 0 a 4

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese el nombre para guardar en la posición {i + 1} con indice {i}:");

                nombres[i] = Console.ReadLine();
            }*/

            /*char[] simbolos = new char[] { '#', '%', '?', '|', 'Q', 'ñ', '&', '9', '*' };

            //Recorrer vector para recuperar los datos almacenados en él
            Console.Clear();

            for (int i = 0; i < simbolos.Length; i++)
            {
                Console.Write(simbolos[i] + " | ");
            }
*/
           /* Crear un arrelgo llamdado "numeros" de 100 elemntos asignar el número 10 en cada una de las posiciones del arreglo.
            Leer el contenido de cada elemnto y escribirlo en pantalla.*/

            /*int[] numeros = new int[100];
            
            for (int i = 0; i < 100; i++)
            {
                numeros[i] = 10;
                Console.Write(numeros[i] + " |");
            }*/

           /* LLene un arreglo con 15 números ingresados por teclado. Una vez registrado el total de los valores, muestre en pantalla
            todos los elementos del arreglo. Finalmente, determine cual es el número mayor y cual es el número menor junto con la posicion que ocupa
            cada uno dentro del arreglo.*/

            int [] numeros = new int[15];
            int numeroMayor = 0;
            int numeroMenor = 0;
            int posicionMayor = 0;
            int posicionMenor = 0;

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine($"Ingrese el número para guardar en la posición {i + 1} con indice {i}:");

                numeros[i] = int.Parse(Console.ReadLine());

                if (numeros[i] > numeroMayor)
                {
                    numeroMayor = numeros[i];
                    posicionMayor = i;
                }

                if (numeros[i] < numeroMenor)
                {
                    numeroMenor = numeros[i];
                    posicionMenor = i;
                }

            }
            
            Console.WriteLine("\nContenido del arreglo:");
            for (int i = 0; i < 15; i++)
            {
                Console.Write($"[{numeros[i]}] ");
            }

            Console.WriteLine($"\n\nEl mayor es {numeroMayor} en el índice {posicionMayor}");
            Console.WriteLine($"El menor es {numeroMenor} en el índice {posicionMenor}");
        }
    }
}
