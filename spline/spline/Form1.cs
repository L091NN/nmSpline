using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace spline
{
    public partial class Form1 : Form
    {
        Style style;
        Spline spline;
        bool pressed;
        public Form1()
        {
            InitializeComponent();
            style = new Style();
            spline = new Spline();
            pressed = false;
            curZoom = new Dictionary<string, CurZoom>();
            curZoom.Add("Function", new CurZoom());
            curZoom.Add("First derivative", new CurZoom());
            curZoom.Add("Second derivative", new CurZoom());
            //perspective = "Function";
            fillZedGraph();
        }

        void fillZedGraph()
        {
            var pane = zedGraphControlMain.GraphPane;
            pane.FontSpec.FontColor = style.colors["white.argon"];

            pane.PaneBorder.Color = style.colors["black.argon"];

            pane.AxisBorder.Color = style.colors["white.argon"];

            pane.PaneFill.Type = FillType.Solid;
            pane.PaneFill.Color = style.colors["black.argon"];

            pane.AxisFill.Type = FillType.Solid;
            pane.AxisFill.Color = style.colors["black.argon"];

            pane.XAxis.IsZeroLine = true;
            pane.YAxis.IsZeroLine = true;
            pane.XAxis.Color = style.colors["white.argon"];
            pane.YAxis.Color = style.colors["white.argon"];

            pane.XAxis.IsShowGrid = true;
            pane.YAxis.IsShowGrid = true;
            pane.XAxis.GridColor = style.colors["white.argon"];
            pane.YAxis.GridColor = style.colors["white.argon"];

            pane.XAxis.ScaleFontSpec.FontColor = style.colors["white.argon"];
            pane.YAxis.ScaleFontSpec.FontColor = style.colors["white.argon"];

            pane.XAxis.TitleFontSpec.FontColor = style.colors["white.argon"];
            pane.YAxis.TitleFontSpec.FontColor = style.colors["white.argon"];

            pane.XAxis.IsShowGrid = false;
            pane.YAxis.IsShowGrid = false;

            pane.Title = "";
            pane.XAxis.Title = "x";
            pane.YAxis.Title = "F(x)";
        }

        private void buttonMenuHide_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = panelMenu.Visible ? false : true;
            if (panelMenu.Visible) buttonMenuHide.Text = "◀";
            else buttonMenuHide.Text = "▶";
        }

        private void zedGraphControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pressed)
            {
                var pane = zedGraphControlMain.GraphPane;

                Point eventPoint = new Point(e.X, e.Y);

                double graphX, graphY, Y;
                pane.ReverseTransform(new PointF(e.X, e.Y), out graphX, out graphY, out Y);

                var newPoint = new PointF((float)graphX, (float)graphY);

                PointF controlPoint = pane.GeneralTransform(newPoint,
                ZedGraph.CoordType.AxisXYScale);

                moveScales(oldPointGraph, newPoint);
                zedGraphControlMain.Refresh();
                oldPointGraph = newPoint;
            }
        }

        private void zedGraphControl1_MouseDown(object sender, MouseEventArgs e)
        {
            var pane = zedGraphControlMain.GraphPane;

            Point eventPoint = new Point(e.X, e.Y);

            double graphX, graphY, Y;
            pane.ReverseTransform(new PointF(e.X, e.Y), out graphX, out graphY, out Y);

            PointF controlPoint = pane.GeneralTransform(new PointF((float)graphX,
            (float)graphY),
            ZedGraph.CoordType.AxisXYScale);

            oldPointGraph = new PointF((float)graphX, (float)graphY);

            pressed = true;
        }

        private void zedGraphControl1_MouseUp(object sender, MouseEventArgs e)
        {
            var pane = zedGraphControlMain.GraphPane;

            Point eventPoint = new Point(e.X, e.Y);

            double graphX, graphY, Y;
            pane.ReverseTransform(new PointF(e.X, e.Y), out graphX, out graphY, out Y);

            PointF controlPoint = pane.GeneralTransform(new PointF((float)graphX,
            (float)graphY),
            ZedGraph.CoordType.AxisXYScale);

            pressed = false;
        }

        private void zedGraphControlMain_MouseWheel(object sender, MouseEventArgs e)
        {
            double graphX, graphY, Y;
            zedGraphControlMain.GraphPane.ReverseTransform(new PointF(e.X, e.Y), out graphX, out graphY, out Y);
            zoomScales(e.Delta, new PointF((float)graphX, (float)graphY));
            zedGraphControlMain.Refresh();
        }

        private void buttonTestTask_Click(object sender, EventArgs e)
        {
            if (!runSpline.IsBusy && !statusAnimation.IsBusy)
            {
                panelGraphParam.Visible = false;
                buttonLines.Visible = false;
                spline = new Spline(-1, 1, int.Parse(textBoxFragCount.Text), "t");
                statusAnimation.RunWorkerAsync(new List<Color> { style.colors["purple.argon"], style.colors["pink.argon"], style.colors["green.argon"], style.colors["purple.argon"] });
                runSpline.RunWorkerAsync(spline);

                buttonMainTask.BackColor = style.colors["purple.argon"];
                buttonMainTask.ForeColor = style.colors["white.argon"];

                buttonOscTask.BackColor = style.colors["purple.argon"];
                buttonOscTask.ForeColor = style.colors["white.argon"];

                buttonTestTask.BackColor = style.colors["green.argon"];
                buttonTestTask.ForeColor = style.colors["black.argon"];
            }
        }

        private void buttonMainTask_Click(object sender, EventArgs e)
        {
            if (!runSpline.IsBusy && !statusAnimation.IsBusy)
            {
                panelGraphParam.Visible = false;
                buttonLines.Visible = false;
                spline = new Spline(0, 1, int.Parse(textBoxFragCount.Text),"m");
                statusAnimation.RunWorkerAsync(new List<Color> { style.colors["purple.argon"], style.colors["pink.argon"], style.colors["green.argon"], style.colors["purple.argon"] });
                runSpline.RunWorkerAsync(spline);

                buttonTestTask.BackColor = style.colors["purple.argon"];
                buttonTestTask.ForeColor = style.colors["white.argon"];

                buttonOscTask.BackColor = style.colors["purple.argon"];
                buttonOscTask.ForeColor = style.colors["white.argon"];

                buttonMainTask.BackColor = style.colors["green.argon"];
                buttonMainTask.ForeColor = style.colors["black.argon"];
            }
        }

        private void buttonOscTask_Click(object sender, EventArgs e)
        {
            if (!runSpline.IsBusy && !statusAnimation.IsBusy)
            {
                panelGraphParam.Visible = false;
                buttonLines.Visible = false;
                spline = new Spline(0, 1, int.Parse(textBoxFragCount.Text), "o");
                statusAnimation.RunWorkerAsync(new List<Color> { style.colors["purple.argon"], style.colors["pink.argon"], style.colors["green.argon"], style.colors["purple.argon"] });
                runSpline.RunWorkerAsync(spline);

                buttonTestTask.BackColor = style.colors["purple.argon"];
                buttonTestTask.ForeColor = style.colors["white.argon"];

                buttonMainTask.BackColor = style.colors["purple.argon"];
                buttonMainTask.ForeColor = style.colors["white.argon"];

                buttonOscTask.BackColor = style.colors["green.argon"];
                buttonOscTask.ForeColor = style.colors["black.argon"];
            }
        }

        private void textBoxTextChanged(object sender, EventArgs e)
        {
            var testBox = (TextBox)sender;
            refreshParam(testBox.Name);
        }

        private void textBox_Move(object sender, MouseEventArgs e)
        {
            userWrite = true;
        }

        private void buttonFunc_Click(object sender, EventArgs e)
        {
            if (perspective != "Function")
            {
                button1d.BackColor = style.colors["purple.argon"];
                button1d.ForeColor = style.colors["white.argon"];

                button2d.BackColor = style.colors["purple.argon"];
                button2d.ForeColor = style.colors["white.argon"];

                perspective = "Function";
                buttonFunc.BackColor = style.colors["green.argon"];
                buttonFunc.ForeColor = style.colors["black.argon"];
                draw();
            }
        }

        private void button1d_Click(object sender, EventArgs e)
        {
            if (perspective != "First derivative")
            {

                buttonFunc.BackColor = style.colors["purple.argon"];
                buttonFunc.ForeColor = style.colors["white.argon"];

                button2d.BackColor = style.colors["purple.argon"];
                button2d.ForeColor = style.colors["white.argon"];

                perspective = "First derivative";
                button1d.BackColor = style.colors["green.argon"];
                button1d.ForeColor = style.colors["black.argon"];
                draw();
            }

        }

        private void button2d_Click(object sender, EventArgs e)
        {
            if (perspective != "Second derivative")
            {

                buttonFunc.BackColor = style.colors["purple.argon"];
                buttonFunc.ForeColor = style.colors["white.argon"];

                button1d.BackColor = style.colors["purple.argon"];
                button1d.ForeColor = style.colors["white.argon"];

                perspective = "Second derivative";
                button2d.BackColor = style.colors["green.argon"];
                button2d.ForeColor = style.colors["black.argon"];
                draw();
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            if (panelInfo.Visible)
            {
                panelInfo.Visible = false;
                buttonInfo.Text = "▼ INFO ▼";
            }
            else
            {
                panelInfo.Visible = true;
                buttonInfo.Text = "▲ INFO ▲";
            }
        }

        private void buttonVisibleFunction_Click(object sender, EventArgs e)
        {
            withF = !withF;
            buttonVisibleFunction.BackColor = invert(buttonVisibleFunction.BackColor);
            buttonVisibleFunction.ForeColor = invert(buttonVisibleFunction.ForeColor);
            draw();
        }

        private void buttonVisibleSpline_Click(object sender, EventArgs e)
        {
            withS = !withS;
            buttonVisibleSpline.BackColor = invert(buttonVisibleSpline.BackColor);
            buttonVisibleSpline.ForeColor = invert(buttonVisibleSpline.ForeColor);
            draw();
        }

        private void buttonVisibleError_Click(object sender, EventArgs e)
        {
            withE = !withE;
            buttonVisibleError.BackColor = invert(buttonVisibleError.BackColor);
            buttonVisibleError.ForeColor = invert(buttonVisibleError.ForeColor);
            draw();
        }

        private void buttonTable_Click(object sender, EventArgs e)
        {
            if (panelTable.Visible)
            {
                panelTable.Visible = false;
                buttonTable.Text = "▼ TABLE ▼";
            }
            else
            {
                panelTable.Visible = true;
                buttonTable.Text = "▲ TABLE ▲";
            }
        }

        private void buttonLines_Click(object sender, EventArgs e)
        {
            withLines = !withLines;
            buttonLines.BackColor = invert(buttonLines.BackColor);
            buttonLines.ForeColor = invert(buttonLines.ForeColor);

            draw();
        }

        private void buttonChangeTable_Click(object sender, EventArgs e)
        {
            if (buttonChangeTable.Text == "Parameters of spline")
            {
                dataGridViewParam.Visible = false;
                buttonChangeTable.Text = "Error of spline";
                dataGridViewErrorSpline.Visible = true;
            }
            else if (buttonChangeTable.Text == "Error of spline")
            {
                dataGridViewErrorSpline.Visible = false;
                buttonChangeTable.Text = "Parameters of spline";
                dataGridViewParam.Visible = true;
            }
        }
    }
}
