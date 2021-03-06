﻿using System;
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
        private static CDrawer _canvas = null;
        public static CDrawer canvas
        {
            get { return (_canvas); }
        }

        private static Random rand = new Random();

        private int _blockSize;
        public int blockSize
        {
            set { _blockSize = Math.Abs(value); }
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
            blockSize = size;
            _blockCoords = new Rectangle(rand.Next(0, _canvas.ScaledWidth - _blockSize),
                rand.Next(0, _canvas.ScaledHeight - _blockSize), _blockSize, _blockSize);
        }

        public Block(Point point, int size)
        {
            _blockColour = Color.Transparent;
            blockSize = size;
            _blockCoords = new Rectangle(point.X - (_blockSize / 2), point.Y - (_blockSize / 2), _blockSize, _blockSize);
            _highlightFlag = true;
        }
        public Block(Block blockIn)
        {
            _blockColour = blockIn._blockColour;
            _blockSize = blockIn._blockSize + 2;
            _blockCoords = new Rectangle(blockIn._blockCoords.X - 1, blockIn._blockCoords.Y - 1, _blockSize, _blockSize);
        }

        public void ShowBlock()
        {
            int highLight = 0;
            if (_highlightFlag)
                highLight = 1;
            _canvas.AddRectangle(_blockCoords.X, _blockCoords.Y, _blockSize, _blockSize,
                _blockColour, highLight, Color.Yellow);
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
            if (obj is Block)
            {
                Block tempBlock = (Block)obj;
                return (this._blockCoords.IntersectsWith(tempBlock._blockCoords));
            }
            return false;
        }

        public override int GetHashCode()
        {
            return 1;
        }
    }
}
