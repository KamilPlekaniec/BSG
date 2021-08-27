using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipGame.Components.Boards
{
    public class GameBoard
    {
        public List<Field> Fields { get; set; }
        public GameBoard()
        {
            Fields = new List<Field>();
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Fields.Add(new Field(i, j));
                }
            }
        }
    }
}
