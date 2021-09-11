using System;
using System.Collections.Generic;
using System.Text;
using Examen_t1_calidad;
using NUnit.Framework;

namespace Examen_t1_calidad.Test
{
   public class PokerTesting
    {
        [Test]
        public void caso01()
        {
            Jugador jugador1 = new Jugador {cartas1= "10 de trebol", cartas2="11 de trebol",cartas3= "12 de trebol", cartas4="13 de trebol",cartas5="as de trebol" };
            Jugador jugador2 = new Jugador { cartas1 = "10 de trebol", cartas2 = "5 de trebol", cartas3 = "8 de espadas", cartas4 = "13 de trebol", cartas5 = "as de trebol" };
            var game = new Poker();
             game.setjugador1(jugador1);
             game.setjugador2(jugador2);
            var result = game.Ganador();
            Assert.AreEqual("jugador1",result );
        }
        [Test]
        public void caso02()
        {
            Jugador jugador1 = new Jugador { cartas1 = "10 de trebol", cartas2 = "11 de trebol", cartas3 = "12 de trebol", cartas4 = "13 de trebol", cartas5 = "as de trebol" };
            Jugador jugador2 = new Jugador { cartas1 = "10 de trebol", cartas2 = "5 de trebol", cartas3 = "8 de espadas", cartas4 = "13 de trebol", cartas5 = "as de trebol" };
            var game = new Poker();
            game.setjugador1(jugador1);
            game.setjugador2(jugador2);
            var result = game.Ganador();
            Assert.AreEqual("jugador1", result);
        }
    }
}
