using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace spline
{
    partial class Form1
    {
        public int RGBtoInt(int r, int g, int b)
        {
            return 255 << 24 | (r << 16) | (g << 8) | (b << 0);
        }
        private void changeColor(List<Color> colors, BackgroundWorker worker, int sleep = 5)
        {
            var color = colors.GetEnumerator();
            color.MoveNext();
            var curColor = color.Current;
            for (; color.MoveNext();)
            {
                while (curColor != color.Current)
                {
                    int R, G, B;
                    if (curColor.R != color.Current.R)
                    {
                        if (curColor.R > color.Current.R) R = curColor.R - 1;
                        else R = curColor.R + 1;
                    }
                    else R = curColor.R;

                    if (curColor.G != color.Current.G)
                    {
                        if (curColor.G > color.Current.G) G = curColor.G - 1;
                        else G = curColor.G + 1;
                    }
                    else G = curColor.G;

                    if (curColor.B != color.Current.B)
                    {
                        if (curColor.B > color.Current.B) B = curColor.B - 1;
                        else B = curColor.B + 1;
                    }
                    else B = curColor.B;

                    curColor = Color.FromArgb(R, G, B);

                    worker.ReportProgress(RGBtoInt(R, G, B));

                    System.Threading.Thread.Sleep(sleep);

                }
            }
        }
        private void statusAnimation_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!statusAnimation.CancellationPending)
                changeColor((List<Color>)e.Argument, statusAnimation);
        }

        private void statusAnimation_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            panelCurStatus.BackColor = Color.FromArgb(e.ProgressPercentage);
        }

        private void statusAnimation_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
        }

        private void runSpline_DoWork(object sender, DoWorkEventArgs e)
        {
            var sp = (Spline)e.Argument;
            sp.runTask(zedGraphControlMain, ref curZoom, runSpline);
        }

        private void runSpline_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            panelCurStatus.Width = (int)(panelStatus.Width * e.ProgressPercentage * 0.01);
        }

        private void runSpline_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            panelCurStatus.Width = 0;
            statusAnimation.CancelAsync();
            perspective = "";
            buttonFunc_Click(buttonFunc, new EventArgs());
            panelGraphParam.Visible = true;
            buttonLines.Visible = true;
            fillInfo();
            fillParamTable();
            fillErrorTable();
        }
    }
}
