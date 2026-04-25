using System;

namespace _15.CicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int acumulador = 0;

            for (int contador = 1; contador <= 5; contador++)
            {
                acumulador += contador;
            }

            Console.WriteLine($"La suma de los cinco primeros números enteros es {acumulador}");*/



            //Realizar un programa que permite obtener la factorial de un númnero entero ingresado por el teclado

            /*int numero = 0;
            int acumulador = 1;

            Console.WriteLine("Ingrese un número entero para calcular su factorial: ");
            numero = int.Parse(Console.ReadLine());

            for (int contador = 1; contador <= numero; contador++)
            {
                 acumulador = acumulador * contador;
            }

            Console.WriteLine($"la factorial del número ingresado es {acumulador}");*/


            /*Realizar un programa que permita imprimir por pantalla los números múltiplos de 5, el usuario debe ingresar por tecladdo
            el rango de números a evaluar*/

            /*int inicio = 0;
            int final = 0;

            Console.WriteLine("Ingrese el número de inicio del rango: ");
            inicio = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número final del rango: ");
            final = int.Parse(Console.ReadLine());

            Console.WriteLine("Los números múltiplos de 5 en el rango ingresado son: ");

            for (int contador = inicio; contador <= final; contador++)
            {
                if (contador % 5 == 0)
                {
                    Console.WriteLine($"{contador} es múltiplo de 5");
                }
                else if (contador % 5 != 0)
                {
                    Console.WriteLine("No hay números múltiplos de 5 en el rango ingresado");
                    break;
                }
                
            }*/

            //En un grupo de 100 alumnos se desea saber cuantos estudiantes son hombres y cuantas son mujeres, además se desea saber cuantos son mayores de edad y cuantos no.


            int hombres = 0;
            int mujeres = 0;
            int mayores = 0;
            int menores = 0;

            // Variables para capturar la entrada del usuario
            int genero = 0;
            int edad = 0;

            Console.WriteLine("--- Registro de 100 Alumnos ---");

            // 2. Ciclo FOR para repetir el proceso 100 veces
            for (int contador = 1; contador <= 5; contador++)
            {
                Console.WriteLine("Alumno número: " + contador);

                // Capturar Género
                Console.Write("Ingrese género (1 para Hombre, 2 para Mujer): ");
                genero = int.Parse(Console.ReadLine());

                if (genero == 1)
                {
                    hombres = hombres + 1;
                }
                else
                {
                    mujeres = mujeres + 1;
                }

                // Capturar Edad
                Console.Write("Ingrese la edad: ");
                edad = int.Parse(Console.ReadLine());

                if (edad >= 18)
                {
                    mayores = mayores + 1;
                }
                else
                {
                    menores = menores + 1;
                }

                Console.WriteLine("-------------------------------");
            }

            // 3. Mostrar resultados finales
            Console.WriteLine("RESULTADOS FINALES:");
            Console.WriteLine("Total de Hombres: " + hombres);
            Console.WriteLine("Total de Mujeres: " + mujeres);
            Console.WriteLine("Total de Mayores de edad: " + mayores);
            Console.WriteLine("Total de Menores de edad: " + menores);
        }
    }
}
