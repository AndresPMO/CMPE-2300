﻿using System;
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
            set { Math.Abs(value); }
        }

        private Color _ballColour;

        private Point _pointF;
        
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
            _pointF.X = rand.Next(0, _canvas.ScaledWidth - size);  //these cant be radius bc missing
            _pointF.Y = rand.Next(0, _canvas.ScaledHeight - size); //the GET, _radius is private
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
            _canvas.AddEllipse(_pointF.X, _pointF.Y, (int)_radius, (int)_radius, _ballColour);
        }

        public override bool Equals(object obj)
        {
            if (obj is Ball)
            {
                Ball tempBall = (Ball)obj;
                return (this._pointF.CompareTo(tempBall._pointF));
            }
            return false;
        }

        public float CompareTo(object inBall)
        {
            if (!(inBall is Ball))
                throw new ArgumentException("Not a valid Ball or null");
            Ball tempBall = inBall as Ball;
            Ball origin = new Ball(1);
            origin._pointF.X = 0;
            origin._pointF.Y = 0;

            float outCompare = 0;
            switch (eSort)
            {
                case eSortType.eRadius:
                    outCompare = _radius - tempBall._radius;
                    break;
                case eSortType.eDistance:
                    outCompare = (_pointF.X * _pointF.Y) - (tempBall._pointF.X * tempBall._pointF.Y);
                    break;
                case eSortType.eColour:
                    outCompare = _ballColour.ToArgb() - tempBall._ballColour.ToArgb();
                    break;
            }
            return outCompare;
        }

        public override int GetHashCode()
        {
            return 1;
        }
    }
}
