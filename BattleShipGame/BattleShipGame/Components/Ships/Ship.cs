using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BattleShipGame.Components.Ships
{
    public enum FieldsType
    {
        [Description("*")]
        Carrier,
        [Description("&")]
        Battleship,
        [Description("@")]
        Destroyer,
        [Description("$")]
        Submarine,
        [Description("#")]
        PatrolBoat,
        [Description(" ")]
        Empty,
        [Description("+")]
        Hit,
        [Description("-")]
        Miss
    }
    public class Ship
    {
        public string Name { get; set; }
        public int Width { get; set; }
        public int Hits { get; set; }
        public FieldsType FieldsType { get; set; }
        public bool IsSunk
        {
            get
            {
                return Hits >= Width;
            }
        }
    }
}
