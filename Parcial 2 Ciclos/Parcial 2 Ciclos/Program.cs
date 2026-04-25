using System;

namespace Parcial_2_Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Un profesor tiene las calificaciones de 18 alumnos y necesita procesar la información para obtener un análisis general del curso.Las notas se encuentran en un rango de 0 a 10.
                 El programa debe realizar las siguientes operaciones:
                             Leer por teclado la nota de cada uno de los 18 estudiantes.
                 Calcular el promedio de todas las notas.
                 Identificar y mostrar cuál fue la nota mayor y la nota menor entre las ingresadas.
                 Contar cuántos estudiantes aprobaron la asignatura(nota mayor o igual a 6.0).
                 Mostrar por pantalla:
                             El promedio general.
                 La nota más alta.
                 La nota más baja.
                 La cantidad de aprobados en el curso.*/

            float calificacionIngresada = 0.0f;
            float sumaDeNotas = 0.0f;
            float notaMayor = 0.0f;
            float notaMenor = 0.0f;
            int aprobados = 0;
            int alumnos = 18;
            float promedioGeneral = 0.0f;

            Console.WriteLine($"--- Procesando Notas de {alumnos} Alumnos ---");

            for (int i = 1; i <= alumnos; i++)
            {
                Console.Write($"Ingrese la nota del alumno #{i}: ");
                calificacionIngresada = float.Parse(Console.ReadLine());


                sumaDeNotas += calificacionIngresada;

                if (calificacionIngresada >= 6.0f)
                {
                    aprobados++;
                }

                if (calificacionIngresada > notaMayor)
                {
                    notaMayor = calificacionIngresada;
                }

                if (calificacionIngresada < 6.0f)
                {
                    notaMenor = calificacionIngresada;
                }
            }

            promedioGeneral = sumaDeNotas / alumnos;

            Console.WriteLine("RESULTADOS DEL CURSO");

            Console.WriteLine($"Promedio general:{promedioGeneral}");
            Console.WriteLine($"Nota más alta:{notaMayor}");
            Console.WriteLine($"Nota más baja:{notaMenor}");
            Console.WriteLine($"Total de aprobados:{aprobados}");

        }
    }
}
