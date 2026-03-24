using System;


namespace _8.TallerCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//LEER NÚMEROS Y ORDENARLOS//
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int mayor = 0;
            int medio = 0;
            int menor = 0;

            Console.WriteLine("Ingrese su primer número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su segundo número");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su tercer número");
            num3 = int.Parse(Console.ReadLine());

            //COMPROBAR SI SON IGUALES//

            if (num1 == num2 || num1 == num3 || num2 == num3)
            {
                Console.WriteLine("Ingrese por favor números diferentes, no pueden haber 2 o 3 iguales");
            }
            if (num1 > num2 && num1 > num3 && num2 >num3)
            {
                mayor = num1;
                medio = num2;
                menor = num3;
                Console.WriteLine($"El número mayor es: {num1}");
                Console.WriteLine($"Y el orden de menor a mayor es: {num3}, {num2}, {num1}");
            }
            else if (num1 > num2 && num1 < num3)
            {
                mayor = num3;
                medio = num1;
                menor = num2;
                Console.WriteLine($"El número mayor es: {num3}");
                Console.WriteLine($"Y el orden de menor a mayor es: {num2}, {num1}, {num3}");
            }
            else if (num2 > num1 && num2 > num3 & num1 > num3)
            {
                mayor = num2;
                medio = num1;
                menor = num3;
                Console.WriteLine($"El número mayor es : {num2}");
                Console.WriteLine($"Y el orden de menor a mayor es: {num3}, {num1}, {num2}");
            }
            else if (num2 > num1 && num2 < num3)
            {
                mayor = num3;
                medio = num2;
                menor = num1;
                Console.WriteLine($"El número mayor es: {num3}");
                Console.WriteLine($"Y el orden de menor a mayor es: {num1}, {num2}, {num3}");
            }*/

            /* //IDENTIFICAR ESTADO Y MUNICIÓN

             int municion = 0;
             bool estado = false;

             //Punto a.
             Console.WriteLine("¿El estado del jugador está en modo invencible? ingrese true or false para responder: ");
             estado = bool.Parse(Console.ReadLine());
             //Punto b.
             Random rnd = new Random();
             municion = rnd.Next(0, 11); //Esto genera un numero aleatorio y lo devuelve
             Console.WriteLine($"la munición generada es de: {municion}");
             //punto c.
             if (estado == true && municion > 0)
             {
                 Console.WriteLine("El jugador puede disparar");
             }
             else if (estado == false ||  municion == 0)
             {
                 estado = true;
                 Console.WriteLine("El jugador no puede disparar");
             }*/

            /* //COORDENADAS//

             float x1 = 0;
             float y1 = 0;
             float x2 = 0;
             float y2 = 0;
             float x3 = 0;
             float y3 = 0;
             float distancia1 = 0;
             float distancia2 = 0;
             float distancia3 = 0;

             Console.WriteLine("Ingrese la coordenada X y Y del punto 1: ");
             x1 = float.Parse(Console.ReadLine());
             y1 = float.Parse(Console.ReadLine());

             Console.WriteLine("Ingrese la coordenada X y Y del punto 2: ");
             x2 = float.Parse(Console.ReadLine());
             y2 = float.Parse(Console.ReadLine());

             Console.WriteLine("Ingrese la coordenada X y Y del punto 3: ");
             x3 = float.Parse(Console.ReadLine());
             y3 = float.Parse(Console.ReadLine());

             //DISTANCIA ENTRE LOS PUNTOS//


             distancia1 = (float)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
             Console.WriteLine($"la distancia entre el punto 1 y el punto 2 es: {distancia1}");

             distancia2 = (float)Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
             Console.WriteLine($"la distancia entre el punto 1 y el punto 3 es: {distancia2}");

             distancia3 = (float)Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
             Console.WriteLine($"la distancia entre el punto 2 y el punto 3 es: {distancia3}");

             //VERIFICAR SI FORMAN UN TRIÁNGULO//

             if (distancia1 + distancia2 > distancia3)
             {
                 Console.WriteLine("los puntos forman un triángulo");
             }
             else if (distancia1 + distancia3 > distancia2)
             {
                 Console.WriteLine("los puntos forman un triángulo");
             }
             else if (distancia2 + distancia3 > distancia1)
             {
                 Console.WriteLine("los puntos forman un triángulo");
             }
             else
             {
                 Console.WriteLine("los puntos no forman un triángulo");

             }*/


           /* //MOVIMIENTO DE PERSONAJE//
            char mderecha = 'd';
            char mizquierda = 'i';
            char movimiento;

            Console.WriteLine("Ingrese 'd' o 'i' para saber hacia donde se está moviendo el personaje");
            movimiento = char.Parse(Console.ReadLine());

            if (movimiento == mderecha)
            {
                Console.WriteLine("El personaje se está moviendo hacia la derecha");
            }
            else if (movimiento == mizquierda)
            {
                Console.WriteLine("El personaje se está moviendo hacia la izquierda");
            }
            else if (movimiento != mderecha || movimiento != mizquierda)
            {
                Console.WriteLine("No me puedo mover hacia otro lado");
            }*/

           //VIDAS Y ACCIONES//

           /* int vidas = 0;
            char accion1 = 'c';
            char accion2 = 'x';
            char accion3 = 't';
            char accion4 = 'i';
            char accion;

            Random rnd = new Random();
            vidas = rnd.Next(0, 6); //Esto genera un numero aleatorio y lo devuelve
            Console.WriteLine($"La cantidad de vida que tienes es de: {vidas}");

            if ( vidas == 0 )
            {
                Console.WriteLine("El persona no tiene vidas, así que no puede realizar ninguna acción");
            }
            else if ( vidas > 0)
            {
                Console.WriteLine($"Ingrese 'c', 'x' , 't'  o 'i' para realizar alguna acción: ");
                accion = char.Parse(Console.ReadLine());
                if (accion == accion1)
                {
                    Console.WriteLine("El personaje está disparando");
                }
                else if (accion == accion2)
                {
                    Console.WriteLine("El personaje está hablando con la rana");
                }
                else if (accion == accion3)
                {
                    Console.WriteLine("El personaje está en modo Turbo");
                }
                else if (accion == accion4)
                {
                    Console.WriteLine ("El personaje está en modo invisible");
                }
            }*/



        }
    }
}
