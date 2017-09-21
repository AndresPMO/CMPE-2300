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
        static Random Rand = new Random();
        static CDrawer Canvas = null;
        public static int Radius
        {
            get { return Radius; }
            set { Math.Abs(value); }
        }
        private Color _colour;
        private Point _point;
        private int _xSpeed, ySpeed;
        private int _iAlive;

        static Ball()
        {
            Canvas = new CDrawer(Rand.Next(600, 901), Rand.Next())
        }
    }
}
