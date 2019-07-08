using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RandomForFigures;

namespace FiguresRunning
{
    [DataContract]
    [Serializable]
    public class Circle : Figure
    {
        //public Pen figPen = new Pen(Color.Red);
        [DataMember]
        public override string Name { get; set; }
        [DataMember]
        public int Diametr { get; set; }                //надо ли???

        public Circle()
        { }

        public Circle(int x, int y, RandomHelper rand)
           : base(x, y, rand)
        {
            Name = MyStrings.Circle;
            Diametr = 50;
        }

        //public Circle(int x, int y, Random rand, int radius)
        //   : base(x, y, rand)
        //{
        //    Radius = radius;
        //}

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(new Pen(Color.Red), new Rectangle(PosX, PosY, Diametr, Diametr));
        }

    }
}
