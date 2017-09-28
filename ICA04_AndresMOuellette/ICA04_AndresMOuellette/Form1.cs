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
        private Block mouseBlock;
        public Form1()
        {
            InitializeComponent();

            MouseWheel += Form1_MouseWheel;
            Block.canvas.MouseMoveScaled += Canvas_MouseMoveScaled;
            Block.canvas.MouseLeftClickScaled += Canvas_MouseLeftClickScaled;
        }

        private void Canvas_MouseLeftClickScaled(Point pos, CDrawer dr)
        {
            lock (lBlocks)
            {
                if (false)
                {
                    bool flagged = true;
                    while (flagged)
                    {
                        //if (lBlocks.Count > 0)
                        //{
                        flagged = false;
                        for (int i = 0; i < lBlocks.Count(); i++)
                        {
                            if (lBlocks[i].Equals(mouseBlock))
                            {
                                lBlocks.RemoveAt(i);
                                flagged = true;
                            }

                        }
                        //}
                        //else
                        //{
                        //    flagged = false;
                        //}
                    }
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
                else
                {
                    while (lBlocks.Remove(mouseBlock)) ;
                }
            }
        }

        private void Canvas_MouseMoveScaled(Point pos, CDrawer dr)
        {
            lock (lBlocks)
            {
                mouseBlock = new Block(pos, blockSize);
                for (int i = 0; i < lBlocks.Count(); i++)
                {
                    lBlocks[i]._highlightFlag = false;
                    if (mouseBlock.Equals(lBlocks[i]))
                        lBlocks[i]._highlightFlag = true;
                }
                Block.Loading = true;
                //lock (lBlocks)
                {
                    for (int x = 0; x < lBlocks.Count; x++)
                    {
                        lBlocks[x].ShowBlock();
                    }
                }
                mouseBlock.ShowBlock();
                Block.Loading = false;
            }
        }


        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta >= 0)
                blockSize++;
            else
                blockSize--;

            addButton.Text = $"Add Blocks: Size - {blockSize}";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int blocksAdded = 0;
            int blocksRemoved = 0;
            Block tempBlock;
            lock (lBlocks)
            {
                while (blocksAdded < 25 && blocksRemoved < 1000)
                {
                    tempBlock = new Block(blockSize);
                    if (lBlocks.IndexOf(tempBlock) >= 0)
                    {
                        blocksRemoved++;
                    }
                    else
                    {
                        lBlocks.Add(tempBlock);
                        blocksAdded++;
                    }
                }

                progressBar.Value = blocksRemoved;

                Block.Loading = true;

                for (int x = 0; x < lBlocks.Count; x++)
                {
                    lBlocks[x].ShowBlock();
                }
                Block.Loading = false;
            }
            Text = $"Loaded {blocksAdded} distinct blocks with {blocksRemoved} discards";
        }

        private void growButton_Click(object sender, EventArgs e)
        {
            lock (lBlocks)
            {
                bool changed = false;

                do
                {
                    changed = false;
                    for (int i = 0; i < lBlocks.Count(); i++)
                    {
                        Block origBlock = lBlocks[i];
                        Block tempBlock = new Block(lBlocks[i]);
                        lBlocks[i] = null;

                        if (lBlocks.IndexOf(tempBlock) >= 0)
                        {
                            lBlocks[i] = origBlock;
                        }
                        else
                        {
                            lBlocks[i] = tempBlock;
                            changed = true;
                        }
                    }
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
                while (changed);
            }
        }
    }
}
