using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace ICA03_AndresMOuellette
{
    class Ball
    {
        static Random rand = new Random();
        static CDrawer canvas = null;
        public static int Radius
        {
            get { return Radius; }
            set { Math.Abs(value); }
        }
        private Color _colour;
        private Point _point;
        private int _xSpeed, _ySpeed;
        private int _iAlive;

        static Ball()
        {
            canvas = new CDrawer(rand.Next(600, 901), rand.Next(), false);
            Radius = rand.Next(10, 81);
        }
        public Ball()
        {
            _colour = RandColor.GetColor();
            _xSpeed = rand.Next(-10, 11);
            _ySpeed = rand.Next(-10, 11);
            _point.X = (rand.Next(0, canvas.m_ciWidth + 1) - Radius);
            _point.Y = (rand.Next(0, canvas.m_ciHeight + 1) - Radius);
        }

        public void ShowBall()
        {
            canvas.AddCenteredEllipse(_point, Radius, Radius, Color.FromArgb(_iAlive, _colour));
        }
        public void MoveBall()
        {

        }
    }
}
