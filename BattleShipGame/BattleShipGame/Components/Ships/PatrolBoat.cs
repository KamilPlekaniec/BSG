using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipGame.Components.Ships
{
    public class PatrolBoat : Ship
    {
        public PatrolBoat()
        {
            Name = "Łódź patrolowa";
            Width = 2;
            FieldsType = FieldsType.PatrolBoat;
        }
    }
}
