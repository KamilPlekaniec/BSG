using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipGame.Components.Ships
{
    public class Submarine : Ship
    {
        public Submarine()
        {
            Name = "Łódź podwodna";
            Width = 3;
            FieldsType = FieldsType.Submarine;
        }
    }
}
