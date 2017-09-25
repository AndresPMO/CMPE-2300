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
using GDIDrawer;

namespace ICA03_AndresMOuellette
{
    public partial class Form1 : Form
    {
        List<Ball> balls = new List<Ball>();
        public Form1()
        {
            InitializeComponent();
            MouseWheel += Form1_MouseWheel;
            
            Thread thread = new Thread(new ThreadStart(ThreadMethod));
            thread.IsBackground = true;
            thread.Start();
        }

        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            //throw new NotImplementedException();
            Ball.Radius += (e.Delta / 10);
        }

        private void ThreadMethod()
        {
            while (true)
            { //***add lock here (ppt has notes on it)
                lock (balls)
                {
                    Ball.Loading = true;
                    for (int x = 0; x < balls.Count; x++)
                    {
                        balls[x].MoveBall();
                        balls[x].ShowBall();
                    }
                    Ball.Loading = false;
                    Thread.Sleep(50);
                }
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            lock (balls)
            {
                if (e.KeyCode == Keys.Add)
                {
                    for (int x = 5; x > 0; x--)
                        balls.Add(new Ball());
                }
                else if (e.KeyCode == Keys.Clear)
                    balls.Clear();
            }
        }
    }
}
