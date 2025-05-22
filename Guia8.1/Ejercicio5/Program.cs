
using Ejercicio5.Models;

namespace Ejercicio5
{
    internal class Program
    {
        static Servicio servicio=new Servicio();

        #region metodos 
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("Ingrese las siguiente opciones:\n\n");
            Console.WriteLine("1- Determinar Días del mes.");
            Console.WriteLine("2- Verificar Si el año es bisiesto");
            Console.WriteLine("(otro)- Salir.");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
        static void MostrarPantallaSolicitarMesAñoYDeterminarDias()
        {
            Console.Clear();
            Console.WriteLine("Determinar cantidad de días del mes \n\n");

            Console.WriteLine("Ingrese el mes (1 al 12):\n");
            int mes = Convert.ToInt32( Console.ReadLine() );

            Console.WriteLine("\nIngrese el año:\n");
            int año = Convert.ToInt32(Console.ReadLine());

            int cantidadDias = servicio.DeterminarLosDíasDelMes(mes, año);

            Console.WriteLine($"\n\nLa cantidad de días del més ({mes}) es: \n\t\t\t{cantidadDias}\n\n\n");

            Console.WriteLine("\n\n\nPresione una tecla para continuar");
            Console.ReadKey();
        }
        static void MostrarPantallaVerificarSiElAñoEsBisiesto()
        {
            Console.Clear();
            Console.WriteLine("Determinar si el año es bisiesto. \n\n");

            Console.WriteLine("\nIngrese el año:\n");
            int año = Convert.ToInt32(Console.ReadLine());

            if(servicio.DeterminarSiEsBisiesto(año))
            {
                Console.WriteLine("El año es bisiesto");
            }
            else
            {
                Console.WriteLine("El año no es bisiesto");
            }
            
            Console.WriteLine("\n\n\nPresione una tecla para continuar");
            Console.ReadKey();
        }
       
        #endregion

        static void Main(string[] args)
        {
            int op = MostrarPantallaSolicitarOpcionMenu();

            #region iterar opciones menú
            while (op != -1)
            {
                #region verificar opción
                switch (op)
                {
                    case 1:
                        MostrarPantallaSolicitarMesAñoYDeterminarDias();
                        break;
                    case 2:
                        MostrarPantallaVerificarSiElAñoEsBisiesto();
                        break;
                    default:
                        op = -1;
                        break;
                }
                #endregion

                #region solicitar opción
                if (op != -1)
                    op = MostrarPantallaSolicitarOpcionMenu();
                #endregion
            }
            #endregion
        }
    }
}
