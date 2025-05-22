using Ejercicio1.Models;

namespace Ejercicio1
{
    internal class Program
    {
        static Servicio servicio = new Servicio();

        #region metodos 
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("Ingrese las siguiente opciones:");
            Console.WriteLine("1- Procesar un solo número");
            Console.WriteLine("2- Procesar varios números.");
            Console.WriteLine("3- Mostrar máximo y mínimo.");
            Console.WriteLine("4- Mostrar promedio.");
            Console.WriteLine("5- Mostrar cantidad de números ingresados.");
            Console.WriteLine("6- Reiniciar variables.");
            Console.WriteLine("(otro)- Salir.");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
        static void MostrarPantallaIniciarVariables()
        {
            Console.Clear();
            Console.WriteLine("Reiniciando las variables\n\n");
            servicio = new Servicio();
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }
        static void MostrarPantallaSolicitarNumero()
        {
            Console.Clear();
            Console.WriteLine("Ingrese un número:\n\n");
            int valor = Convert.ToInt32(Console.ReadLine());
            servicio.RegistrarValor(valor);
        }
        static void MostrarPantallaSolicitarVariosNumeros()
        {
            Console.Clear();
            Console.WriteLine("Ingrese  cuantos números va a ingresar\n\n");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            for (int n = 0; n < cantidad; n++)
            {
                MostrarPantallaSolicitarNumero();
            }
        }
        static void MostrarPantallaMaximoMinimo()
        {
            Console.Clear();
            Console.WriteLine("Máximo y Mínimo");

            Console.WriteLine("Máximo: " + servicio.Maximo);
            Console.WriteLine("Mímimo: " + servicio.Minimo+"\n\n\n");
            Console.WriteLine("Presione una tecla para volver al menú principal");
            Console.ReadKey();
        }
        static void MostrarPantallaCalcularYMostrarPromedio()
        {
            Console.Clear();

            Console.WriteLine("Pantalla de promedio\n\n");

            if (servicio.Contador > 0)
            {
                Console.WriteLine("Promedio: " +servicio.CalcularPromedio());
            }
            else
            {
                Console.WriteLine("Promedio: No se han ingresado números");
            }

            Console.WriteLine("Presione una tecla para volver al menú principal");
            Console.ReadKey();
        }
        static void MostrarPantallaCantidad()
        {
            Console.Clear();

            Console.WriteLine("Pantalla de cantidad de valores procesados\n\n");

            if (servicio.Contador > 0)
            {
                Console.WriteLine("Cantidad: " + servicio.Contador);
            }
            else
            {
                Console.WriteLine("Cantidad: No se han ingresado números");
            }

            Console.WriteLine("Presione una tecla para volver al menú principal");
            Console.ReadKey();
        }
        #endregion

        static void Main(string[] args)
        {
            MostrarPantallaIniciarVariables();

            int op = MostrarPantallaSolicitarOpcionMenu();

            #region iterar opciones menú
            while (op != -1)
            {
                #region verificar opción
                switch (op)
                {
                    case 1:
                        MostrarPantallaSolicitarNumero();
                        break;
                    case 2:
                        MostrarPantallaSolicitarVariosNumeros();
                        break;
                    case 3:
                        MostrarPantallaMaximoMinimo();
                        break;
                    case 4:
                        MostrarPantallaCalcularYMostrarPromedio();
                        break;
                    case 5:
                        MostrarPantallaCantidad();
                        break;
                    case 6:
                        MostrarPantallaIniciarVariables();
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
