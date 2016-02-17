using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AntSimulation
{
    public class Food
    {
        public Point Location { get; set; }
        public int Quantity { get; private set; }
        public int Remaining { get; set; }
        public Size Size
        {
            get
            {
                return new Size(Settings.CellSize, Settings.CellSize);
            }
        }
        public bool Exhausted
        {
            get
            {
                return (Remaining == 0);
            }
        }

        public Food(Point location, int quantity)
        {
            Location = location;
            Quantity = quantity;
            Remaining = quantity;
        }
    }
}
