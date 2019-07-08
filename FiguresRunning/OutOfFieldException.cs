using System;
using System.Drawing;

namespace FiguresRunning
{
    [Serializable]
    public class OutOfFieldException : Exception
    {
        private Figure figure;
        private Point point;

        public string Figure
        {
            get
            {
                return figure.Name;
            }
        }

        public string Point
        {
            get
            {
                return String.Format("(" + point.X.ToString() + ";" + point.Y.ToString() + ")");
            }
        }
        
        public OutOfFieldException(Figure fig, Point POutside, string message): base(message)
        {
            point = POutside;
            figure = fig;
        }

        //public OutOfFieldException(Figure fig, Point POutside, string message, Exception innerException) : base(message, innerException)
        //{
        //    this.Point = POutside;
        //    this.Figure = fig;
        //}
    }
}
