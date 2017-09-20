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

        }
        public void ShowBall(CDrawer canv)
        {
            canv.AddCenteredEllipse(Location, Radius, Radius, Color.FromArgb(Opacity, _colour));
        }
        public override string ToString()
        {
            return Location.ToString() + ;
        }
    }
}
