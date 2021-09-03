using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipGame.Components.Boards
{
    public class GameBoard
    {
        public const int BoardSize = 10;
        public List<Field> Fields { get; set; }
        public GameBoard()
        {
            Fields = new List<Field>();
            for (int i = 1; i <= BoardSize; i++)
            {
                for (int j = 1; j <= BoardSize; j++)
                {
                    Fields.Add(new Field(i, j));
                }
            }
        }
    }
}
