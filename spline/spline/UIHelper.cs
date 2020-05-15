using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;
using System.Drawing;

namespace spline
{
    class CurZoom
    {
        public double xMin;
        public double yMin;
        public double xMax;
        public double yMax;
    }
    partial class Form1
    {
        Dictionary<string, CurZoom> curZoom;

        PointF oldPointGraph;
        bool userWrite;
        string perspective;
        bool withF = true;
        bool withS = true;
        bool withE = true;
        bool withLines = false;
        private void moveScales(PointF oldPoint, PointF newPoint)
        {
            var pane = zedGraphControlMain.GraphPane;

            var changeX = newPoint.X - oldPoint.X;
            var changeY = newPoint.Y - oldPoint.Y;

            var newXMin = pane.XAxis.Min - changeX * 0.5;
            var newXMax = pane.XAxis.Max - changeX * 0.5;
            var newYMin = pane.YAxis.Min - changeY * 0.5;
            var newYMax = pane.YAxis.Max - changeY * 0.5;

            var rX = curZoom[perspective].xMax - curZoom[perspective].xMin;
            var rY = curZoom[perspective].yMax - curZoom[perspective].yMin;

            if (curZoom[perspective].xMin - rX * 0.1 < newXMin && curZoom[perspective].xMax + rX * 0.1 > newXMax)
            {
                pane.XAxis.Min = newXMin;
                pane.XAxis.Max = newXMax;
            }

            if (curZoom[perspective].yMin - rY * 0.1 < newYMin && curZoom[perspective].yMax + rY * 0.1 > newYMax)
            {
                pane.YAxis.Min = newYMin;
                pane.YAxis.Max = newYMax;
            }
        }

        private void zoomScales(int delta, PointF curPoint)
        {
            var pane = zedGraphControlMain.GraphPane;
            delta = delta > 1000 ? 1000 : delta;

            var rX = (pane.XAxis.Max - pane.XAxis.Min);
            var rY = (pane.YAxis.Max - pane.YAxis.Min);

            var newXMin = pane.XAxis.Min + (curPoint.X - pane.XAxis.Min) * (delta * 0.001) / rX;
            var newXMax = pane.XAxis.Max - (pane.XAxis.Max - curPoint.X) * (delta * 0.001) / rX;
            var newYMin = pane.YAxis.Min + (curPoint.Y - pane.YAxis.Min) * (delta * 0.001) / rY;
            var newYMax = pane.YAxis.Max - (pane.YAxis.Max - curPoint.Y) * (delta * 0.001) / rY;

            if (newXMax - newXMin > (curZoom[perspective].xMax - curZoom[perspective].xMin) * 0.0001 && newYMax - newYMin > (curZoom[perspective].yMax - curZoom[perspective].yMin) * 0.0001)
            {
                if (delta > 0 || delta < 0 && curZoom[perspective].xMin - rX * 0.1 < newXMin) pane.XAxis.Min = newXMin;
                if (delta > 0 || delta < 0 && curZoom[perspective].xMax + rX * 0.1 > newXMax) pane.XAxis.Max = newXMax;

                if (delta > 0 || delta < 0 && curZoom[perspective].yMin - rY * 0.1 < newYMin) pane.YAxis.Min = newYMin;
                if (delta > 0 || delta < 0 && curZoom[perspective].yMax + rY * 0.1 > newYMax) pane.YAxis.Max = newYMax;
            }
            else if (delta < 0)
            {
                pane.XAxis.Min = newXMin;
                pane.XAxis.Max = newXMax;

                pane.YAxis.Min = newYMin;
                pane.YAxis.Max = newYMax;
            }

            zedGraphControlMain.AxisChange();
        }

        void refreshParam(string name)
        {
            //if (name == "textBoxFragCount" && userWrite)
            //{
            //    userWrite = false;
            //    int test;
            //    if (int.TryParse(textBoxFragCount.Text, out test))
            //    {
            //        spline.webCount = int.Parse(textBoxFragCount.Text);
            //        textBoxErrorSpline.Text = spline.getError().ToString();
            //    }
            //}
            //if (name == "textBoxErrorSpline" && userWrite)
            //{
            //    userWrite = false;
            //    double test;
            //    if (double.TryParse(textBoxErrorSpline.Text, out test)) textBoxFragCount.Text = spline.getFrag().ToString();
            //}
        }

        void draw()
        {
            // график функции. график сплайна. график погрешности.
            var pane = zedGraphControlMain.GraphPane;
            pane.CurveList.Clear();
            LineItem curve;
            CurZoom cz = new CurZoom() { xMin = double.NaN, xMax = double.NaN, yMin = double.NaN, yMax = double.NaN };
            if (perspective == "Function")
            {
                if (withF)
                {
                    curve = pane.AddCurve("function", spline.f.list, new Style().colors["purple.argon"], ZedGraph.SymbolType.None);
                    curve.Line.Width = 4.0f;
                    if (double.IsNaN(cz.xMin)) cz.xMin = spline.f.xMin;
                    if (double.IsNaN(cz.xMax)) cz.xMax = spline.f.xMax;
                    if (double.IsNaN(cz.yMin)) cz.yMin = spline.f.yMin;
                    if (double.IsNaN(cz.yMax)) cz.yMax = spline.f.yMax;
                }
                if (withS)
                {
                    curve = pane.AddCurve("spline", spline.s.list, new Style().colors["green.argon"], ZedGraph.SymbolType.None);
                    curve.Line.Width = 4.0f;
                    if (double.IsNaN(cz.xMin)) cz.xMin = spline.s.xMin;
                    else if (cz.xMin > spline.s.xMin) cz.xMin = spline.s.xMin;
                    if (double.IsNaN(cz.xMax)) cz.xMax = spline.s.xMax;
                    else if (cz.xMax < spline.s.xMax) cz.xMax = spline.s.xMax;
                    if (double.IsNaN(cz.yMin)) cz.yMin = spline.s.yMin;
                    else if (cz.yMin > spline.s.yMin) cz.yMin = spline.s.yMin;
                    if (double.IsNaN(cz.yMax)) cz.yMax = spline.s.yMax;
                    else if (cz.yMax < spline.s.yMax) cz.yMax = spline.s.yMax;
                }
                if (withE)
                {
                    curve = pane.AddCurve("error", spline.e.list, new Style().colors["pink.argon"], ZedGraph.SymbolType.None);
                    curve.Line.Width = 4.0f;
                    if (double.IsNaN(cz.xMin)) cz.xMin = spline.e.xMin;
                    else if (cz.xMin > spline.e.xMin) cz.xMin = spline.e.xMin;
                    if (double.IsNaN(cz.xMax)) cz.xMax = spline.e.xMax;
                    else if (cz.xMax < spline.e.xMax) cz.xMax = spline.e.xMax;
                    if (double.IsNaN(cz.yMin)) cz.yMin = spline.e.yMin;
                    else if (cz.yMin > spline.e.yMin) cz.yMin = spline.e.yMin;
                    if (double.IsNaN(cz.yMax)) cz.yMax = spline.e.yMax;
                    else if (cz.yMax < spline.e.yMax) cz.yMax = spline.e.yMax;
                }
            }
            if (perspective == "First derivative")
            {
                if (withF)
                {
                    curve = pane.AddCurve("1st derivative", spline.f1.list, new Style().colors["purple.argon"], ZedGraph.SymbolType.None);
                    curve.Line.Width = 4.0f;
                    if (double.IsNaN(cz.xMin)) cz.xMin = spline.f1.xMin;
                    if (double.IsNaN(cz.xMax)) cz.xMax = spline.f1.xMax;
                    if (double.IsNaN(cz.yMin)) cz.yMin = spline.f1.yMin;
                    if (double.IsNaN(cz.yMax)) cz.yMax = spline.f1.yMax;
                }
                if (withS)
                {
                    curve = pane.AddCurve("1st derivative of spline", spline.s1.list, new Style().colors["green.argon"], ZedGraph.SymbolType.None);
                    curve.Line.Width = 4.0f;
                    if (double.IsNaN(cz.xMin)) cz.xMin = spline.s1.xMin;
                    else if (cz.xMin > spline.s1.xMin) cz.xMin = spline.s1.xMin;
                    if (double.IsNaN(cz.xMax)) cz.xMax = spline.s1.xMax;
                    else if (cz.xMax < spline.s1.xMax) cz.xMax = spline.s1.xMax;
                    if (double.IsNaN(cz.yMin)) cz.yMin = spline.s1.yMin;
                    else if (cz.yMin > spline.s1.yMin) cz.yMin = spline.s1.yMin;
                    if (double.IsNaN(cz.yMax)) cz.yMax = spline.s1.yMax;
                    else if (cz.yMax < spline.s1.yMax) cz.yMax = spline.s1.yMax;
                }
                if (withE)
                {
                    curve = pane.AddCurve("error", spline.e1.list, new Style().colors["pink.argon"], ZedGraph.SymbolType.None);
                    curve.Line.Width = 4.0f;
                    if (double.IsNaN(cz.xMin)) cz.xMin = spline.e1.xMin;
                    else if (cz.xMin > spline.e1.xMin) cz.xMin = spline.e1.xMin;
                    if (double.IsNaN(cz.xMax)) cz.xMax = spline.e1.xMax;
                    else if (cz.xMax < spline.e1.xMax) cz.xMax = spline.e1.xMax;
                    if (double.IsNaN(cz.yMin)) cz.yMin = spline.e1.yMin;
                    else if (cz.yMin > spline.e1.yMin) cz.yMin = spline.e1.yMin;
                    if (double.IsNaN(cz.yMax)) cz.yMax = spline.e1.yMax;
                    else if (cz.yMax < spline.e1.yMax) cz.yMax = spline.e1.yMax;
                }
            }
            if (perspective == "Second derivative")
            {
                if (withF)
                {
                    curve = pane.AddCurve("2nd derivative", spline.f2.list, new Style().colors["purple.argon"], ZedGraph.SymbolType.None);
                    curve.Line.Width = 4.0f;
                    if (double.IsNaN(cz.xMin)) cz.xMin = spline.f2.xMin;
                    if (double.IsNaN(cz.xMax)) cz.xMax = spline.f2.xMax;
                    if (double.IsNaN(cz.yMin)) cz.yMin = spline.f2.yMin;
                    if (double.IsNaN(cz.yMax)) cz.yMax = spline.f2.yMax;
                }
                if (withS)
                {
                    curve = pane.AddCurve("2nd derivative of spline", spline.s2.list, new Style().colors["green.argon"], ZedGraph.SymbolType.None);
                    curve.Line.Width = 4.0f;
                    if (double.IsNaN(cz.xMin)) cz.xMin = spline.s2.xMin;
                    else if (cz.xMin > spline.s2.xMin) cz.xMin = spline.s2.xMin;
                    if (double.IsNaN(cz.xMax)) cz.xMax = spline.s2.xMax;
                    else if (cz.xMax < spline.s2.xMax) cz.xMax = spline.s2.xMax;
                    if (double.IsNaN(cz.yMin)) cz.yMin = spline.s2.yMin;
                    else if (cz.yMin > spline.s2.yMin) cz.yMin = spline.s2.yMin;
                    if (double.IsNaN(cz.yMax)) cz.yMax = spline.s2.yMax;
                    else if (cz.yMax < spline.s2.yMax) cz.yMax = spline.s2.yMax;
                }
                if (withE)
                {
                    curve = pane.AddCurve("error", spline.e2.list, new Style().colors["pink.argon"], ZedGraph.SymbolType.None);
                    curve.Line.Width = 4.0f;
                    if (double.IsNaN(cz.xMin)) cz.xMin = spline.e2.xMin;
                    else if (cz.xMin > spline.e2.xMin) cz.xMin = spline.e2.xMin;
                    if (double.IsNaN(cz.xMax)) cz.xMax = spline.e2.xMax;
                    else if (cz.xMax < spline.e2.xMax) cz.xMax = spline.e2.xMax;
                    if (double.IsNaN(cz.yMin)) cz.yMin = spline.e2.yMin;
                    else if (cz.yMin > spline.e2.yMin) cz.yMin = spline.e2.yMin;
                    if (double.IsNaN(cz.yMax)) cz.yMax = spline.e2.yMax;
                    else if (cz.yMax < spline.e2.yMax) cz.yMax = spline.e2.yMax;
                }
            }

            if (withLines)
            {
                foreach (var x in spline.webX)
                {
                    var line = new PointPairList();
                    line.Add(new PointPair(x, 2 * curZoom[perspective].yMin - curZoom[perspective].yMax));
                    line.Add(new PointPair(x, 2 * curZoom[perspective].yMax - curZoom[perspective].yMin));
                    curve = pane.AddCurve("", line, style.colors["white.argon"], ZedGraph.SymbolType.None);
                    curve.Line.Width = 0.1f;
                }
            }

            if (!double.IsNaN(cz.xMin)) pane.XAxis.Min = cz.xMin;
            if (!double.IsNaN(cz.xMax)) pane.XAxis.Max = cz.xMax;
            if (!double.IsNaN(cz.yMin)) pane.YAxis.Min = cz.yMin;
            if (!double.IsNaN(cz.yMax)) pane.YAxis.Max = cz.yMax;

            zedGraphControlMain.AxisChange();
            zedGraphControlMain.Invalidate();
        }

        void fillInfo()
        {
            textBoxSplineGrid.Text = (spline.webCount - 1).ToString();
            textBoxMainGrid.Text = ((spline.webCount - 1) * 100).ToString();

            SplineGraph sg = spline.lsgLast[0];
            SplineGraph sg1 = spline.lsgLast[0];
            SplineGraph sg2 = spline.lsgLast[0];
            foreach(var s in spline.lsgLast)
            {
                if (s.error.maxErrorF > sg.error.maxErrorF) sg = s;
                if (s.error.maxErrorF1 > sg1.error.maxErrorF1) sg1 = s;
                if (s.error.maxErrorF2 > sg2.error.maxErrorF2) sg2 = s;
            }

            textBoxMaxErrorFunc.Text = sg.error.maxErrorF.ToString();
            textBoxMaxErrorFuncX.Text = sg.error.xmef.ToString();
            textBoxMaxError1d.Text = sg1.error.maxErrorF1.ToString();
            textBoxMaxError1dX.Text = sg1.error.xmef1.ToString();
            textBoxMaxError2d.Text = sg2.error.maxErrorF2.ToString();
            textBoxMaxError2dX.Text = sg2.error.xmef2.ToString();

        }

        void fillParamTable()
        {
            dataGridViewParam.Rows.Clear();
            var i = 1;
            foreach (var s in spline.lsgLast)
            {
                dataGridViewParam.Rows.Add(i++, s.interval.left, s.interval.right, s.param.a, s.param.b, s.param.c, s.param.d);
            }
        }

        void fillErrorTable()
        {
            dataGridViewErrorSpline.Rows.Clear();
            var i = 0;
            var curX = spline.lsgLast[0].interval.left;

            dataGridViewErrorSpline.Rows.Add(i++, curX,
                spline.curFunc(curX), spline.lsgLast[0].f(curX), spline.curFunc(curX) - spline.lsgLast[0].f(curX),
                spline.curFunc1(curX), spline.lsgLast[0].f1(curX), spline.curFunc1(curX) - spline.lsgLast[0].f1(curX),
                spline.curFunc2(curX), spline.lsgLast[0].f2(curX), spline.curFunc2(curX) - spline.lsgLast[0].f2(curX));
            foreach (var s in spline.lsgLast)
            {
                curX = s.interval.right;
                dataGridViewErrorSpline.Rows.Add(i++, curX,
                spline.curFunc(curX), s.f(curX), spline.curFunc(curX) - s.f(curX),
                spline.curFunc1(curX), s.f1(curX), spline.curFunc1(curX) - s.f1(curX),
                spline.curFunc2(curX), s.f2(curX), spline.curFunc2(curX) - s.f2(curX));
            }
        }

        public Color invert(Color c)
        {
            return Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B);
        }
    }
}
