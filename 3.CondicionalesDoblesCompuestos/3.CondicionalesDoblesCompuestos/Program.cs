using System;

namespace _3.CondicionalesDoblesCompuestos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sueldo del usuario//

            string nombre = " ";
            float sueldo = 0;   
            Console.WriteLine("Ingrese el nombre del usuario");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el valor del sueldo");
            sueldo = Single.Parse( Console.ReadLine() );

            if (sueldo >= 3000)
            {
               // Si la condición es verdadera.
                Console.WriteLine($"La persona {nombre}, debe abonar impuestos");
            }
            else if (sueldo < 3000)
            {
                // Si la condición es falsa.

                Console.WriteLine("La persona está exenta de impuestos");
            }

               // Pedir los dos números al usuario//

            Console.Write("Ingresa el primer número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa el segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            if (numero1 > numero2)
            {
                double suma = numero1 + numero2;
                double resta = numero1 - numero2;

                Console.WriteLine("\nEl primer número es mayor que el segundo.");
                Console.WriteLine("Suma: " + suma);
                Console.WriteLine("Resta: " + resta);
            }
            else if (numero1 < numero2)
            {
                double multiplicacion = numero1 * numero2;
                if (numero2 != 0)
                {
                    double division = numero1 / numero2;
                    Console.WriteLine("\nEl segundo número es mayor que el primero.");
                    Console.WriteLine("Multiplicación: " + multiplicacion);
                    Console.WriteLine("División: " + division);
                }
                else
                {
                    Console.WriteLine("\nNo se puede dividir entre cero.");
                }
            }
            else
            {
                Console.WriteLine("\nLos números son iguales.");
            }



            // Pedir un número entero al usuario//

            Console.Write("Ingresa un número entero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Verificar si el número es positivo, negativo o cero
            if (numero > 0)
            {
                Console.WriteLine("El número es positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("El número es negativo.");
            }
            else
            {
                Console.WriteLine("El número es cero.");
            }

        }
    }
}
