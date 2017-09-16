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
        private Thread m_tdecode; //thread control for decoder

		public Form1()
		{
			InitializeComponent();
		}

		private void TSGoButton_Click(object sender, EventArgs e)
		{
            Bitmap bm = new Bitmap(pictureBox.Image);
            m_tdecode = new Thread(new ThreadStart(Decode(bm)));
            m_tdecode.IsBackground = true;
            m_tdecode.Start();
        }

        private void Decode(Bitmap canv)
        {

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
