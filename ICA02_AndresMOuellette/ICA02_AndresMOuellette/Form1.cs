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

namespace ICA02_AndresMOuellette
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public CDrawer canvas = new CDrawer(800, 600, false, false);
        List<Ball> balls = new List<Ball>(); 

        private void OpacityTrackBar_Scroll(object sender, EventArgs e)
        {
            OpacityLabel.Text = OpacityTrackBar.Value.ToString();
        }

        private void XSpeedTrackBar_Scroll(object sender, EventArgs e)
        {
            XSpeedLabel.Text = XSpeedTrackBar.Value.ToString();
        }

        private void YSpeedTrackBar_Scroll(object sender, EventArgs e)
        {
            YSpeedLabel.Text = YSpeedTrackBar.Value.ToString();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void timer_Tick(object sender, EventArgs e)
        {
            canvas.Clear();
            if(canvas.GetLastMouseLeftClick(out Point p))
            {
                balls.Add(new Ball(p));
            }
            foreach(Ball ball in balls)
            {
                ball.MoveBall(canvas);
                ball.ShowBall(canvas);
            }
            canvas.Render();
        }
    }
}
