using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RandomForFigures
{
    public class RandomHelper
    {
        private Random rand;

        public RandomHelper()
        {
            rand = new Random();
        }

        public int GetRandomMove()
        {
            int[] numbers = { -4, -3, -2, -1, 1, 2, 3, 4 };
            return numbers[this.rand.Next(0, 8)];
        }

        public Point GetRandomPosition(Point Pmax)
        {
            int x = this.rand.Next(0, Pmax.X - 50);
            int y = this.rand.Next(0, Pmax.Y - 50);
            return new Point(x, y);
        }
    }
}
