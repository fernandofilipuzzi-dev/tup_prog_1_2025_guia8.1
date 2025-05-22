
namespace Ejercicio3.Models
{
    internal class Servicio
    {
        public string Nombre0;
        public int NumeroLibreta0;
        public string Nombre1;
        public int NumeroLibreta1;
        public string Nombre2;
        public int NumeroLibreta2;
        public int Orden = 0;

        public void RegistrarNombreYNumeroLibreta(string nombre, int numeroLibreta)
        {
            if (Orden == 0)
            {
                Nombre0 = nombre;
                NumeroLibreta0 = numeroLibreta;
            }
            else if (Orden == 1)
            {
                if (numeroLibreta < NumeroLibreta0)
                {
                    Nombre1 = Nombre0;
                    NumeroLibreta1 = NumeroLibreta0;
                    Nombre0 = nombre;
                    NumeroLibreta0 = numeroLibreta;
                }
                else
                {
                    Nombre1 = nombre;
                    NumeroLibreta1 = numeroLibreta;
                }
            }
            else if (Orden == 2)
            {
                if (numeroLibreta < NumeroLibreta0)
                {
                    Nombre2 = Nombre1;
                    NumeroLibreta2 = NumeroLibreta1;
                    Nombre1 = Nombre0;
                    NumeroLibreta1 = NumeroLibreta0;
                    Nombre0 = nombre;
                    NumeroLibreta0 = numeroLibreta;
                }
                if (numeroLibreta < NumeroLibreta1)
                {
                    Nombre2 = Nombre1;
                    NumeroLibreta2 = NumeroLibreta1;
                    Nombre1 = nombre;
                    NumeroLibreta1 = numeroLibreta;
                }
                else
                {
                    Nombre2 = nombre;
                    NumeroLibreta2 = numeroLibreta;
                }
            }
            Orden++;
        }
    }
}
