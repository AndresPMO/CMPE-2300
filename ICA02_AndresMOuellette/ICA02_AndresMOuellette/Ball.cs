using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace ICA02_AndresMOuellette
{
    class Ball
    {
        static Random sRand = new Random();
        private Point _centre;
        public Point Location { get { return _centre; } }
        private Color _colour;
        private int _xSpeed;
        public int XSpeed { set { _xSpeed = value; } }
        private int _ySpeed;
        public int YSpeed
        {
            set
            {
                if (value > 10)
                    _ySpeed = 10;
                else if (value < -10)
                    _ySpeed = -10;
                else
                    _ySpeed = value;
            }
        }
        public int Opacity { private get; set; }
        public int Radius { get; }
        public Ball(Point point)
        {
            _centre = point;
            _colour = RandColor.GetColor();
            Radius = 40;
            XSpeed = sRand.Next(-10, 11);
            YSpeed = sRand.Next(-10, 11);
            Opacity = 128;
        }
        public void MoveBall(CDrawer canv)
        {
            if ((Location.X + _xSpeed) > canv.m_ciWidth || (Location.X + _xSpeed) < 0) //canv.ActualWidth doesnt work!
                _xSpeed *= -1;
            if ((Location.Y + _ySpeed) > canv.m_ciHeight || (Location.Y + _ySpeed) < 0) //canv.ActualHeight doesnt work!
                _ySpeed *= -1;

            _centre.X += _xSpeed;
            _centre.Y += _ySpeed;
        }
        public void ShowBall(CDrawer canv)
        {
            canv.AddCenteredEllipse(Location, Radius, Radius, Color.FromArgb(Opacity, _colour));
        }
        public override string ToString()
        {
            return Location.ToString() + " - Vel: [" + _xSpeed.ToString() + ", " + _ySpeed.ToString() + "], Opacity: " + Opacity.ToString();
        }
    }
}
