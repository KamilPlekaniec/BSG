using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipGame.Components.Ships
{
    public class Destroyer : Ship
    {
        public Destroyer()
        {
            Name = "Niszczyciel";
            Width = 3;
            FieldsType = FieldsType.Destroyer;
        }
    }
}
