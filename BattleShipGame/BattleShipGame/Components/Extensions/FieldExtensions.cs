using BattleShipGame.Components.Boards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleShipGame.Components.Extensions
{
    public static class FieldExtensions
    {
        public static List<Field> Range(this List<Field> panels, int startRow, int startColumn, int endRow, int endColumn)
        {
            return panels.Where(x => x.Coordinates.Row >= startRow
                                     && x.Coordinates.Column >= startColumn
                                     && x.Coordinates.Row <= endRow
                                     && x.Coordinates.Column <= endColumn).ToList();
        }

        public static Field At(this List<Field> panels, int row, int column)
        {
            return panels.Where(x => x.Coordinates.Row == row && x.Coordinates.Column == column).First();
        }
    }
}
