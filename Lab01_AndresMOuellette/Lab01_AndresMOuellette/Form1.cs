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
        public delegate void delvoidint(int i);

        public enum inColourDecode { R, G, B, RGB}

        struct ImageInput
        {
            public Bitmap Image;
            public inColourDecode ColourDecode; 
            public ImageInput(Bitmap image, inColourDecode decode)
            {
                Image = image;
                ColourDecode = decode;
            }
        }

        public void DisplayImage(Bitmap bm)
        {
            pictureBox.Image = bm;
        }

        public void ProgressChange(int i)
        {
            TSProgressBar.Value = i;
        }

        private void TSGoButton_Click(object sender, EventArgs e)
		{
            TSProgressBar.Value = 0;                                    //start the progress bar @ 0
            Bitmap bm = new Bitmap(pictureBox.Image);
            Thread tdecode = new Thread(new ParameterizedThreadStart(Decode));
            tdecode.IsBackground = true;
            tdecode.Start(new ImageInput(bm, (inColourDecode)(TSRGBComboBox.SelectedIndex)));
        }

        private void Decode(object input)
        {
            if (input is ImageInput)
            {
                ImageInput tempII = (ImageInput)input;
                Bitmap tempBM = tempII.Image;
                inColourDecode colourDecode = tempII.ColourDecode;
                float progress;

                for (int y = 0; y < tempBM.Height; y++)
                {
                    for (int x = 0; x < tempBM.Width; x++)
                    {
                        byte R = tempBM.GetPixel(x, y).R;
                        byte G = tempBM.GetPixel(x, y).G;
                        byte B = tempBM.GetPixel(x, y).B;

                        //If the pixel is set, make it full, if not, make it black. Do this for R, G and B seperately
                        //then do it for RGB together.

                        //For R
                        if (colourDecode == inColourDecode.R)
                        {
                            if ((R & 1) == 1)
                            {
                                tempBM.SetPixel(x, y, Color.Red);
                            }
                            else
                            {
                                tempBM.SetPixel(x, y, Color.Black);
                            }
                        }
                        //For G
                        else if (colourDecode == inColourDecode.G)
                        {
                            if ((G & 1) == 1)
                            {
                                tempBM.SetPixel(x, y, Color.Green);
                            }
                            else
                            {
                                tempBM.SetPixel(x, y, Color.Black);
                            }
                        }
                        //For B
                        else if (colourDecode == inColourDecode.B)
                        {
                            if ((B & 1) == 1)
                            {
                                tempBM.SetPixel(x, y, Color.Blue);
                            }
                            else
                            {
                                tempBM.SetPixel(x, y, Color.Black);
                            }
                        }
                        //For RGB
                        else if (colourDecode == inColourDecode.RGB)
                        {
                            if ((R & 1) == 1)
                                R = 255;
                            else
                                R = 0;

                            if ((G & 1) == 1)
                                G = 255;
                            else
                                G = 0;

                            if ((B & 1) == 1)
                                B = 255;
                            else
                                B = 0;
                            tempBM.SetPixel(x, y, Color.FromArgb(R, G, B));
                        }
                    }
                    progress = (y + 1) / tempBM.Height;
                    Invoke(new delvoidint(ProgressChange), (int)(progress * 100));
                }
                Invoke(new delvoidBitmap(DisplayImage), tempBM);
            }
        }

		private void TSLoadImgButton_Click(object sender, EventArgs e)
		{
			try
			{
				if(openFileDialog.ShowDialog() == DialogResult.OK)
				{
					pictureBox.Load(openFileDialog.FileName);
                    pictureBox.Height = pictureBox.Image.Height;
                    pictureBox.Width = pictureBox.Image.Width;
				}
			}
			catch
			{
				MessageBox.Show("Unable to open image!", Text);
			}
		}
    }
}
