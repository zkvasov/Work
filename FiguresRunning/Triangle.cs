﻿using System;
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
    public class Triangle : Figure
    {
        // public System.Drawing.Pen figPen = new System.Drawing.Pen(System.Drawing.Color.Green);
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

        public Triangle()
        { }

        public Triangle(int x, int y, RandomHelper rand)
           : base(x, y, rand)
        {
            Name = MyStrings.Triangle;
            Width = 50;
            Height = 50;
        }

        //public Triangle(int x, int y, Random rand, int width, int height)
        //   : base(x, y, rand)
        //{
        //    Width = width;
        //    Height = height;
        //}
        
        public override void Draw(Graphics g)
        {
            
            Point[] points =
            {
                new Point(PosX, PosY + Height),
                new Point(PosX + Width, PosY + Height),
                new Point(PosX + Width/2, PosY ),
                new Point(PosX , PosY + Height)
            };
            //System.Drawing.Graphics g;
            //g = e.Graphics;
            g.DrawLines(new Pen(Color.Green), points);
           // myPen.Dispose();
            //g.Dispose();
        }


        //public override TreeNode AddNode(List<Figure> allFigures, int countFigure)                  //не здесь ей место
        //{
        //    TreeNode figureNode = new TreeNode(MyStrings.Triangle + countFigure.ToString());
        //    figureNode.Tag = allFigures[countFigure - 1];
        //    return figureNode;
        //}
    }
}