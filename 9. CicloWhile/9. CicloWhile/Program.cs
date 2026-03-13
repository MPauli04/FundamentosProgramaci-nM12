using System;

namespace _9.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int contador = 1;
            int acumulador = 0;

            while (contador <= 5)
            {
                acumulador += contador;
                Console.WriteLine($"Contador: {contador}, Acumulador: {acumulador}");
                contador++;
            }
            Console.WriteLine($"La suma de los cinco primeros números enteros es: {acumulador}" );*/

            /*int numero = 0;
            int acumulador = 1;
            int contador = 1;

            Console.WriteLine($"Ingrese el número que desea convertir en factorial: {numero}");
            numero = int.Parse(Console.ReadLine());

            while (contador <= numero)
            {
                acumulador = acumulador * contador;
                contador++;
            }
            Console.WriteLine($"El factorial de {numero} es: {acumulador}");*/

            int numero = 0;
            int acumulador = 1;
            int contador = 1;

            Console.WriteLine("Ingrese el número para calcular el factorial:");
            numero = int.Parse(Console.ReadLine());

            // El ciclo debe ir desde 1 hasta el número ingresado
            while (contador <= numero)
            {
                // CAMBIO: Multiplicamos por 'contador', no por 'numero'
                acumulador = acumulador * contador;

                // El contador sube (1, 2, 3...) hasta llegar al número
                contador++;
            }

            Console.WriteLine($"El factorial de {numero} es: {acumulador}");
        }
    }
}
