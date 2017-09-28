using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace ICA04_AndresMOuellette
{
    public partial class Form1 : Form
    {
        public int blockSize = 50;
        List<Block> lBlocks = new List<Block>();
        public Form1()
        {
            InitializeComponent();

            MouseWheel += Form1_MouseWheel;
            Block.canvas.MouseMoveScaled += Canvas_MouseMoveScaled;
        }

        private void Canvas_MouseMoveScaled(Point pos, CDrawer dr)
        {
            throw new NotImplementedException(); //change this
        }

        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            if(e.Delta >= 0)
                blockSize ++;
            else
                blockSize --;

            button.Text = $"Add Blocks: Size - {blockSize}";
        }

        private void button_Click(object sender, EventArgs e)
        {
            int blocksAdded = 0;
            int blocksRemoved = 0;
            Block tempBlock;

            while (blocksAdded < 25 && blocksRemoved < 1000)
            {
                tempBlock = new Block(blockSize);
                if (lBlocks.IndexOf(tempBlock) >= 0)
                    blocksRemoved++;
                else
                {
                    lBlocks.Add(tempBlock);
                    blocksAdded++;
                }
            }

            progressBar.Value = blocksRemoved;
            Text = $"Loaded {blocksAdded} distinct blocks with {blocksRemoved} discards";

            Block.Loading = true;
            lock (lBlocks)
            {
                for (int x = 0; x < lBlocks.Count; x++)
                {
                    lBlocks[x].ShowBlock();
                }
                
            }
            Block.Loading = false;
        }
    }
}
