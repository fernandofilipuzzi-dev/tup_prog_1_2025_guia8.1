using Ejercicio3.Models;

namespace Ejercicio3
{
    internal class Program
    {
        static Servicio servicio=new Servicio();

        #region metodos 
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("Ingrese las siguiente opciones:\n\n");
            Console.WriteLine("1- Registrar las notas de los tres alumnos");
            Console.WriteLine("2- Mostrar lista ordenada");
            Console.WriteLine("(otro)- Salir.");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }

        static void MostrarPantallaSolicitarAlumnos()
        {
            Console.Clear();
            Console.WriteLine("Ingrese los nombres de alumnos y el numero de libreta de cada uno \n\n");

            for (int nro = 0; nro < 3; nro++)
            {
                Console.WriteLine("Alumno: " + (nro + 1) + "\n");
                string nombre = Console.ReadLine();
                int nota = Convert.ToInt32(Console.ReadLine());

                servicio.RegistrarNombreYNumeroLibreta(nombre, nota);
            }

            Console.WriteLine("\n\n\nPresione una tecla para continuar");
            Console.ReadKey();
        }

        static void MostrarPantallaMostrarListaOrdenada()
        {
            Console.Clear();
            Console.WriteLine("Reparto de dinero: \n\n");

            Console.WriteLine($"{servicio.Nombre0,20}|{servicio.NumeroLibreta0,10}");
            Console.WriteLine($"{servicio.Nombre1,20}|{servicio.NumeroLibreta1,10}");
            Console.WriteLine($"{servicio.Nombre2,20}|{servicio.NumeroLibreta2,10}");

            Console.WriteLine("\n\n\nPresione una tecla para volver al menú principal");
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
                        MostrarPantallaSolicitarAlumnos();
                        break;
                    case 2:
                        MostrarPantallaMostrarListaOrdenada();
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
