
using Ejercicio7.Models;

namespace Ejercicio7
{
    internal class Program
    {
        static Servicio servicio=new Servicio();

        #region metodos de impresión de pantallas
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("Ingrese las siguiente opciones:\n\n");
            Console.WriteLine("1- Ingresar un resumen de venta");
            Console.WriteLine("2- Mostrar Número de transacción registrado con el mayor monto total");
            Console.WriteLine("3- Mostrar Porcentaje de recaudación por rubro");
            Console.WriteLine("4- Mostrar recaudación por rubro y recaudación total");
            Console.WriteLine("(otro)- Salir.");

            int op = Convert.ToInt32( Console.ReadLine() );
            return op;
        }

        static void MostrarPantallaRegistrarTransaccion()
        {
            Console.Clear();
            Console.WriteLine("Registre la transacción de venta. \n\n");

            Console.WriteLine("\nNumero de transacción: \n");
            int nro=Convert.ToInt32( Console.ReadLine() );

            Console.WriteLine("\n\n\nNumero de rubro (de 1 a 5): \n");
            int rubro = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\n\nCantidad de productos: \n");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\n\nMonto total de la transacción: \n");
            double monto = Convert.ToDouble(Console.ReadLine());

            servicio.EvaluarTransaccionPuntoDeVenta(nro, rubro, cantidad, monto);

            Console.WriteLine("\n\n\n\n\nPresione una tecla para continuar");
            Console.ReadKey();
        }

        static void MostrarPantallaTransaccionMayorMonto()
        {
            Console.Clear();
            Console.WriteLine("Transacción con mayor monto en ventas\n\n");

            Console.WriteLine($"Número de transacción: {servicio.NumeroTransaccionMayor}\n");
            Console.WriteLine($"Monto Total: ${servicio.MontoTransaccionMayor:f2}\n\n\n");

            Console.WriteLine("\n\n\nPresione una tecla para continuar");
            Console.ReadKey();
        }

        static void MostrarPantallaPorcentajeDeCantidadesPorRubro()
        {
            Console.Clear();
            Console.WriteLine("\n\t\tPorcentaje de ventas por rubo \n\n");

            servicio.CalcularPorcentajesCantidadVentasPorRubro();

            Console.WriteLine($"Rubro 1: {servicio.PorcentajeCantidadRubro1:f2}%\n");
            Console.WriteLine($"Rubro 2: {servicio.PorcentajeCantidadRubro2:f2}%\n");
            Console.WriteLine($"Rubro 3: {servicio.PorcentajeCantidadRubro3:f2}%\n");
            Console.WriteLine($"Rubro 4: {servicio.PorcentajeCantidadRubro4:f2}%\n");
            Console.WriteLine($"Rubro 5: {servicio.PorcentajeCantidadRubro5:f2}%\n\n\n\n");

            Console.WriteLine("\n\n\nPresione una tecla para continuar");
            Console.ReadKey();
        }
        
        static void MostrarPantallaMontoRecaudadoTotal()
        {
            Console.Clear();
            Console.WriteLine("Monto total recaudado. \n\n");

            Console.WriteLine($"Monto: ${servicio.RecaudacionTotal:f2}\n\n\n");

            Console.WriteLine("\n\n\nPresione una tecla para continuar");
            Console.ReadKey();
        }

        #endregion

        static void Main(string[] args)
        {
            servicio.InicializarVariables();

            int op = MostrarPantallaSolicitarOpcionMenu();

            #region iterar opciones menú
            while (op != -1)
            {
                #region verificar opción
                switch (op)
                {
                    case 1:
                        MostrarPantallaRegistrarTransaccion();
                        break;
                    case 2:
                        MostrarPantallaTransaccionMayorMonto();
                        break;
                    case 3:
                        MostrarPantallaPorcentajeDeCantidadesPorRubro();
                        break;
                    case 4:
                        MostrarPantallaMontoRecaudadoTotal();
                        break;
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
