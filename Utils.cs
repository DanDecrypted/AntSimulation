using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AntSimulation
{
    class Utils
    {
        public static Point FitToGrid(Point pointToFit)
        {
            return new Point(pointToFit.X - (pointToFit.X % Settings.CellSize), pointToFit.Y - (pointToFit.Y % Settings.CellSize));
        }
    }
}
