
using Ejercicio2.Models;

namespace Ejercicio2
{
    internal class Program
    {
        static Servicio servicio = new Servicio();

        #region metodos 
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("Ingrese las siguiente opciones:\n\n");
            Console.WriteLine("1- Iniciar Monto a repartir");
            Console.WriteLine("2- Solicitar Edad Por niña");
            Console.WriteLine("3- Mostrar monto y porcentajes de las niñas");            
            Console.WriteLine("(otro)- Salir.");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }

        static void MostrarPantallaSolicitarMontoARepartir()
        {
            Console.Clear();
            Console.WriteLine("Monto a repartir: \n\n");

            double montoARepartir=Convert.ToDouble(Console.ReadLine());

            servicio.RegistrarMontoARepartir(montoARepartir);

            Console.WriteLine("\n\n\nPresione una tecla para continuar");
            Console.ReadKey();
        }

        static void MostrarPantallaSolicitarEdadesNiñas()
        {
            Console.Clear();
            Console.WriteLine("Edades de las niñas:\n\n");

            for (int nro = 0; nro < 4; nro++)
            {
                Console.WriteLine("Entre la edad de la niña número: "+(nro+1)+"\n");
                int edad = Convert.ToInt32(Console.ReadLine());
                servicio.RegistrarEdad(edad, nro);
            }
        }
       
        static void MostrarPantallaCalcularMostrarMontoYPorcentajePorNiña()
        {
            Console.Clear();
            Console.WriteLine("Reparto de dinero: \n\n");

            servicio.CalcularMontosYPorcentajesARepartir();

            Console.WriteLine($"Niña 1 ({servicio.Edad0}), Porcentaje: {servicio.Porcentaje0:f2}, Monto: ${servicio.Monto0:f2}");
            Console.WriteLine($"Niña 2 ({servicio.Edad1}), Porcentaje: {servicio.Porcentaje1:f2}, Monto: ${servicio.Monto1:f2}");
            Console.WriteLine($"Niña 3 ({servicio.Edad2}), Porcentaje: {servicio.Porcentaje2:f2}, Monto: ${servicio.Monto2:f2}");
            Console.WriteLine($"Niña 4 ({servicio.Edad3}), Porcentaje: {servicio.Porcentaje3:f2}, Monto: ${servicio.Monto3:f2}");

            Console.WriteLine("\n\n\nPresione una tecla para volver al menú principal");
            Console.ReadKey();
        }
        
        #endregion

        static void Main(string[] args)
        {
            MostrarPantallaSolicitarMontoARepartir();

            int op = MostrarPantallaSolicitarOpcionMenu();

            #region iterar opciones menú
            while (op != -1)
            {
                #region verificar opción
                switch (op)
                {
                    case 1:
                        MostrarPantallaSolicitarMontoARepartir();
                        break;
                    case 2:
                        MostrarPantallaSolicitarEdadesNiñas();                        
                        break;
                    case 3:
                        MostrarPantallaCalcularMostrarMontoYPorcentajePorNiña();                        
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
