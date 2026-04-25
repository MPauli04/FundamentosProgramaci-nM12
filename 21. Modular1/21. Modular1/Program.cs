using System;


namespace _21.Modular1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMenu();
            int opcion = CapturaOpcion();
            RealizarOperacion(opcion);
        }

        static void MostrarMenu()
        {
            Console.WriteLine("-----------------------MENU-----------------------");
            Console.WriteLine(" 1. Suma                     2. Resta");
            Console.WriteLine(" 3. Multiplicacion           4. Division");
            Console.WriteLine("--------------------------------------------------");
        }

        static int CapturaOpcion()
        {
            Console.Write("Ingrese una opción del menú: ");
            return int.Parse(Console.ReadLine());

        }

        static int CapturarOpcion()
        {

            Console.WriteLine("Ingrese una opción del menú: ");
            return int.Parse(Console.ReadLine());
        }

        static void RealizarOperacion(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    Suma();
                    break;
                case 2:
                    Resta();
                    break;
                case 3:
                    Multiplicacion();
                    break;
                case 4:
                    Division();
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;

            }
        }
        static void Suma()
        {
            Console.WriteLine("Realizando la suma...");
        }
        static void Resta()
        {
            Console.WriteLine("Realizando la resta...");
        }
        static void Multiplicacion()
        {
            Console.WriteLine("Realizando la multiplicación...");
        }
        static void Division()
        {
            Console.WriteLine("Realizando la división...");
        }   
    }
}
