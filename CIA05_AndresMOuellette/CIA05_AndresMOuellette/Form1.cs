using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIA05_AndresMOuellette
{
    public partial class Form1 : Form
    {
        List<Ball> lBalls = new List<Ball>();
        public int radius = -50;
        public Form1()
        {
            InitializeComponent();

            MouseWheel += Form1_MouseWheel;
        }
        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta >= 0)
                radius++;
            else
                radius--;

            addButton.Text = $"Add Exclusive Ball ({radius}px)";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Subtract)
                lBalls.Clear();

            Ball.Loading = true;
            lock (lBalls)
            {
                for (int x = 0; x < lBalls.Count; x++)
                {
                    lBalls[x].ShowBall();
                }
            }
            Ball.Loading = false;
        }
        private void radiusRB_Click(object sender, EventArgs e)
        {
            if(sender == radiusRB)
            {
                Ball.eSort = Ball.eSortType.eRadius;
                lBalls.Sort();
            }
            else if (sender == distanceRB)
            {
                Ball.eSort = Ball.eSortType.eDistance;
                lBalls.Sort();
            }
            else if(sender == colourRB)
            {
                Ball.eSort = Ball.eSortType.eColour;
                lBalls.Sort();
            }

            Ball.Loading = true;
            for (int x = 0; x < lBalls.Count; x++)
            {
                lBalls[x].ShowBall();
                System.Threading.Thread.Sleep(10); //pause for a bit 
                Ball.Loading = false;   
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int ballsAdded = 0;
            int ballsRemoved = 0;
            Ball tempBall;

            while (ballsAdded < 25 && ballsRemoved < 1000)
            {
                lock (lBalls)
                {
                    tempBall = new Ball(radius);
                    if (lBalls.IndexOf(tempBall) >= 0)
                    {
                        ballsRemoved++;
                    }
                    else
                    {
                        lBalls.Add(tempBall);
                        ballsAdded++;
                    }
                }
            }

            progressBar.Value = ballsRemoved;

            Ball.Loading = true;
            lock (lBalls)
            {
                for (int x = 0; x < lBalls.Count; x++)
                {
                    lBalls[x].ShowBall();
                }
            }
            Ball.Loading = false;
            Text = $"Loaded {ballsAdded} distinct blocks with {ballsRemoved} discards";
        }
    }
}
