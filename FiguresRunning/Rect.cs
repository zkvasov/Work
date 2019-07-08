using System;
using System.Drawing;
using System.Runtime.Serialization;
using RandomForFigures;

namespace FiguresRunning
{
    [DataContract]
    [Serializable]
    public class Rect : Figure
    {
        //public System.Drawing.Pen figPen = new System.Drawing.Pen(System.Drawing.Color.Orange);
        [DataMember]
        public override string Name { get; set; }
        [DataMember]
        public int Width { get; set; }                //надо ли???
        [DataMember]
        public int Height { get; set; }

        public Rect()
        { }

        public Rect(int x, int y, RandomHelper rand)
           : base(x, y, rand)
        {
            Name = MyStrings.Rectangle;
            Width = 50;
            Height = 50;
        }

        //public Rect(int x, int y,Random rand, int width, int height)
        //   : base(x, y, rand)
        //{
        //    Width = width;
        //    Height = height;
        //}

        public override void Draw(Graphics g)
        {
            g.DrawRectangle(new Pen(Color.Orange), new Rectangle(PosX, PosY, Width, Height));
        }
    }
}
