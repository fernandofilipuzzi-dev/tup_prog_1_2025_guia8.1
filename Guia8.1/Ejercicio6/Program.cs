
using Ejercicio7.Models;

namespace Ejercicio6
{
    internal class Program
    {
        static Servicio servicio = new Servicio();

        #region metodos 
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("Ingrese las siguiente opciones:\n\n");
            Console.WriteLine("1- Registrar opinión");
            Console.WriteLine("2- Procesar y mostrar resultados encuesta");
            Console.WriteLine("(otro)- Salir.");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
        static void MostrarPantallaRegistrarEncuesta()
        {
            Console.Clear();
            Console.WriteLine("Determinar cantidad de días del mes \n\n");

            Console.WriteLine("Ingrese la opinion ((1)-negativo-(2) positivo-(otro) indeciso\n");
            int opinion = Convert.ToInt32(Console.ReadLine());

            servicio.RegistrarOpinion(opinion);

            Console.WriteLine("\n\n\nPresione una tecla para continuar");
            Console.ReadKey();
        }
        static void MostrarPantallaProcesarMostrarResultadosEncuesta()
        {
            Console.Clear();
            Console.WriteLine("Resultados encuesta. \n\n");

            servicio.ProcesarEncuesta();

            Console.WriteLine($"Positivos: {servicio.PorcentajePositivos:f2}%");
            Console.WriteLine($"Negativos: {servicio.PorcentajeNegativos:f2}%");
            Console.WriteLine($"Indecisos: {servicio.PorcentajeIndecisos:f2}%");

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
                        MostrarPantallaRegistrarEncuesta();
                        break;
                    case 2:
                        MostrarPantallaProcesarMostrarResultadosEncuesta();
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
