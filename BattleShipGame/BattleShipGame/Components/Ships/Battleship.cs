using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipGame.Components.Ships
{
    public class Battleship : Ship
    {
        public Battleship()
        {
            Name = "Okręt wojenny";
            Width = 4;
            FieldsType = FieldsType.Battleship;
        }
    }
}
