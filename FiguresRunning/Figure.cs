using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using RandomForFigures;

namespace FiguresRunning
{
    [DataContract]
    [KnownType(typeof(Triangle))]
    [KnownType(typeof(Rect))]
    [KnownType(typeof(Circle))]
    [Serializable]
    [System.Xml.Serialization.XmlInclude(typeof(Triangle))]
    [System.Xml.Serialization.XmlInclude(typeof(Rect))]
    [System.Xml.Serialization.XmlInclude(typeof(Circle))]
    public abstract class Figure
    {
        [DataMember]
        public abstract string Name { get; set; }
        [DataMember]
        public int PosX { get; set; }
        [DataMember]
        public int PosY { get; set; }
        //speed and direction
        [DataMember]
        public int dx { get; set; }
        [DataMember]
        public int dy { get; set; }

        //to save speed and direction after stopping
        [DataMember]
        public int bufDX { get; set; }
        [DataMember]
        public int bufDY { get; set; }
        [DataMember]
        public bool isNotMoved { get; set; }

        [DataMember]
        public Guid ID;

        public event EventHandler<MoveEventArgs> OnMove;
        //public event MoveEventHandler OnMove;

        public Figure()
        { }

        public Figure(int x, int y, RandomHelper rand)
        {
            PosX = x;
            PosY = y;
            dx = rand.GetRandomMove();
            dy = rand.GetRandomMove();
            bufDX = dx;
            bufDY = dy;
            isNotMoved = true;
            ID = Guid.NewGuid();
        }

        public void Move(Point Pmax)
        {
            IsOutOfField(Pmax);

            if (PosX < 0 || PosX > Pmax.X - 50)
                dx = -dx;
            if (PosY < 0 || PosY > Pmax.Y - 50)
                dy = -dy;
            PosX += dx;
            PosY += dy;

            OnMoved();
        }

        public abstract void Draw(Graphics g);

        public void StopMoving()
        {
            dx = 0;
            dy = 0;
        }

        public void ReturnMoving()
        {
            dx = bufDX;
            dy = bufDY;
        }

        public Point GetCurrentPosition()
        {
            return new Point(PosX, PosY);
        }

        protected void OnMoved()
        {
            //if (OnMove != null)
            //{
            //    OnMove(this, new MoveEventArgs(PosX, PosY));
            //}
            OnMove?.Invoke(this, new MoveEventArgs(PosX, PosY));
        }

        //public void ReturnToField(Point Pmax)
        //{
        //    if (PosX > Pmax.X - 50)
        //    {
        //        PosX = Pmax.X - 50;
        //        if (dx > 0)
        //            dx = -dx;
        //    }
        //    else if (PosX < -dx)
        //    {
        //        dx = -dx;
        //        PosX = dx;
        //    }

        //    if (PosY > Pmax.Y - 50)
        //    {
        //        PosY = Pmax.Y - 50;
        //        if (dy > 0)
        //            dy = -dy;
        //    }
        //    else if (PosY < -dy)
        //    {
        //        dy = -dy;
        //        PosY = dy;
        //    }
        //}

        public void ReturnToField(Point Pmax)
        {
            if(PosX > Pmax.X + dx - 50)
            {
                if(dx > 0)
                {
                    dx = -dx;
                }
                PosX = Pmax.X - 50;
            }
            else if(PosY > Pmax.Y + dy - 50)
            {
                if(dy > 0)
                {
                    dy = -dy;
                }
                PosY = Pmax.Y  -50;
            }
            else if(PosX < dx)
            {
                if(dx < 0)
                {
                    dx = -dx;
                }
                PosX = 0;
            }
            else if(PosY < dy)
            {
                if(dy < 0)
                {
                    dy = -dy;
                }
                PosY = 0;
            }
        }
        
        protected void IsOutOfField(Point Pmax)
        {
            if ((dx > 0 && PosX > (Pmax.X+dx-50)) ||
                (dy > 0 && PosY > (Pmax.Y+dy-50)) ||
                (dx < 0 && PosX < dx)             ||
                (dy < 0 && PosY < dy)               )
                throw new OutOfFieldException(this, this.GetCurrentPosition(), "Figure is out of field!");
        }
    }
}
