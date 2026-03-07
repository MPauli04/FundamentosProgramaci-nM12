using System;
using System.Xml.Linq;

namespace ParcialCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1.Solicite al usuario que ingrese:
             - Mes de nacimiento(por ejemplo: "marzo") 
             - Signo zodiacal(por ejemplo: "aries")*/

            /*                 Elementos
                 FUEGO
                 marzo, abril, julio, agosto, noviembre, diciembre
                 Aries, Leo, Sagitario

                 TIERRA
                 abril, mayo, agosto, septiembre, diciembre, enero
                 Tauro, Virgo, Capricornio

                 AIRE
                 mayo, junio, septiembre, octubre, enero, febrero
                 Géminis, Libra, Acuario

                 AGUA
                 marzo, junio, julio, octubre, noviembre, febrero
                 Cáncer, Escorpión, Piscis*/

            //SIGNO ZODICAL Y MES DE NACIMIENTO//

            string mesNacimiento = "";
            string signoZodiacal = "";


            string mesNacimiento1 = "enero";
            string mesNacimiento2 = "febrero";
            string mesNacimiento3 = "marzo";
            string mesNacimiento4 = "abril";
            string mesNacimiento5 = "mayo";
            string mesNacimiento6 = "junio";
            string mesNacimiento7 = "julio";
            string mesNacimiento8 = "agosto";
            string mesNacimiento9 = "septiembre";
            string mesNacimiento10 = "octubre";
            string mesNacimiento11 = "noviembre";
            string mesNacimiento12 = "diciembre";

            string signoZodiacal1 = "aries"; //Marzo, abril
            string signoZodiacal2 = "tauro"; //abril, mayo
            string signoZodiacal3 = "geminis"; //mayo, junio
            string signoZodiacal4 = "cancer";//junio, julio
            string signoZodiacal5 = "leo";  // julio, agosto
            string signoZodiacal6 = "virgo";//agosto, septiembre
            string signoZodiacal7 = "libra";//septiembre, octubre
            string signoZodiacal8 = "escorpion";//octubre, noviembre
            string signoZodiacal9 = "sagitario";//noviembre, diciembre
            string signoZodiacal10 = "capricornio";//Diciembre, enero
            string signoZodiacal11 = "acuario"; //Enero, febrero
            string signoZodiacal12 = "piscis"; //febrero, marzo


            string elemento1 = "Tierra";
            string elemento2 = "fuego";
            string elemento3 = "aire";
            string elemento4 = "agua";

            //MES Y SIGNO DE LA PERSONA//
            Console.WriteLine("Ingrese su mes de nacimiento: ");
            mesNacimiento = Console.ReadLine().ToLower();

            Console.WriteLine("Ingrese su signo zodiacal: ");
            signoZodiacal = Console.ReadLine().ToLower();

            //DETERMINACIÓN DEL ELEMENTO DE LA PERSONA//
            if (mesNacimiento == mesNacimiento1 && signoZodiacal == signoZodiacal10)
            {
                Console.WriteLine($"Su elemento es: {elemento1}");
            }
            else if (mesNacimiento == mesNacimiento1 && signoZodiacal == signoZodiacal11)
            {
                Console.WriteLine($"Su elemento es: {elemento3}");
            }
            else if (mesNacimiento == mesNacimiento2 && signoZodiacal == signoZodiacal11)
            {
                Console.WriteLine($"Su elemento es: {elemento3}");
            }
            else if (mesNacimiento == mesNacimiento2 && signoZodiacal == signoZodiacal12)
            {
                Console.WriteLine($"Su elemento es: {elemento4}");
            }
            else if (mesNacimiento == mesNacimiento3 && signoZodiacal == signoZodiacal12)
            {
                Console.WriteLine($"Su elemento es: {elemento4}");
            }
            else if (mesNacimiento == mesNacimiento3 && signoZodiacal == signoZodiacal1)
            {
                Console.WriteLine($"Su elemento es: {elemento2}");
            }
            else if (mesNacimiento == mesNacimiento4 && signoZodiacal == signoZodiacal1)
            {
                Console.WriteLine($"Su elemento es: {elemento2}");
            }
            else if (mesNacimiento == mesNacimiento4 && signoZodiacal == signoZodiacal2)
            {
                Console.WriteLine($"Su elemento es: {elemento1}");
            }
            else if (mesNacimiento == mesNacimiento5 && signoZodiacal == signoZodiacal2)
            {
                Console.WriteLine($"Su elemento es: {elemento1}");
            }
            else if (mesNacimiento == mesNacimiento5 && signoZodiacal == signoZodiacal3)
            {
                Console.WriteLine($"Su elemento es: {elemento3}");
            }
            else if (mesNacimiento == mesNacimiento6 && signoZodiacal == signoZodiacal3)
            {
                Console.WriteLine($"Su elemento es: {elemento3}");
            }
            else if (mesNacimiento == mesNacimiento6 && signoZodiacal == signoZodiacal3)
            {
                Console.WriteLine($"Su elemento es: {elemento4}");
            }
            else if (mesNacimiento == mesNacimiento7 && signoZodiacal == signoZodiacal4)
            {
                Console.WriteLine($"Su elemento es: {elemento4}");
            }
            else if (mesNacimiento == mesNacimiento7 && signoZodiacal == signoZodiacal4)
            {
                Console.WriteLine($"Su elemento es: {elemento2}");
            }
            else if (mesNacimiento == mesNacimiento8 && signoZodiacal == signoZodiacal5)
            {
                Console.WriteLine($"Su elemento es: {elemento2}");
            }
            else if (mesNacimiento == mesNacimiento8 && signoZodiacal == signoZodiacal6)
            {
                Console.WriteLine($"Su elemento es: {elemento1}");
            }
            else if (mesNacimiento == mesNacimiento9 && signoZodiacal == signoZodiacal6)
            {
                Console.WriteLine($"Su elemento es: {elemento1}");
            }
            else if (mesNacimiento == mesNacimiento9 && signoZodiacal == signoZodiacal7)
            {
                Console.WriteLine($"Su elemento es: {elemento3}");
            }
            else if (mesNacimiento == mesNacimiento10 && signoZodiacal == signoZodiacal7)
            {
                Console.WriteLine($"Su elemento es: {elemento3}");
            }
            else if (mesNacimiento == mesNacimiento10 && signoZodiacal == signoZodiacal8)
            {
                Console.WriteLine($"Su elemento es: {elemento4}");
            }
            else if (mesNacimiento == mesNacimiento11 && signoZodiacal == signoZodiacal8)
            {
                Console.WriteLine($"Su elemento es: {elemento4}");
            }
            else if (mesNacimiento == mesNacimiento11 && signoZodiacal == signoZodiacal9)
            {
                Console.WriteLine($"Su elemento es: {elemento2}");
            }
            else if (mesNacimiento == mesNacimiento12 && signoZodiacal == signoZodiacal9)
            {
                Console.WriteLine($"Su elemento es: {elemento2}");
            }
            else if (mesNacimiento == mesNacimiento12 && signoZodiacal == signoZodiacal10)
            {
                Console.WriteLine($"Su elemento es: {elemento3}");
            }
            else
            {
                Console.WriteLine("No se ha podido determinar su elemento, revise que el mes y el signo zodiacal sean correctos.");
            }
        }  

    }
}
