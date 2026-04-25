using System;


namespace _20.ProgramacionModular
{
    internal class Program
    {
        static int añoActual = 2026;
        static void Main(string[] args)
        {
            //PROGRMACIÓN MODULAR
            

            string nombre = "Paulina";
            string apellido = "Correa";
            Console.WriteLine("Edad: " + EdadAñoNacimiento());
            Saludo(nombre, apellido);
            Saludo("Carlos", "Perez");
            Console.WriteLine("Edad: " + EdadAñoNacimiento(2001));
            Console.ReadLine();
            BorrarPantalla();
        }

        //Procedimiento sin parámetros
        static void BorrarPantalla()
        {
            Console.Clear();
        }
        //Procedimiento con parámetros
        static void Saludo(string nombre, string apellido)
        {
            Console.WriteLine($"Bienvenid@ {nombre} {apellido} a la programación modular");
        }

        //Funciones sin parámetros
        static int EdadAñoNacimiento()
        {
            int añoNacimineto = 1999;
            int edad = añoActual - añoNacimineto;
                return edad;    
        }

        //Funciones con parámetros
        static int EdadAñoNacimiento(int añoNacimineto)
        {     
            return añoActual - añoNacimineto;
        }
    }
}
