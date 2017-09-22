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
        private static int _Radius;

        public static int Radius
        {
            get { return _Radius; }
            set
            {
                if (Math.Abs(value) < (canvas.m_ciWidth / 4) && Math.Abs(value) < (canvas.m_ciHeight / 4))
                    Math.Abs(value);
            }
        }

        private Color _colour;
        private Point _location;
        private int _xSpeed, _ySpeed;
        private int _iAlive;

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

        static Ball()
        {
            canvas = new CDrawer(rand.Next(600, 901), rand.Next(500, 800), false);
            Radius = rand.Next(10, 81);
        }
        public Ball()
        {
            _colour = RandColor.GetColor();
            _xSpeed = rand.Next(-10, 11);
            _ySpeed = rand.Next(-10, 11);
            _location = new Point((rand.Next(0, canvas.m_ciWidth + 1) - Radius), 
                (rand.Next(0, canvas.m_ciHeight + 1) - Radius));
        }

        public void ShowBall()
        {
            canvas.AddCenteredEllipse(_location, Radius * 2, Radius * 2, Color.FromArgb(_iAlive, _colour));
        }
        public void MoveBall()
        {
            _iAlive -= 1;
            if (_iAlive < 1)
            {
                _location = new Point((rand.Next(Radius, canvas.m_ciWidth + 1) - Radius),
                    (rand.Next(Radius, canvas.m_ciHeight + 1) - Radius));
                _iAlive = rand.Next(50, 128);
            }

            if((_location.X + _xSpeed) + Radius > canvas.m_ciWidth || (_location.X + _xSpeed) - Radius < 0)
            {
                _xSpeed *= -1;
            }
            if ((_location.Y + _ySpeed) + Radius > canvas.m_ciHeight || (_location.Y + _ySpeed) - Radius < 0)
            {
                _ySpeed *= -1;
            }
            _location.X += _xSpeed;
            _location.Y += _ySpeed;

            if ((_location.X + Radius) > canvas.m_ciWidth)
                _location.X -= (_location.X + Radius - canvas.m_ciWidth);   //right
            if ((_location.X - Radius) < 0)
                _location.X -= (_location.X - Radius);                      //left

            if ((_location.Y + Radius) > canvas.m_ciHeight)
                _location.Y -= (_location.Y + Radius - canvas.m_ciHeight);   //down
            if ((_location.Y - Radius) < canvas.m_ciHeight)
                _location.X -= (_location.Y - Radius);   //up
        }
    }
}
