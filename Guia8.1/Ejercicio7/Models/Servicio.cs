
namespace Ejercicio7.Models
{
    internal class Servicio
    {
        int cantidad1;
        int cantidad2;
        int cantidad3;
        int cantidad4;
        int cantidad5;
        public int NumeroTransaccionMayor;
        public double MontoTransaccionMayor;

        int contadorDeTransacciones = 0;

        public double PorcentajeCantidadRubro1;
        public double PorcentajeCantidadRubro2;
        public double PorcentajeCantidadRubro3;
        public double PorcentajeCantidadRubro4;
        public double PorcentajeCantidadRubro5;

        public double RecaudacionTotal = 0;

        public void InicializarVariables()
        {
            cantidad1 = 0;
            cantidad2 = 0;
            cantidad3 = 0;
            cantidad4 = 0;
            cantidad5 = 0;
            NumeroTransaccionMayor = 0;
            MontoTransaccionMayor = 0;

            contadorDeTransacciones = 0;

            PorcentajeCantidadRubro1 = 0;
            PorcentajeCantidadRubro2 = 0;
            PorcentajeCantidadRubro3 = 0;
            PorcentajeCantidadRubro4 = 0;
            PorcentajeCantidadRubro5 = 0;

            RecaudacionTotal = 0;
        }

        public void EvaluarTransaccionPuntoDeVenta(int nroTransaccion, int rubro, int cantidad, double monto)
        {
            switch (rubro)
            {
                case 1:
                    cantidad1 += cantidad;
                    break;
                case 2:
                    cantidad2 += cantidad;
                    break;
                case 3:
                    cantidad3 += cantidad;
                    break;
                case 4:
                    cantidad4 += cantidad;
                    break;
                case 5:
                    cantidad5 += cantidad;
                    break;
                default:
                    break;
            }
            RecaudacionTotal += monto;

            if (contadorDeTransacciones == 0 || monto > MontoTransaccionMayor)
            {
                NumeroTransaccionMayor = nroTransaccion;
                MontoTransaccionMayor = monto;
            }
        }
        public void CalcularPorcentajesCantidadVentasPorRubro()
        {
            int CantidadTotal = cantidad1 + cantidad2 + cantidad3 + cantidad4 + cantidad5;

            PorcentajeCantidadRubro1 = 0;
            PorcentajeCantidadRubro2 = 0;
            PorcentajeCantidadRubro3 = 0;
            PorcentajeCantidadRubro4 = 0;
            PorcentajeCantidadRubro5 = 0;

            if (CantidadTotal > 0)
            {
                PorcentajeCantidadRubro1 = 100.0 * cantidad1 / CantidadTotal;
                PorcentajeCantidadRubro2 = 100.0 * cantidad2 / CantidadTotal;
                PorcentajeCantidadRubro3 = 100.0 * cantidad3 / CantidadTotal;
                PorcentajeCantidadRubro4 = 100.0 * cantidad4 / CantidadTotal;
                PorcentajeCantidadRubro5 = 100.0 * cantidad5 / CantidadTotal;
            }
        }
    }
}
