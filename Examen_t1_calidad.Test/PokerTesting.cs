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
            var game = new Poker();
            game.jugador1 = (new Jugador { cartas = "10 de trebol",nombre="jugador1" });
            game.jugador2 =(new Jugador { cartas = "13 de trebol", nombre="jugador2"});
            var result = game.Ganador();
            Assert.AreEqual("jugador1", result);
        }
    }
}
