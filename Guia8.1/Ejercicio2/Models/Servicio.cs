using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    internal class Servicio
    {
        public int Edad0;
        public int Edad1;
        public int Edad2;
        public int Edad3;
        public double Monto;
        public double Porcentaje0;
        public double Porcentaje1;
        public double Porcentaje2;
        public double Porcentaje3;
        public double Monto0;
        public double Monto1;
        public double Monto2;
        public double Monto3;

        public void RegistrarMontoARepartir(double monto)
        {
            Monto = monto;
        }

        public void RegistrarEdad(int edad, int nroNiña)
        {
            switch (nroNiña)
            {
                case 0: Edad0 = edad; break;
                case 1: Edad1 = edad; break;
                case 2: Edad2 = edad; break;
                case 3: Edad3 = edad; break;
            }
        }

        public void CalcularMontosYPorcentajesARepartir()
        {
            double edadTotal = Edad0 + Edad1 + Edad2 + Edad3;
            Porcentaje0 = 1.0 * Edad0 / edadTotal * 100;
            Porcentaje1 = 1.0 * Edad1 / edadTotal * 100;
            Porcentaje2 = 1.0 * Edad2 / edadTotal * 100;
            Porcentaje3 = 1.0 * Edad3 / edadTotal * 100;
            Monto0 = Monto * Porcentaje0 / 100;
            Monto1 = Monto * Porcentaje1 / 100;
            Monto2 = Monto * Porcentaje2 / 100;
            Monto3 = Monto * Porcentaje3 / 100;
        }
    }
}
