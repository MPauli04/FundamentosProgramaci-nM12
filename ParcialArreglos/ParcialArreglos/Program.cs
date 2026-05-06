using Microsoft.SqlServer.Server;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

namespace ParcialArreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*                        Sistema de gestión de gastos departamentales
                    Desarrolle un programa de gestión contable que permita registrar, almacenar y analizar los gastos anuales por concepto 
                    y por departamento dentro de una organización.
                        Departamentos:
                        Marketing
                        Contabilidad
                        Recursos_Humanos
                        Distribución
                        Ingeniería
                        Investigación

                        Conceptos de gasto:
                        Salarios
                        Suministros
                        Mobiliario
                        Equipamiento
                        Otros

                        Requisitos funcionales del programa:
                        1.Estructura de datos:
                            Utilice una matriz bidimensional de 6 filas por 5 columnas para almacenar los valores de gastos.
                            Cada fila representa un departamento y cada columna un tipo de gasto.
                            Los índices deben corresponder en orden al listado anterior(por ejemplo, fila 0 → Marketing, columna 0 → Salarios).

                        2. Ingreso de datos:
                            Solicite al usuario ingresar los valores de gastos para cada combinación de departamento y concepto.
                            Validar que cada valor ingresado sea un número decimal positivo. No se permiten valores negativos.

                        3. Visualización de la matriz:
                            Mostrar la matriz completa con encabezados de filas y columnas claros(nombre de departamento y nombre del concepto de gasto).
                            Presentar los valores en formato tabular.

                        4. Cálculos requeridos:
                        a) Suma de gastos por departamento:
                            Calcular y mostrar el gasto total de cada uno de los 6 departamentos(sumar por fila).

                        b) Suma de gastos por concepto:
                           Calcular y mostrar el gasto total de cada uno de los 5 conceptos(sumar por columna).

                        c) Gasto total del año:
                           Calcular y mostrar la suma total de todos los valores en la matriz.

                        d) Vector de gastos "Otros":
                           Crear un vector(arreglo unidimensional) que contenga, para cada departamento, el gasto registrado en el concepto "Otros".
                           Mostrar el vector en pantalla indicando el nombre del departamento y su valor correspondiente.

                        e) Mayor gasto registrado:
                           Determinar el valor más alto dentro de la matriz.
                           Indicar en pantalla:
                                    El valor del gasto
                                    El departamento al que pertenece
                                    El concepto de gasto correspondiente*/

            string[] departamentos = { "Marketing", "Contabilidad", "Recursos Humanos", "Distribución", "Ingeniería", "Investigación" };
            string[] conceptos = { "Salarios", "Suministros", "Mobiliario", "Equipamiento", "Otros" };

            float[,] gastos = new float[6, 5];

            for (int o = 0; o < departamentos.Length; o++)
            {
                Console.WriteLine($"Por favor ingrese los gastos para el departamento de {departamentos[o]}:");

                for (int j = 0; j < conceptos.Length; j++)
                {
                    bool valorValido = false;
                    while (!valorValido)
                    {
                        Console.Write(conceptos[j] + ": ");

                        float valor = float.Parse(Console.ReadLine());

                        if (valor >= 0)
                        {
                            gastos[o, j] = valor;
                            valorValido = true;
                        }
                        else
                        {
                            Console.WriteLine("Por favor ingrese un valor decimal positivo.");
                        }
                    }
                }
                Console.WriteLine();

                Console.WriteLine("\nResumen de gastos anuales");
                Console.WriteLine("Departamentos");

                for (int j = 0; j < conceptos.Length; j++)
                {
                    Console.Write($"{conceptos[j]}\t\t");
                }
                Console.WriteLine();
                for (int i = 0; i < departamentos.Length; i++)
                {
                    Console.Write($"{departamentos[i]}\t");
                    for (int j = 0; j < conceptos.Length; j++)
                    {
                        Console.Write($"    |{gastos[i, j]}|    \t");
                    }
                    Console.WriteLine();
                }

                //Calculos que se piden en el punto 4 del enunciado
                //Punto a) Suma de gastos por departamento (Filas)
                for (int i = 0; i < departamentos.Length; i++)
                {

                    float sumaFila = 0;
                    for (int j = 0; j < conceptos.Length; j++)
                    {
                        sumaFila += gastos[i, j];
                    }
                    Console.WriteLine($"{departamentos[i]}: {sumaFila}");

                }
                Console.WriteLine();

                //Punto b) Suma de gastos por concepto (Columnas)
                for (int j = 0; j < conceptos.Length; j++)
                {
                    float sumaColumna = 0;
                    for (int i = 0; i < departamentos.Length; i++)
                    {
                        sumaColumna += gastos[i, j];
                    }
                    Console.WriteLine($" {conceptos[j]}: {sumaColumna}");
                }
                Console.WriteLine();

                //Punto c) Gasto total del año
                float gastoTotalAnual = 0;
                for (int i = 0; i < departamentos.Length; i++)
                {
                    for (int j = 0; j < conceptos.Length; j++)
                    {
                        gastoTotalAnual += gastos[i, j];
                    }
                }
                Console.WriteLine($"\nGasto total del año: {gastoTotalAnual}");
                Console.WriteLine();

                //Punto d) Vector de gastos "Otros"

                float[] vectorOtros = new float[departamentos.Length];
                Console.WriteLine("\nVector de gastos 'Otros' por departamento:");
                for (int i = 0; i < departamentos.Length; i++)
                {
                    vectorOtros[i] = gastos[i, 4];
                    Console.WriteLine($" {departamentos[i]}: {vectorOtros[i]}");
                }
                Console.WriteLine();

                //Punto e) Mayor gasto registrado

                float mayorGasto = gastos[0, 0];
                int filaMayor = 0;
                int colMayor = 0;
                for (int i = 0; i < departamentos.Length; i++)
                {
                    for (int j = 0; j < conceptos.Length; j++)
                    {
                        if (gastos[i, j] > mayorGasto)
                        {
                            mayorGasto = gastos[i, j];
                            filaMayor = i;
                            colMayor = j;
                        }
                    }
                }
                Console.WriteLine();

                Console.WriteLine("\nRegistro de Mayor Gasto:");

                Console.WriteLine($"Valor: {mayorGasto}");
                Console.WriteLine($"Departamento: {departamentos[filaMayor]}");
                Console.WriteLine($"Concepto: {conceptos[colMayor]}");

            }
           
        }
    }
}
