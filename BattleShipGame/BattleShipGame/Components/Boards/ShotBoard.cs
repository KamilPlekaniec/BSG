using BattleShipGame.Components.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleShipGame.Components.Boards
{
    public class ShotBoard : GameBoard
    {
        public List<Coordinates> GetOpenRandomPanels()
        {
            return Fields.Where(x => x.FieldsType == Ships.FieldsType.Empty && x.IsRandomAvailable).Select(x => x.Coordinates).ToList();
        }

        public List<Field> GetOpponents(Coordinates coordinates)
        {
            int row = coordinates.Row;
            int column = coordinates.Column;
            List<Field> fields = new List<Field>();
            if (column > 1)
            {
                fields.Add(Fields.At(row, column - 1));
            }
            if (row > 1)
            {
                fields.Add(Fields.At(row - 1, column));
            }
            if (row < 10)
            {
                fields.Add(Fields.At(row + 1, column));
            }
            if (column < 10)
            {
                fields.Add(Fields.At(row, column + 1));
            }
            return fields;
        }
        public List<Coordinates> GetHitOpponents()
        {
            List<Field> fields = new List<Field>();
            var hits = Fields.Where(x => x.FieldsType == Ships.FieldsType.Hit);
            foreach (var hit in hits)
            {
                fields.AddRange(GetOpponents(hit.Coordinates).ToList());
            }
            return fields.Distinct().Where(x => x.FieldsType == Ships.FieldsType.Empty).Select(x => x.Coordinates).ToList();
        }
    }
}
