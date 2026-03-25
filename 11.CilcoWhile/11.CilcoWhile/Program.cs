using System;


namespace _11.CilcoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* //realizar un algortimo que permita la suma de todos los numeros impares hasta el 99

             int contador = 1;
             int acumulador = 0;

             while (contador <= 99)
             {
                 acumulador = acumulador + contador;
                 contador = contador + 2;
             }
             Console.WriteLine($"la suma de los numeros impares hasta el 99 es: {acumulador}");*/

            /* Realizar un algoritmo que le pida al usuario ingresar por teclado números enteros al azar.Al usuario le corresponde ingresar la cantidad de números que va a introducir.
                 a.El algoritmo debe escribir en pantalla:
                 i.La cantidad de números introducidos que son mayores que 0
                 ii.La cantidad de números introducidos menores que 0
                 iii.La cantidad de números iguales a 0.*/

           

            int cantidadnum = 0;    
            int contadornum = 1;
            int ceros = 0; //Esto también es un contador
            int mayorcero = 0;
            int menorcero = 0;
            int numero = 0; 

            Console.WriteLine("¿Cuantos números va a introducir?");
            cantidadnum = int.Parse(Console.ReadLine());

            while (contadornum <= cantidadnum)
            {
                Console.WriteLine($"Ingrese el valor para el número {contadornum}:");
                numero = int.Parse(Console.ReadLine());

                if (numero == 0)
                {
                    ceros++;
                }
                else 
                    {
                    if (numero > 0)
                    {
                        mayorcero++;
                    }
                    else
                    {
                        menorcero++;
                    }
                }

                contadornum++;
            }
            Console.WriteLine($"Iguales que cero: {ceros}, mayores que cero: {mayorcero}, menores que cero: {menorcero}");
        }
    }
}
