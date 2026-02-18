using System;

namespace _2.CondicionalesSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  string nombre = " ";
              float sueldo = 0;
              Console.WriteLine("Ingrese el nombre del usuario");
              nombre = Console.ReadLine(); //Lo que llegue desde la consola, es tipo string

              Console.WriteLine("Ingrese el sueldo del usuario");
              sueldo = Convert.ToSingle(Console.ReadLine());

              if (sueldo >= 3000)
              {
                  Console.WriteLine($"La persona {nombre}, debe abonar impuestos");
              }*/

            string nombre = " ";
            int edad = 0;
            Console.WriteLine("Ingrese el nombre del usuario");
            nombre = Console.ReadLine(); //Lo que llegue desde la consola, es tipo string

            Console.WriteLine("Ingrese su edad por favor");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine($"Le doy la bienvenida, {nombre}, a mi sitio web ");
            }
        }
    }
}
