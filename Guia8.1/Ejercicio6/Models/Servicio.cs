
namespace Ejercicio6.Models
{
    internal class Servicio
    {
        public int indecisos;
        public int negativos;
        public int positivos;
        public double PorcentajeIndecisos;
        public double PorcentajeNegativos;
        public double PorcentajePositivos;

        public void RegistrarOpinion(int opinion)
        {
            switch (opinion)
            {
                case 1:
                    negativos++;
                    break;
                case 2:
                    positivos++;
                    break;
                default:
                    indecisos++;
                    break;
            }
        }
        public void ProcesarEncuesta()
        {
            double total = indecisos + negativos + positivos;

            if (positivos > 0)
            {
                PorcentajeIndecisos = 100.0 * indecisos / total;
                PorcentajeNegativos = 100.0 * negativos / total;
                PorcentajePositivos = 100.0 * positivos / total;
            }
        }
    }
}
