using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AntSimulation
{
    public class Nest
    {
        public Point Location { get; set; }
        public int FoodCount { get; set; }
        public Family Family;

        public Nest(Point location, Family family = Family.Yellow)
        {
            Location = location;
            Family = family;
        }
    }
}
