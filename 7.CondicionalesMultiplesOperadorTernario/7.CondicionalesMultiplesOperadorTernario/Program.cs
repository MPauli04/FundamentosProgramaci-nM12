using System;
using System.Security.Cryptography;
using System.Threading;

namespace _7.CondicionalesMultiplesOperadorTernario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*7.Tiendas La Avenida desea desarrollar un programa que permita ingresar por teclado el monto de compra y el día de la semana, para saber: 
	•	Si el día es martes o jueves, se realizará un descuento del 15 % por la compra.  
	•	Si el día es lunes o miércoles, se realizará un descuento del 10 % por la compra. 
	•	Si el día es viernes o sábado, se realizará un descuento del 20 % por la compra. 
	•	Si es domingo no se realiza descuento.
	•	Visualizar el día, el descuento y el total a pagar por la compra.*//*

            string diaSemana = "";
            float subtotal = 0;
            float descuento = 0;    

            Console.WriteLine("Ingrese el monto de compra: ");
            subtotal = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el día de la semana: ");
            diaSemana = Console.ReadLine().ToLower();

            switch (diaSemana)
            {
                case "lunes":
                    descuento = subtotal * 0.1f;
                    Console.WriteLine($"Hoy lunes, el descuento es de {descuento}, el total a pagar es de {subtotal - descuento}");
                    break;

                case "martes":
                    descuento = subtotal * 0.15f;
                    Console.WriteLine($"Hoy martes, el descuento es de {descuento}, el total a pagar es de {subtotal - descuento}");
                    break;

                case "miércoles":
                    descuento = subtotal * 0.1f;
                    Console.WriteLine($"Hoy miércoles, el descuento es de {descuento}, el total a pagar es de {subtotal - descuento}");
                    break;

                case "jueves":
                    descuento = subtotal * 0.15f;
                    Console.WriteLine($"Hoy jueves, el descuento es de {descuento}, el total a pagar es de {subtotal - descuento}");
                    break;

                case "viernes":
                    descuento = subtotal * 0.2f;
                    Console.WriteLine($"Hoy viernes, el descuento es de {descuento}, el total a pagar es de {subtotal - descuento}");
                    break;
                
                case "sábado":
                    descuento = subtotal * 0.2f;
                    Console.WriteLine($"Hoy sábado, el descuento es de {descuento}, el total a pagar es de {subtotal - descuento}");
                    break;

                case "domingo":
                    descuento = 0;
                    Console.WriteLine($"Hoy domingo, no hay descuento, el total a pagar es de {subtotal}");
                    break;
                default:
                    Console.WriteLine("Por favor ingrese un día de la semana correcto");
                    break;

            }*/

            //CÁCULADORA BÁSICA//

            float num1 = 0;
            float num2 = 0;
            float resultado = 0;
            string operador = "";

            Console.WriteLine("Estas son las operaciones que puede realizar la calculadora:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("Ingrese la operación a realizar:");
            operador = Console.ReadLine().ToLower();

            Console.WriteLine("Ahora, ingrese el primer número: ");
            num1 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            num2 = Single.Parse(Console.ReadLine());
            
           

            switch (operador)
            {
                case "1":
                    resultado = num1 + num2;
                    Console.WriteLine($"\nEl resultado de la suma es: {resultado}");
                    break;

                case "2":
                    resultado = num1 - num2;
                    Console.WriteLine($"\nEl resultado de la resta es: {resultado}");
                    break;

                case "3":
                    resultado = num1 * num2;
                    Console.WriteLine($"\nEl resultado de la multiplicación es: {resultado}");
                    break;

                case "4":
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine($"\nEl resultado de la división es: {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("\nError: no se puede dividir entre cero.");
                    }
                    break;

                default:
                    Console.WriteLine("\nOpción no válida. Intente nuevamente.");
                    break;
            }

        }
    }
}
