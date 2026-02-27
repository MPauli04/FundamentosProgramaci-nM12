using System;
namespace _6.CondicionalesAninadados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1;
            double nota2;
            double nota3;
            double promedio;

            // Solicitar las 3 calificaciones
            Console.Write("Ingrese la primera calificación: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la segunda calificación: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la tercera calificación: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            // Calcular el promedio
            promedio = (nota1 + nota2 + nota3) / 3;

            // Mostrar el promedio
            Console.WriteLine($"\nEl promedio es: {promedio:F2}");

            // Condicionales anidados para determinar el mensaje
            if (promedio >= 9.5 && promedio <= 10.0)
            {
                Console.WriteLine("Excelente");
            }
            else if (promedio >= 8.5 && promedio <= 9.4)
            {
                Console.WriteLine("Muy bien");
            }
            else if (promedio >= 7.5 && promedio <= 8.4)
            {
                Console.WriteLine("Bien");
            }
            else
            {
                Console.WriteLine("Error: el promedio no está en los rangos establecidos.");
            }

        }
    }
}
