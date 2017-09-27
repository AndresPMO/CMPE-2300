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
        private static CDrawer _canvas = new CDrawer(800, 600, false);
        public static CDrawer canvas
        {
            get { return (_canvas); }
        }

        private static Random rand = new Random();
        private int _blockSize;
        public int blockSize
        {
            set { Math.Abs(value); }
        }
        private Color _blockColour = RandColor.GetColor();
        private Rectangle _blockCoords;
    }
}
