using BattleShipGame.Components.Boards;
using BattleShipGame.Components.Ships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleShipGame.Components
{
    public class Player
    {
        public string Name { get; set; }
        public GameBoard GameBoard { get; set; }
        public List<Ship> Ships { get; set; }
        public bool HasLost
        {
            get
            {
                return Ships.All(x => x.IsSunk);
            }
        }

        public Player(string name)
        {
            Name = name;
            Ships = new List<Ship>()
            {
                new Carrier(),
                new Battleship(),
                new Destroyer(),
                new Submarine(),
                new PatrolBoat()
            };
            GameBoard = new GameBoard();
        }
    }
}
