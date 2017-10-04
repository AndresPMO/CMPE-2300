using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace CIA05_AndresMOuellette
{
    class Ball : IComparable
    {
        private static CDrawer _canvas = null;
        public static CDrawer canvas //is this necessary?
        {
            get { return (_canvas); }
        }

        private static Random rand = new Random();

        private float _radius;
        public float radius
        {
            set
            {
                if (value == 0)
                    value = 1;
                _radius = Math.Abs(value);
            }
        }

        private Color _ballColour;

        private PointF _pointF;
        
        public bool _highlightFlag { get; set; } //is necessary?

        public enum eSortType { eRadius, eDistance, eColour }
        public static eSortType eSort{ get; set; }

        static Ball()
        {
            _canvas = new CDrawer(800, 600, false);
            _canvas.BBColour = Color.White;
        }

        public Ball(int size) //does it have to be float?
        {
            _ballColour = RandColor.GetColor();
            radius = size;
            _pointF = new PointF(rand.Next((int)_radius, _canvas.ScaledWidth - (int)_radius), rand.Next((int)_radius, _canvas.ScaledHeight - (int)_radius));
        }

        public Ball() //does it have to be float?
        {
            _pointF = new PointF(0, 0);
        }
        public static bool Loading
        {
            set
            {
                if (value)
                    canvas.Clear();
                else
                    canvas.Render();
            }
        }
        public void ShowBall()
        {
            _canvas.AddCenteredEllipse((int)_pointF.X, (int)_pointF.Y, (int)_radius * 2, (int)_radius * 2, _ballColour);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Ball)) return false;
            Ball tempBall = obj as Ball;

            float distance = this.GetDistance(tempBall);

            return (distance <= this._radius + tempBall._radius);
        }

        public int CompareTo(object inBall)
        {
            if (!(inBall is Ball))
                throw new ArgumentException("Not a valid Ball or null");
            Ball tempBall = inBall as Ball;
            Ball origin = new Ball();

            int outCompare;
            switch (eSort)
            {
                case eSortType.eRadius:
                    outCompare = this._radius.CompareTo(tempBall._radius);
                    break;
                case eSortType.eDistance:
                    outCompare = this.GetDistance(origin).CompareTo(tempBall.GetDistance(origin));
                    break;
                case eSortType.eColour:
                    outCompare = this._ballColour.ToArgb().CompareTo(tempBall._ballColour.ToArgb());
                    break;
                default:
                    throw new Exception("Unable to find Sort Type");
            }
            return outCompare;
        }

        public float GetDistance(Ball inBall) // |srt((x2 - x1)^2 + (y2 - y1)^2)|
        {
            return (float)(Math.Abs(Math.Sqrt(Math.Pow((inBall._pointF.X - this._pointF.X), 2) + Math.Pow((inBall._pointF.Y - this._pointF.Y), 2))));
        }

        public override int GetHashCode()
        {
            return 1;
        }
    }
}
