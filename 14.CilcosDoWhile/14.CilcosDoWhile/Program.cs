using System;


namespace _14.CiclosDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* //Crear un algoritmo que permita calcular y mostrar por pantalla los numeros primos hasta el número 100.

             int contadorNumeros = 1;
             int contador = 1;
             int contadorDivisores = 0;

             do
             {
                 do
                 {

                     if (contadorNumeros % contador == 0)
                     {
                         contadorDivisores++;
                     }

                 } while (contador <= contadorNumeros);

                 contador = 1;
                 if (contadorDivisores == 2)
                 {
                     Console.WriteLine(contadorNumeros);
                 }

                 contadorDivisores = 0;
                 contadorNumeros++;

             } while (contadorNumeros <= 100);*/

            //-----------------------------------------------------------------------//


            /*Escribe un algortimo que actue como una calculadora básica.El algoritmo debe permitir al usuario elegir la operación a realizar
            (suma, resta, multiplicación o división) y luego ingresar dos números. El ciclo debe permitir al usuario realizar más calculos 
            hasta que elija salir*//*

            //CALCULADORA BASICA
             
            int opcion;
            int numero1;
            int numero2;

            do 
            {
                Console.WriteLine("Ingrese la operación a realizar: ");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                opcion = int.Parse(Console.ReadLine());

               if (opcion >= 1 && opcion <= 4)
                {
                    Console.WriteLine("Ingrese el primer número: ");
                    numero1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo número: ");
                    numero2 = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine($"Resultado: {numero1 + numero2}");
                            break;
                        case 2:
                            Console.WriteLine($"Resultado: {numero1 - numero2}");
                            break;
                        case 3:
                            Console.WriteLine($"Resultado: {numero1 * numero2}");
                            break;
                        case 4:
                            if (numero2 != 0)
                            {
                                Console.WriteLine($"Resultado: {(double)numero1 / numero2}");
                            }
                            else
                            {
                                Console.WriteLine("Error: No se puede dividir por cero.");
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opción no válida. Por favor, elija una opción entre 1 y 4.");
                }
                 Console.WriteLine("¿Desea realizar otra operación? (s/n)");
                 string respuesta = Console.ReadLine().ToLower();
                 if (respuesta != "s")
                 {
                     break;
                 }


            }while (true);
            */



            /*Crear un algoritmo que permita ingresar números:
             Contar cuantos son pares y cuantos son imapares;
             calcular el promedio de todos los números ingresados
             Terminar cuando el usuario lo indique:**/

            /*int numeroIngresado = 0;
            int contadorPares = 0;
            int contadorImpares = 0;
            float sumaAcumulada = 0; // para sumar todo
            int totalDeEntradas = 0;  // Para saber por cuánto dividir al final
            string respuesta = "";

            do
            {
                Console.WriteLine("Ingrese un número:");
                numeroIngresado = int.Parse(Console.ReadLine());

                // 1. Clasificación de pares e impares
                if (numeroIngresado % 2 == 0)
                {
                    contadorPares++;
                }
                else
                {
                    contadorImpares++;
                }

                // 2. Acumulamos la suma y contamos cuántos números van en total
                sumaAcumulada += numeroIngresado;
                totalDeEntradas++;

                Console.WriteLine("¿Desea ingresar otro número? (s/n)");
                respuesta = Console.ReadLine().ToLower(); // Guardamos la respuesta

            } while (respuesta == "s"); // El ciclo sigue si la respuesta es "s"

            // 3. Cálculo del promedio final (fuera del ciclo)
            float promedio = sumaAcumulada / totalDeEntradas;

            Console.WriteLine($"\nCantidad de pares: {contadorPares}");
            Console.WriteLine($"Cantidad de impares: {contadorImpares}");
            Console.WriteLine($"El promedio es: {promedio}");*/




            /*Crear un algoritmo que:
                Permita al usuario ingresar una contraseña 
                Se repita hasta que ingrese la contraseña correcta(por ejemplo: 1234)
                Mostrar cuantos intentos realizo**/

            string contraseña = "password";
            int intentos = 0;

            Console.WriteLine("Por Favor ingrese la contraseña:");
            contraseña = Console.ReadLine();

            if (contraseña == "password")
            {
                Console.WriteLine("Contraseña correcta. Bienvenido!");
            }
            else
            {
                do
                {
                    intentos++;
                    Console.WriteLine("Contraseña incorrecta. Intente nuevamente:");
                    contraseña = Console.ReadLine();
                } while (contraseña != "password");
                Console.WriteLine($"Contraseña correcta. Bienvenido! Intentos realizados: {intentos}");
            }
                                                   
            
        }
    }
    
}
