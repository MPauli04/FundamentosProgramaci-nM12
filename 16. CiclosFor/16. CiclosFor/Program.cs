using System;


namespace _16.CiclosFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables contadoras
            int ganados = 0;
            int empatados = 0;
            int perdidos = 0;
            int totalPartidos = 30;

            Console.WriteLine("--- Registro de Resultados del Equipo ---");
            Console.WriteLine("Ingrese: G (Ganado), E (Empatado), P (Perdido)");

            // Ciclo for para los 30 partidos
            for (int i = 1; i <= totalPartidos; i++)
            {
                Console.Write($"Resultado del partido #{i}: ");
                string resultado = Console.ReadLine().ToUpper();

                if (resultado == "G")
                {
                    ganados++;
                }
                else if (resultado == "E")
                {
                    empatados++;
                }
                else if (resultado == "P")
                {
                    perdidos++;
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Intente de nuevo con G, E o P.");
                    i--; // Restamos 1 al índice para repetir la entrada del mismo partido
                }
            }

            // Cálculos de porcentajes (usamos double para mayor precisión)
            double porcGanados = (double)ganados / totalPartidos * 100;
            double porcEmpatados = (double)empatados / totalPartidos * 100;
            double porcPerdidos = (double)perdidos / totalPartidos * 100;

            // Mostrar resultados
            Console.WriteLine("\n--- Resumen de la Temporada ---");
            Console.WriteLine($"Partidos Ganados: {ganados} ({porcGanados}% )");
            Console.WriteLine($"Partidos Empatados: {empatados} ({porcEmpatados}% )");
            Console.WriteLine($"Partidos Perdidos: {perdidos} ({porcPerdidos}% )");
        }
    }
}
