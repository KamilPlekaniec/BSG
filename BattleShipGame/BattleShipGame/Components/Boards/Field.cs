using BattleShipGame.Components.Ships;
using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipGame.Components.Boards
{
    public class Field
    {
        public FieldsType FieldsType { get; set; }
        public Coordinates Coordinates { get; set; }

        public Field(int row, int column)
        {
            Coordinates = new Coordinates(row, column);
            FieldsType = FieldsType.Empty;
        }

        public bool IsOccupied
        {
            get
            {
                return FieldsType == FieldsType.Battleship
                    || FieldsType == FieldsType.Carrier
                    || FieldsType == FieldsType.Destroyer
                    || FieldsType == FieldsType.PatrolBoat
                    || FieldsType == FieldsType.Submarine;
            }
        }

        public bool IsRandomAvailable
        {
            get
            {
                return (Coordinates.Row % 2 == 0 && Coordinates.Column % 2 == 0)
                    || (Coordinates.Row % 2 == 1 && Coordinates.Column % 2 == 1);
            }
        }
    }
}
