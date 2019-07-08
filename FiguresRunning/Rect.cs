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
    public class Rect : Figure
    {
        //public System.Drawing.Pen figPen = new System.Drawing.Pen(System.Drawing.Color.Orange);
        [DataMember]
        public override string Name { get; set; }
        //[DataMember]
        //public override int PosX { get; set; }
        //[DataMember]
        //public override int PosY { get; set; }
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
            
           // System.Drawing.Graphics g;
            //g = e.Graphics;
            //System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Orange);
            g.DrawRectangle(new Pen(Color.Orange), new Rectangle(PosX, PosY, Width, Height));
            //myPen.Dispose();
           // g.Dispose();
        }

        //public override TreeNode AddNode(List<Figure> allFigures, int countFigure)
        //{
        //    TreeNode figureNode = new TreeNode(MyStrings.Rectangle + countFigure.ToString());
        //    figureNode.Tag = allFigures[countFigure - 1];
        //    return figureNode;
        //}
    }
}
