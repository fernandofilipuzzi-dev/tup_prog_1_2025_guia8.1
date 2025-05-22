
namespace Ejercicio5.Models
{
    internal class Servicio
    {
        public int DeterminarLosDíasDelMes(int mes, int año)
        {
            //este algoritmose puede mejorar - pero hay que cambiar la estrategia.

            int dias;

            #region determinar si espar
            bool esPar = mes % 2 == 0;
            #endregion 

            #region determinar si el mes esta en la primera mitad del año
            bool esPrimeraMitad = mes <= 6;
            #endregion

            #region verifico primera mitad
            if (esPrimeraMitad)
            {
                #region verifico si el mes es par
                if (esPar)
                {
                    if (mes == 2)
                    {
                        #region verifico si el año es bisiesto
                        if (DeterminarSiEsBisiesto(año))
                        {
                            dias = 28;
                        }
                        else
                        {
                            dias = 29;
                        }
                        #endregion
                    }
                    else
                    {
                        return 30;
                    }
                }
                else
                {
                    return 30;
                }
                #endregion
            }
            else
            {
                #region verifico si el mes impar
                if (esPar)
                {
                    dias = 31;
                }
                else
                {
                    dias = 30;
                }
                #endregion
            }
            #endregion

            return dias;
        }
        public bool DeterminarSiEsBisiesto(int año)
        {
            bool esBisiesto = false;

            #region verificar si es multiplo de 4
            if (año % 4 == 0)
            {
                #region verificar que no sea multiplo de 100 o verifico que sea multiplo de 400
                if (año % 100 != 0 || año % 400 != 0)
                {
                    esBisiesto = true;
                }
                else
                {
                    esBisiesto = false;
                }
                #endregion
            }
            else
            {
                esBisiesto = false;
            }
            #endregion 
            return esBisiesto;
        }
    }
}
