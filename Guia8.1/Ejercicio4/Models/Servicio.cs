
namespace Ejercicio4.Models
{
    internal class Servicio
    {
        string jugador1;
        int setGanados1;
        string jugador2;
        int setGanados2;

        public void RegistrarJugadores(string nombre1, string nombre2)
        {
            jugador1 = nombre1;
            jugador2 = nombre2;
            setGanados1 = 0;
            setGanados2 = 0;
        }
        public void RegistrarResultadoSet(int resultado1, int resultado2)
        {
            setGanados1 += resultado1;
            setGanados2 += resultado2;
        }
        public string DeterminarGanador()
        {
            if (setGanados1 > setGanados2)
                return jugador1;
            else if (setGanados1 < setGanados2)
                return jugador2;
            return "No hay ganador";
        }
    }
}
