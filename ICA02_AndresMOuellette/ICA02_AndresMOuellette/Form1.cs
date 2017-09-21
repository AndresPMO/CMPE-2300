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

        public CDrawer canvas = new CDrawer(800, 600, false);
        List<Ball> balls = new List<Ball>(); 

        private void OpacityTrackBar_Scroll(object sender, EventArgs e)
        {
            OpacityLabel.Text = OpacityTrackBar.Value.ToString();
            if (checkBox.Checked)
            {
                for(int x = 0; x < balls.Count; x++)
                {
                    balls[x].Opacity = OpacityTrackBar.Value;
                }
            }
            else
            {
                balls[balls.Count - 1].Opacity = OpacityTrackBar.Value;
            }
        }

        private void XSpeedTrackBar_Scroll(object sender, EventArgs e)
        {
            XSpeedLabel.Text = XSpeedTrackBar.Value.ToString();
            if (checkBox.Checked)
            {
                for (int x = 0; x < balls.Count; x++)
                {
                    balls[x].XSpeed = XSpeedTrackBar.Value;
                }
            }
            else
            {
                balls[balls.Count - 1].XSpeed = XSpeedTrackBar.Value;
            }
        }

        private void YSpeedTrackBar_Scroll(object sender, EventArgs e)
        {
            YSpeedLabel.Text = YSpeedTrackBar.Value.ToString();
            if (checkBox.Checked)
            {
                for (int x = 0; x < balls.Count; x++)
                {
                    balls[x].YSpeed = YSpeedTrackBar.Value;
                }
            }
            else
            {
                balls[balls.Count - 1].YSpeed = YSpeedTrackBar.Value;
            }
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
            if (canvas.GetLastMouseRightClick(out Point po))
            {
                balls.Clear();
            }
            
            for(int x = 0; x < balls.Count; x++)
            {
                balls[x].MoveBall(canvas);
            }
            for (int x = 0; x < balls.Count; x++)
            {
                balls[x].ShowBall(canvas);
            }
            canvas.Render();
        }
    }
}
