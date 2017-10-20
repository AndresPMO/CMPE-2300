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

namespace ICA08_AndresMOuellette
{
    public partial class Form1 : Form
    {
        List<Ball> lGreenBalls = new List<Ball>();
        List<Ball> lBlueBalls = new List<Ball>();
        List<Ball> lRedBalls = new List<Ball>();

        public CDrawer outCanvas = null;
        public CDrawer inCanvas = null;
        public Form1()
        {
            InitializeComponent();
            inCanvas = new CDrawer(600, 300, true, false);
            outCanvas = new CDrawer(600, 300, true, false);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Point clickPoint;
            if (inCanvas.GetLastMouseLeftClickScaled(out clickPoint))
            {
                Ball tempBall = new Ball(clickPoint, Color.Green);
                if (!(lGreenBalls.Contains(tempBall)))
                {
                    lGreenBalls.Add(tempBall);
                }
            }
            else if (inCanvas.GetLastMouseRightClickScaled(out clickPoint))
            {
                Ball tempBall = new Ball(clickPoint, Color.Blue);
                if (lBlueBalls.IndexOf(tempBall) <= 0)
                {
                    lBlueBalls.Insert(0, tempBall);
                }
            }

            foreach(Ball ball in lGreenBalls)
            {
                ball.Move(inCanvas);
                
            }
            foreach (Ball ball in lBlueBalls)
            {
                ball.Move(inCanvas);
            }
            foreach (Ball ball in lRedBalls)
            {
                ball.Move(outCanvas);
            }

            List<Ball> collisions = lGreenBalls.Intersect(lBlueBalls).ToList();
            foreach(Ball ball in collisions)
            {
                lGreenBalls.Remove(ball);
                lBlueBalls.Remove(ball);
                ball._colour = Color.Red;
            }

            lRedBalls = new List<Ball>(lRedBalls.Union(collisions));
            inCanvas.Clear();
            outCanvas.Clear();
            inCanvas.AddText($"Blue: {lBlueBalls.Count()} Green: {lGreenBalls.Count()}", 50, Color.DarkSeaGreen);
            outCanvas.AddText($"{lRedBalls.Count()}", 50, Color.DarkRed);

            for(int i = 0; i < lGreenBalls.Count(); i++)
            {
                lGreenBalls[i].Show(inCanvas, i);
            }
            for (int i = 0; i < lBlueBalls.Count(); i++)
            {
                lBlueBalls[i].Show(inCanvas, i);
            }
            for (int i = 0; i < lRedBalls.Count(); i++)
            {
                lRedBalls[i].Show(outCanvas, i);
            }

            inCanvas.Render();
            outCanvas.Render();
        }
    }
}
