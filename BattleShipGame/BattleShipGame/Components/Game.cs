using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipGame.Components
{
    public class Game
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public Game()
        {
            Console.WriteLine("Wprowadź nazwę gracza: ");
            var player1Name = Console.ReadLine();
            Console.Clear();

            Player1 = new Player(player1Name);
            Player2 = new Player("KomputerowyGracz");
        }
    }
}
