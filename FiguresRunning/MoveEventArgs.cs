using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresRunning
{
    public class MoveEventArgs: EventArgs
    {
        public MoveEventArgs(int x, int y)
        {
            BumpPoint = new Point(x, y);
        }
        public Point BumpPoint { get; private set; }

        public MoveEventArgs()
        { }

        public MoveEventArgs(Point point)
        {
            BumpPoint = point;
        }

        public MoveEventArgs(Figure figure)
        {
            BumpPoint = new Point(figure.PosX, figure.PosY);
        }

        
    }
}
