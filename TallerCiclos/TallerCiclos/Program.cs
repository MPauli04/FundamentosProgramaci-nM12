using System;

namespace TallerCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.Algoritmo que permita calcular el promedio de calificaciones, el algoritmo
            le permitirá al usuario, introducir tantas calificaciones como así desee,
            en el momento en que seleccione que no desea continuar capturando
            calificaciones, el algoritmo debe presentar el promedio de las
            calificaciones capturadas previamente. */

            /*float suma = 0.0f;
            int contador = 0;
            string respuesta;

            Console.WriteLine("--- Calculadora de Promedio ---");

            do
            {
                Console.Write("Ingrese una calificación: ");
                
                float nota = float.Parse(Console.ReadLine());

                suma += nota;
                contador++;

                Console.Write("¿Desea ingresar otra calificación? (s/n): ");
                respuesta = Console.ReadLine().ToLower();

            } while (respuesta == "s");

            if (contador > 0)
            {
                
                float promedio = suma / contador;

                Console.WriteLine($"Total de calificaciones: {contador}");
                Console.WriteLine($"El promedio final es: {promedio:F2}");
            }
            else
            {
                Console.WriteLine("No se ingresaron calificaciones.");
            }*/


            /* 2.Se requiere un algoritmo para mostrar por pantalla los divisores de un
             número ingresado por teclado.
             Tener en cuenta que dados dos números enteros a y b, se dice que b es
             divisor de a si se cumple que al efectuar una división entera a/ b el
             residuo es 0, en C# utilizar el operador Mod para obtener el residuo de
             una división de dos números*/

            /*
            Console.Write("Ingrese un número entero positivo: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nLos divisores de {numero} son:");

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    Console.WriteLine(i);
                }
            }*/

            /*3.Dados dos números enteros ingresados por teclado: b que es la base y
            e que es el exponente, se requiere calcular el resultado de la
            potenciación.Seguir pidiendo por teclado la base y el exponente y realizar la
            potenciación correspondiente, hasta que el usuario ingrese por teclado
            el carácter de escape ‘n’*/
            /*
                        string opcion = " ";

                        do
                        {
                            Console.Write("\nIngrese la base: ");
                            int baseNum = int.Parse(Console.ReadLine());

                            Console.Write("Ingrese el exponente: ");
                            int exponente = int.Parse(Console.ReadLine());

                            long resultado = 1;

                            for (int i = 1; i <= exponente; i++)
                            {
                                resultado *= baseNum;
                            }
                            Console.WriteLine($"El resultado de {baseNum}^{exponente} es: {resultado}");

                            Console.Write("¿Otro cálculo? (n para salir y s para seguir): ");
                            opcion = Console.ReadLine().ToLower();

                        } while (opcion != "n");*/



            /*4.Un entrenador le ha propuesto a un atleta recorrer una ruta de cinco
                kilómetros durante 10 días, para determinar si es apto para la prueba de
                5 kilómetros.Para considerarlo apto debe cumplir las siguientes
                condiciones:
                 Que en ninguna de las pruebas haga un tiempo mayor a 20 minutos.
                 Que al menos en una de las pruebas realice un tiempo menor de 15
                minutos.
                 Que su promedio sea menor o igual a 18 minutos.
                Diseñar un algoritmo para registrar los datos y decidir si es apto para la
                competencia.*/


            /*
            float sumaTiempos = 0;
            bool nuncaSupero20 = true;   // Condición 1
            bool hizoMenosDe15 = false;  // Condición 2
            int totalDias = 10;

            Console.WriteLine("--- Registro de Tiempos (10 días) ---");

            for (int i = 1; i <= totalDias; i++)
            {
                Console.Write($"Día {i} - Ingrese el tiempo en minutos: ");
                float tiempo = float.Parse(Console.ReadLine());

                sumaTiempos += tiempo;

                if (tiempo > 20)
                {
                    nuncaSupero20 = false;
                }

                if (tiempo < 15)
                {
                    hizoMenosDe15 = true;
                }
            }

            float promedio = sumaTiempos / totalDias;
            bool promedioApto = (promedio <= 18); 

            Console.WriteLine("\n--- Resultados del Entrenamiento ---");
            Console.WriteLine($"Promedio final: {promedio:F2} minutos");

            
            if (nuncaSupero20 && hizoMenosDe15 && promedioApto)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("ESTADO: EL ATLETA ES APTO");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ESTADO: EL ATLETA NO ES APTO");

                Console.ResetColor();
                Console.WriteLine("\nMotivos:");
                if (!nuncaSupero20) Console.WriteLine("- Superó los 20 minutos en alguna prueba.");
                if (!hizoMenosDe15) Console.WriteLine("- No logró bajar de los 15 minutos en ninguna prueba.");
                if (!promedioApto) Console.WriteLine("- El promedio es mayor a 18 minutos.");
            }*/

            /* 5.Se aplicó una encuesta a n personas solicitando su opinión sobre el
             tema del servicio militar obligatorio para las mujeres.Las opciones de
             respuesta fueron: a favor, en contra y no responde. Se solicita un
             algoritmo que calcule qué porcentaje de los encuestados marcó cada
             una de las respuestas.*/


            /* Console.Write("Ingrese la cantidad de personas encuestadas: ");
             int n = int.Parse(Console.ReadLine());


             int aFavor = 0;
             int enContra = 0;
             int noResponde = 0;

             Console.WriteLine("\nOpciones: [1] A favor, [2] En contra, [3] No responde");


             for (int i = 1; i <= n; i++)
             {
                 Console.Write($"Respuesta de la persona #{i}: ");
                 string respuesta = Console.ReadLine();

                 if (respuesta == "1")
                 {
                     aFavor++;
                 }
                 else if (respuesta == "2")
                 {
                     enContra++;
                 }
                 else if (respuesta == "3")
                 {
                     noResponde++;
                 }
                 else
                 {
                     Console.WriteLine("Opción no válida. Intente de nuevo.");
                     i--; 
                 }
             }


             float porcA = (float)aFavor / n * 100;
             float porcC = (float)enContra / n * 100;
             float porcN = (float)noResponde / n * 100;


             Console.WriteLine("\n--- Resultados de la Encuesta ---");
             Console.WriteLine($"A favor: {porcA:F2}% ({aFavor} personas)");
             Console.WriteLine($"En contra: {porcC:F2}% ({enContra} personas)");
             Console.WriteLine($"No responde: {porcN:F2}% ({noResponde} personas)");
             Console.WriteLine($"Total encuestados: {n}");*/




            /*  6.Realizar un algoritmo que lea 40 números e imprima en pantalla cuántos
              de esos números son positivos, cuántos negativos, cuántos son neutros
              (0); además que imprima por pantalla la sumatoria de los números
              positivos y la de los negativos.*/

            /*
            int contPositivos = 0;
            int contNegativos = 0;
            int contNeutros = 0;

          
            float sumaPositivos = 0.0f;
            float sumaNegativos = 0.0f;

            Console.WriteLine("--- Registro de 40 Números ---");

            for (int i = 1; i <= 40; i++)
            {
                Console.Write($"Ingrese el número #{i}: ");
                float n = float.Parse(Console.ReadLine());

                // Clasificación de los números
                if (n > 0)
                {
                    contPositivos++;      
                    sumaPositivos += n;   
                }
                else if (n < 0)
                {
                    contNegativos++;      
                    sumaNegativos += n;   
                }
                else
                {
                    contNeutros++;      
                }
            }

            // Mostrar resultados en pantalla
            Console.WriteLine("\n--- Resumen de Resultados ---");
            Console.WriteLine($"Positivos: {contPositivos} (Suman: {sumaPositivos})");
            Console.WriteLine($"Negativos: {contNegativos} (Suman: {sumaNegativos})");
            Console.WriteLine($"Neutros (ceros): {contNeutros}");*/


            /* 7.Una persona desea realizar un muestreo con 70 personas para
             determinar el promedio de peso de los niños, jóvenes, adultos y viejos
             que existen en su zona y cuántos son de cada una de las categorías.
             Las categorías están dadas por la siguiente tabla: */

            /*int ninos = 0;
            int jovenes = 0;
            int adultos = 0;
            int viejos = 0;

            float pesoNinos = 0;
            float pesoJovenes = 0;
            float pesoAdultos = 0;
            float pesoViejos = 0;   

            Console.WriteLine("--- Muestreo de 70 Personas ---");

            for (int i = 1; i <= 70; i++)
            {
                Console.WriteLine($"\nRegistro Persona #{i}");

                Console.Write("Ingrese la edad: ");
                int edad = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el peso (kg): ");
                float peso = float.Parse(Console.ReadLine());

                if (edad >= 0 && edad <= 13)
                {
                    ninos++;           
                    pesoNinos += peso; 
                }
                else if (edad >= 14 && edad <= 30)
                {
                    jovenes++;
                    pesoJovenes += peso;
                }
                else if (edad >= 31 && edad <= 60)
                {
                    adultos++;
                    pesoAdultos += peso;
                }
                else if (edad >= 61)
                {
                    viejos++;
                    pesoViejos += peso;
                }
            }

            Console.WriteLine("        RESULTADOS DEL ESTUDIO");
           
            if (ninos > 0)
            {
                float promedio = pesoNinos / ninos;
                Console.WriteLine($"Niños: {ninos} personas - Promedio de peso: {promedio:F2} kg");
            }
            else { Console.WriteLine("Niños: 0 personas registradas."); }

            if (jovenes > 0)
            {
                float promedio = pesoJovenes / jovenes;
                Console.WriteLine($"Jóvenes: {jovenes} personas - Promedio de peso: {promedio:F2} kg");
            }
            else { Console.WriteLine("Jóvenes: 0 personas registradas."); }

            if (adultos > 0)
            {
                float promedio = pesoAdultos / adultos;
                Console.WriteLine($"Adultos: {adultos} personas - Promedio de peso: {promedio:F2} kg");
            }
            else { Console.WriteLine("Adultos: 0 personas registradas."); }

            if (viejos > 0)
            {
                float promedio = pesoViejos / viejos;
                Console.WriteLine($"Viejos: {viejos} personas - Promedio de peso: {promedio:F2} kg");
            }
            else { Console.WriteLine("Viejos: 0 personas registradas."); }

            */


            /*8.El Departamento de Transito de Antioquia.desea saber de los n autos
            que entran a la ciudad de Medellín, cuántos autos entran con
            calcomanía de un determinado color. Conociendo el último dígito de la
            placa de cada automóvil se puede determinar el color de la calcomanía*/



            Console.Write("Ingrese la cantidad de autos (n): ");
            int n = int.Parse(Console.ReadLine());

            int amarilla = 0;
            int rosa = 0;
            int roja = 0;
            int verde = 0;
            int azul = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Auto #{i} - Último dígito de placa: ");
                int digito = int.Parse(Console.ReadLine());

               
                if (digito == 1 || digito == 2)
                {
                    amarilla++;
                }
                else if (digito == 3 || digito == 4)
                {
                    rosa++;
                }
                else if (digito == 5 || digito == 6) 
                {
                    roja++;
                }
                else if (digito == 7 || digito == 8)
                {
                    verde++;
                }
                else if (digito == 9 || digito == 0)
                {
                    azul++;
                }
                else
                {
                    Console.WriteLine("Dígito inválido (debe ser de 0 a 9).");
                    i--;
                }
            }

            Console.WriteLine("\n--- Conteo Final de Calcomanías ---");
            Console.WriteLine($"Amarilla : {amarilla}");
            Console.WriteLine($"Rosa     : {rosa}");
            Console.WriteLine($"Roja     : {roja}");
            Console.WriteLine($"Verde    : {verde}");
            Console.WriteLine($"Azul     : {azul}");
        }
    }
}
