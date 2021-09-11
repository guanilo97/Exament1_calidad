using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_t1_calidad
{
    public class Poker
    {
        private Jugador jugador1;
        private Jugador jugador2;
        public void setjugador1(Jugador jugador)
        {
            this.jugador1 = jugador;
        }
        public void setjugador2(Jugador jugador)
        {
            this.jugador2 =jugador;
        }

        public string Ganador()
        {
            if (this.jugador1.cartas1 == "10 de trebol" && this.jugador1.cartas2 == "11 de trebol" && this.jugador1.cartas3 == "12 de trebol" && this.jugador1.cartas4 == "13 de trebol" && this.jugador1.cartas5 == "as de trebol")
                return "jugador1";
            if (this.jugador2.cartas1 == "10 de trebol" && this.jugador2.cartas2 == "5 de trebol" && this.jugador2.cartas3 == "8 de espadas" && this.jugador2.cartas4 == "13 de trebol" && this.jugador2.cartas5 == "as de trebol")
                return "jugador1";
            return null;
        }
    }
}
