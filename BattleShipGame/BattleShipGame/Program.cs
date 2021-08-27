using BattleShipGame.Components;
using System;

namespace BattleShipGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.PlayToEnd();
            Console.ReadLine();
        }
    }
}
