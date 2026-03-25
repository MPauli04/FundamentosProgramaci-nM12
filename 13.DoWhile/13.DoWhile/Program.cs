using System;


namespace _13.DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int contador = 1;
            int sumaEnteros = 0; //Variable tipo acumulador

            do
            {
                sumaEnteros += contador;
                contador++;

            } while (contador <= 5);

            Console.WriteLine($"La suma de los cinco enteros números enteros es: {sumaEnteros}");
*/


            /*int numero = 0;
            char respuesta = ' ';
            int contador = 1;

            do
            {
                Console.Clear(); //Borra lo que está antes en pantalla
                Console.WriteLine("Digite el número para clacular su tabla de multiplicar:");
                numero = int.Parse(Console.ReadLine());

                do
                {
                    Console.WriteLine($"{numero} X {contador} = {numero * contador}");
                    contador++;

                } while (contador <= 10);

                contador = 1; //Aquí toca reiniciar el contador para que pueda funcionar bien el código
                Console.WriteLine("Desea calcular más tablas de multiplicar? Escriba s= Sí o n= No");
                respuesta = char.Parse(Console.ReadLine());

            } while (respuesta == 's');*/


            string nombre;
            string numeroCuenta;
            double saldo;
            char continuar;

            // Variables para las estadísticas finales
            int totalUsuarios = 0;
            double sumaSaldos = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Registro de Usuario para Crédito");

                // Captura de datos
                Console.Write("Ingrese el nombre del usuario: ");
                nombre = Console.ReadLine();

                Console.Write("Ingrese el número de cuenta: ");
                numeroCuenta = Console.ReadLine();

                Console.Write("Ingrese el saldo actual: ");
                // Usamos double.Parse para permitir decimales en el saldo
                saldo = double.Parse(Console.ReadLine());

                // Lógica de aptitud para el crédito
                if (saldo > 3000000)
                {
                    Console.WriteLine($"\nUsuario: {nombre}\nCuenta: {numeroCuenta}\nSaldo: {saldo:C}");
                    Console.WriteLine("ESTADO: Es apto para el crédito.");
                }
                else
                {
                    Console.WriteLine($"\nUsuario: {nombre}\nCuenta: {numeroCuenta}\nSaldo: {saldo:C}");
                    Console.WriteLine("ESTADO: No es apto para el crédito.");
                }

                // Actualización de estadísticas
                totalUsuarios++;          // Incrementa el contador de personas
                sumaSaldos += saldo;      // Acumula el saldo para el promedio

                // Preguntar si desea continuar
                Console.WriteLine("\n¿Desea ingresar otro usuario? (s/n):");
                continuar = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine(); // Salto de línea para estética

            } while (continuar == 's');

            // Cálculos finales
            double promedioSaldos = sumaSaldos / totalUsuarios;

            // Mostrar resultados generales
            
            Console.WriteLine("RESUMEN DE LA JORNADA");
            Console.WriteLine($"Total de usuarios consultados: {totalUsuarios}");
            Console.WriteLine($"Promedio de los saldos: {promedioSaldos:C}");
           

            

        }
    }
}