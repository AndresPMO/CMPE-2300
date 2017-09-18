using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Lab01_AndresMOuellette
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

        public delegate void delvoidvoid();                             //for increasing progressbar
        public delegate void delvoidBitmap(Bitmap bm);                  //for loading new picture

        private void TSGoButton_Click(object sender, EventArgs e)
		{
            TSProgressBar.Value = 0;                                    //start the progress bar @ 0
            Bitmap bm = new Bitmap(pictureBox.Image);
            Thread tdecode = new Thread(new ParameterizedThreadStart(Decode));
            tdecode.IsBackground = true;
            tdecode.Start(bm);
        }

        private void Decode(Bitmap canv)
        {
            for (int y = 0; y < canv.Height; y++)
            {
                for (int x = 0; x < canv.Width; x++)
                {
                    byte R = canv.GetPixel(x, y).R;
                    byte G = canv.GetPixel(x, y).G;
                    byte B = canv.GetPixel(x, y).B;

                    if (TSRGBComboBox.SelectedItem == "R")
                    {
                        if ((R & 1) == 1)
                        {
                            canv.SetPixel(x, y, Color.FromArgb(1, 255, 0, 0));
                        }
                    }
                    else if (TSRGBComboBox.SelectedItem == "G")
                    {
                        if ((G & 1) == 1)
                        {
                            canv.SetPixel(x, y, Color.FromArgb(1, 0, 255, 0));
                        }
                    }
                    else if (TSRGBComboBox.SelectedItem == "B")
                    {
                        if ((B & 1) == 1)
                        {
                            canv.SetPixel(x, y, Color.FromArgb(1, 0, 0, 255));
                        }
                    }
                    else if (TSRGBComboBox.SelectedItem == "RGB")
                    {

                    }
                }
            }
            Invoke(new delvoidBitmap(Decode), canv);
        }

		private void TSLoadImgButton_Click(object sender, EventArgs e)
		{
			try
			{
				if(openFileDialog.ShowDialog() == DialogResult.OK)
				{
					pictureBox.Load(openFileDialog.FileName);
				}
			}
			catch
			{
				MessageBox.Show("Unable to open image!", Text);
			}
		}
    }
}
