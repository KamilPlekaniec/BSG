using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

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

            Player1.PlaceShips();
            Player2.PlaceShips();
        }

        public void SingleRound()
        {
            Console.Clear();
            var coordinates = Player1.FireShot();
            var result = Player2.ProcessShot(coordinates);
            Player1.ProcessShotResult(coordinates, result);

            if (!Player2.HasLost)
            {
                coordinates = Player2.FireShot();
                result = Player1.ProcessShot(coordinates);
                Player2.ProcessShotResult(coordinates, result);
            }
            Player1.OutputBoards();
            Thread.Sleep(1500);
        }

        public void PlayToEnd()
        {
            while (!Player1.HasLost && !Player2.HasLost)
            {
                SingleRound();
            }

            if (Player1.HasLost)
            {
                Console.WriteLine("\n" + Player2.Name + " wygrał grę!");
                Player2.OutputBoards();
            }
            else if (Player2.HasLost)
            {
                Console.WriteLine("\n" + Player1.Name + " wygrał grę!");
                Player2.OutputBoards();
            }
        }
    }
}
