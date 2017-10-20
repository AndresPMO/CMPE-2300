using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;


namespace ICA08_AndresMOuellette
{
    class Ball
    {
        static Random sRand = new Random();
        private PointF _centre;
        private float _xVel;
        private float _yVel;
        private int _radius;
        public Color _colour { get; set; }

        public Ball(PointF inPoint, Color inColour)
        {
            _centre = inPoint;
            _colour = inColour;

            _xVel = (float)sRand.NextDouble() * 10 - 5;
            _yVel = (float)sRand.NextDouble() * 10 - 5;

            _radius = sRand.Next(20, 51);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Ball)) return false;
            Ball tempBall = obj as Ball;

            float distance = this.GetDistance(tempBall);

            return (distance <= this._radius + tempBall._radius);
        }
        public override int GetHashCode()
        {
            return 1;
        }

        public float GetDistance(Ball inBall) // |srt((x2 - x1)^2 + (y2 - y1)^2)|
        {
            return (float)(Math.Abs(Math.Sqrt(Math.Pow((inBall._centre.X - this._centre.X), 2) +
                Math.Pow((inBall._centre.Y - this._centre.Y), 2))));
        }

        public void Move(CDrawer canv)
        {
            if ((_centre.X + _xVel + _radius) > canv.m_ciWidth || (_centre.X + _xVel - _radius) < 0) //canv.ActualWidth doesnt work!
            {
                //_centre.X = _radius;
                _xVel *= -1;
            }
            if ((_centre.Y + _yVel + _radius) > canv.m_ciHeight || (_centre.Y + _yVel - _radius) < 0) //canv.ActualHeight doesnt work!
            {
                //_centre.Y = _radius;
                _yVel *= -1;
            }

            _centre.X += _xVel;
            _centre.Y += _yVel;
        }
        public void Show(CDrawer canv, int i)
        {
            canv.AddCenteredEllipse((int)_centre.X, (int)_centre.Y, (int)_radius * 2, (int)_radius * 2, _colour);
            canv.AddText(i.ToString(), 14, (int)_centre.X - _radius, (int)_centre.Y - _radius, _radius * 2, _radius * 2, Color.FromArgb(_colour.ToArgb() ^ 0x00FFFFFF));
        }
    }
}
