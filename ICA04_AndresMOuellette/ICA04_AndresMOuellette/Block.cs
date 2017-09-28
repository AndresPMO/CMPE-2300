using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace ICA04_AndresMOuellette
{
    class Block
    {
        private static CDrawer _canvas;
        public static CDrawer canvas
        {
            get { return (_canvas); }
        }

        private static Random rand = new Random();

        private Point _location;

        private int _blockSize;
        public int blockSize
        {
            set { Math.Abs(value); }
        }

        private Color _blockColour;

        private Rectangle _blockCoords;

        public bool _highlightFlag { get; set; } //this is a part B thing

        static Block()
        {
            _canvas = new CDrawer(800, 600, false);
        }

        public Block(int size)
        {
            _blockColour = RandColor.GetColor();
            _blockSize = size;
            _location.X = rand.Next(size / 2, 801 - (size / 2));
            _location.Y = rand.Next(size / 2, 601 - (size / 2));
            //need to put the cross-over thing here
        }

        public void ShowBlock()
        {
            _canvas.AddRectangle(_location.X, _location.Y, _blockSize, _blockSize); //add the highlight thing later
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

        public override bool Equals(object obj)
        {
            //supply true if (block)obj would "touch" another
            //use utility method in the Rectangle class called IntersectsWith()
            if (this.IntersectsWith(obj))
            {
                return true;
            }
        }
    }
}
