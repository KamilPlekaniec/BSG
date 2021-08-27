using BattleShipGame.Components.Boards;
using BattleShipGame.Components.Extensions;
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
        public ShotBoard ShotBoard { get; set; }
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
            ShotBoard = new ShotBoard();
        }

        public void PlaceShips()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            foreach (var ship in Ships)
            {
                bool isOpen = true;
                while (isOpen)
                {
                    var startColumn = rnd.Next(1, 11);
                    var startRow = rnd.Next(1, 11);
                    int endRow = startRow, endColumn = startColumn;
                    var orientation = rnd.Next(1, 101) % 2;

                    List<int> panelNumbers = new List<int>();
                    if (orientation == 0)
                    {
                        for (int i = 1; i < ship.Width; i++)
                        {
                            endRow++;
                        }
                    }
                    else
                    {
                        for (int i = 1; i < ship.Width; i++)
                        {
                            endColumn++;
                        }
                    }

                    if (endRow > 10 || endColumn > 10)
                    {
                        isOpen = true;
                        continue;
                    }

                    var affectedPanels = GameBoard.Fields.Range(startRow, startColumn, endRow, endColumn);

                    if (affectedPanels.Any(x => x.IsOccupied))
                    {
                        isOpen = true;
                        continue;
                    }

                    foreach (var panel in affectedPanels)
                    {
                        panel.FieldsType = ship.FieldsType;
                    }
                    isOpen = false;
                }
            }
        }

        public void OutputBoards()
        {
            Console.WriteLine("Tablica gracza: " + Name);
            for (int row = 1; row <= 10; row++)
            {
                Console.Write("|");
                for (int ownColumn = 1; ownColumn <= 10; ownColumn++)
                {
                    Console.Write(GameBoard.Fields.At(row, ownColumn).Status + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Tablica strzałów gracza: " + Name);
            for (int row = 1; row <= 10; row++)
            {
                Console.Write("|");
                for (int firingColumn = 1; firingColumn <= 10; firingColumn++)
                {
                    Console.Write(ShotBoard.Fields.At(row, firingColumn).Status + "|");
                }
                Console.WriteLine();
            }
        }

        private Coordinates RandomShot()
        {
            var availablePanels = ShotBoard.GetOpenRandomPanels();
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            var panelID = rand.Next(availablePanels.Count);
            return availablePanels[panelID];
        }

        private Coordinates SearchingShot()
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            var hitOpponents = ShotBoard.GetHitOpponents();
            var opponentID = rand.Next(hitOpponents.Count);
            return hitOpponents[opponentID];
        }

        public Coordinates FireShot()
        {
            var hitOpponent = ShotBoard.GetHitOpponents();
            Coordinates coordinates;

            if (hitOpponent.Any())
            {
                coordinates = SearchingShot();
            }
            else
            {
                coordinates = RandomShot();
            }
            if (coordinates.Row == 1)
            {
                Console.WriteLine(Name + ": \"Strzelam na A" + coordinates.Column.ToString() + "\"");
            }
            if (coordinates.Row == 2)
            {
                Console.WriteLine(Name + ": \"Strzelam na B" + coordinates.Column.ToString() + "\"");
            }
            if (coordinates.Row == 3)
            {
                Console.WriteLine(Name + ": \"Strzelam na C" + coordinates.Column.ToString() + "\"");
            }
            if (coordinates.Row == 4)
            {
                Console.WriteLine(Name + ": \"Strzelam na D" + coordinates.Column.ToString() + "\"");
            }
            if (coordinates.Row == 5)
            {
                Console.WriteLine(Name + ": \"Strzelam na E" + coordinates.Column.ToString() + "\"");
            }
            if (coordinates.Row == 6)
            {
                Console.WriteLine(Name + ": \"Strzelam na F" + coordinates.Column.ToString() + "\"");
            }
            if (coordinates.Row == 7)
            {
                Console.WriteLine(Name + ": \"Strzelam na G" + coordinates.Column.ToString() + "\"");
            }
            if (coordinates.Row == 8)
            {
                Console.WriteLine(Name + ": \"Strzelam na H" + coordinates.Column.ToString() + "\"");
            }
            if (coordinates.Row == 9)
            {
                Console.WriteLine(Name + ": \"Strzelam na I" + coordinates.Column.ToString() + "\"");
            }
            if (coordinates.Row == 10)
            {
                Console.WriteLine(Name + ": \"Strzelam na J" + coordinates.Column.ToString() + "\"");
            }
            return coordinates;
        }
    }
}
