using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipGame.Components.Ships
{
    public class Carrier : Ship
    {
        public Carrier()
        {
            Name = "Lotniskowiec";
            Width = 5;
            FieldsType = FieldsType.Carrier;
        }
    }
}
