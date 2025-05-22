using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Servicio
    {
        int Acumulado;
        public int Contador;
        public int Maximo;
        public int Minimo;

        public Servicio() 
        {
            Acumulado=0;
            Contador=0;
        }

        public void RegistrarValor(int valor)
        {
            Acumulado = valor;
            Contador++;

            if (Contador == 1 || valor > Maximo)
            {
                Maximo = valor;
            }
            if (Contador == 1 || valor > Minimo)
            {
                Minimo = valor;
            }
        }

        public double CalcularPromedio()
        {
            double promedio = 0;
            if (Contador > 0)
                promedio = 1.0*Acumulado / Contador;
            return promedio;
        }
    }
}
