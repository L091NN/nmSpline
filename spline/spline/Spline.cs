using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ZedGraph;

namespace spline
{
    class Params 
    {
        public double a;
        public double b;
        public double c;
        public double d;
    }

    class Interval
    {
        public double left;
        public double right;
    }

    class Error
    {
        public double maxErrorF;
        public double maxErrorF1;
        public double maxErrorF2;
        public double xmef;
        public double xmef1;
        public double xmef2;
    }

    class FuncInfo
    {
        public PointPairList list = null;
        public double xMin;
        public double xMax;
        public double yMin;
        public double yMax;
    }

    class SplineGraph
    {
        public Interval interval;
        public Params param;
        public Error error;
        public Func<double, double> f;
        public Func<double, double> f1;
        public Func<double, double> f2;


        public SplineGraph()
        {
            interval = new Interval();
            param = new Params();
            error = new Error() { maxErrorF = double.MinValue, maxErrorF1 = double.MinValue, maxErrorF2 = double.MinValue };
        }
    }
    class Spline
    {
        Params param = null;
        public double eps { get; set; }
        public double xLeft;
        public double xRight;
        public List<double> webX = null;
        public Func<double, double> testFunc = x => x > 0 ? -(x * x * x) + 3 * x * x : (x * x * x) + 3 * x * x;
        public Func<double, double> testFunc1 = x => x > 0 ? -3 * (x * x) + 6 * x : 3 * (x * x) + 6 * x;
        public Func<double, double> testFunc2 = x => x > 0 ? -6 * x + 6 : 6 * x + 6;

        public Func<double, double> mainFunc = x => Math.Sin(x) / (1 + x * x);
        public Func<double, double> mainFunc1 = x => -2 * x * Math.Sin(x) / ((1 + x * x) * (1 + x * x))
            + Math.Cos(x) / (1 + x * x);
        public Func<double, double> mainFunc2 = x => 8 * x * x * Math.Sin(x) / ((1 + x * x) * (1 + x * x) * (1 + x * x))
            -4 * x * Math.Cos(x) / ((1 + x * x) * (1 + x * x))
            -2 * Math.Sin(x) / ((1 + x * x) * (1 + x * x))
            -Math.Sin(x) / (1 + x * x);

        public Func<double, double> oscFunc = x => Math.Sin(x) / (1 + x * x) + Math.Cos(10 * x);
        public Func<double, double> oscFunc1 = x => -2 * x * Math.Sin(x) / ((1 + x * x) * (1 + x * x))
            + Math.Cos(x) / (1 + x * x) - 10 * Math.Sin(10 * x);
        public Func<double, double> oscFunc2 = x => 8 * x * x * Math.Sin(x) / ((1 + x * x) * (1 + x * x) * (1 + x * x))
            - 4 * x * Math.Cos(x) / ((1 + x * x) * (1 + x * x))
            - 2 * Math.Sin(x) / ((1 + x * x) * (1 + x * x))
            - Math.Sin(x) / (1 + x * x)
            - 100 * Math.Cos(10 * x);

        public Func<double, double> curFunc;
        public Func<double, double> curFunc1;
        public Func<double, double> curFunc2;

        public int webCount;
        public double webError;
        public double webStep;

        public string curFuncType; ///t = Test, m = Main, o = Osc

        public FuncInfo f;
        public FuncInfo s;
        public FuncInfo e;

        public FuncInfo f1;
        public FuncInfo s1;
        public FuncInfo e1;

        public FuncInfo f2;
        public FuncInfo s2;
        public FuncInfo e2;

        public List<SplineGraph> lsgLast;

        public Spline(double xLeft = 0.0, double xRight = 0.0, int webCount = 4, string perspective = "m")
        {
            this.xLeft = xLeft;
            this.xRight = xRight;
            this.webCount = webCount;
            curFuncType = perspective;

            f = new FuncInfo(){ yMin = double.MaxValue, yMax = double.MinValue};
            s = new FuncInfo(){ yMin = double.MaxValue, yMax = double.MinValue};
            e = new FuncInfo (){ yMin = double.MaxValue, yMax = double.MinValue};

            f1 = new FuncInfo(){ yMin = double.MaxValue, yMax = double.MinValue};
            s1 = new FuncInfo(){ yMin = double.MaxValue, yMax = double.MinValue};
            e1 = new FuncInfo(){ yMin = double.MaxValue, yMax = double.MinValue}; 

            f2 = new FuncInfo(){ yMin = double.MaxValue, yMax = double.MinValue};
            s2 = new FuncInfo(){ yMin = double.MaxValue, yMax = double.MinValue};
            e2 = new FuncInfo(){ yMin = double.MaxValue, yMax = double.MinValue};
        }

        public void runTask(ZedGraphControl zgControl, ref Dictionary<string, CurZoom> zoom, BackgroundWorker worker)
        {
            webX = new List<double>();

            webX.Add(xLeft);
            webStep = (xRight - xLeft) / (webCount - 1);
            for (var i = 1; i < webCount - 1; i++)
            {
                webX.Add(xLeft + i * webStep);
            }
            webX.Add(xRight);

            curFunc = curFuncType == "t" ? testFunc : curFuncType == "m" ? mainFunc : oscFunc;
            curFunc1 = curFuncType == "t" ? testFunc1 : curFuncType == "m" ? mainFunc1 : oscFunc1;
            curFunc2 = curFuncType == "t" ? testFunc2 : curFuncType == "m" ? mainFunc2 : oscFunc2;

            var sg = GetSpline(curFunc, worker);

            var h = 2.0 / webCount * 0.01;
            f.list = new PointPairList();
            s.list = new PointPairList();
            e.list = new PointPairList();

            f1.list = new PointPairList();
            s1.list = new PointPairList();
            e1.list = new PointPairList();

            f2.list = new PointPairList();
            s2.list = new PointPairList();
            e2.list = new PointPairList();

            var pane = zgControl.GraphPane;

            pane.XAxis.Min = zoom["Function"].xMin = zoom["First derivative"].xMin = zoom["Second derivative"].xMin 
                = f.xMin = s.xMin = e.xMin = f1.xMin = s1.xMin = e1.xMin = f2.xMin = s2.xMin = e2.xMin = xLeft;
            pane.XAxis.Max = zoom["Function"].xMax = zoom["First derivative"].xMax = zoom["Second derivative"].xMax 
                = f.xMax = s.xMax = e.xMax = f1.xMax = s1.xMax = e1.xMax = f2.xMax = s2.xMax = e2.xMax = xRight;

            var route = curFunc(xLeft) < curFunc(xRight);
            var route1 = curFunc1(xLeft) < curFunc1(xRight);
            var route2 = curFunc2(xLeft) < curFunc2(xRight);

            zoom["Function"].yMin = route ? curFunc(xLeft) : curFunc(xRight);
            zoom["Function"].yMax = route ? curFunc(xRight) : curFunc(xLeft);

            zoom["First derivative"].yMin = route1 ? curFunc1(xLeft) : curFunc1(xRight);
            zoom["First derivative"].yMax = route1 ? curFunc1(xRight) : curFunc1(xLeft);

            zoom["Second derivative"].yMin = route2 ? curFunc2(xLeft) : curFunc2(xRight);
            zoom["Second derivative"].yMax = route2 ? curFunc2(xRight) : curFunc2(xLeft);

            var r = xRight - xLeft;

            for (var i = xLeft; i < xRight + h; i += h)
            {
                if (i > xRight) i = xRight;


                worker.ReportProgress(50 + (int)((i - xLeft) / r * 50));

                var posS = 0;

                while (!(sg[posS].interval.right >= i && sg[posS].interval.left <= i)) posS++;

                var par = sg[posS].param;
                var curX = sg[posS].interval.right;

                if (sg[posS].f == null || sg[posS].f1 == null || sg[posS].f2 == null)
                {
                    sg[posS].f = x => par.a + par.b * (x - curX) + par.c * (x - curX) * (x - curX) + par.d * (x - curX) * (x - curX) * (x - curX);
                    sg[posS].f1 = x => par.b + 2 * par.c * (x - curX) + 3 * par.d * (x - curX) * (x - curX);
                    sg[posS].f2 = x => 2 * par.c + 6 * par.d * (x - curX);
                }

                var pos = f.list.Count;

                var curF = curFunc(i);
                f.list.Add(new PointPair(i, curF));
                if (curF < f.yMin) f.yMin = curF;
                else if (curF > f.yMax) f.yMax = curF;

                var curS = sg[posS].f(i);
                s.list.Add(new PointPair(i, curS));
                if (curS < s.yMin) s.yMin = curS;
                else if (curS > s.yMax) s.yMax = curS;

                var curE = Math.Abs(f.list[pos].Y - s.list[pos].Y);
                e.list.Add(new PointPair(i, curE));
                if (curE < e.yMin) e.yMin = curE;
                else if (curE > e.yMax) e.yMax = curE;
                if (curE > sg[posS].error.maxErrorF) { sg[posS].error.maxErrorF = curE; sg[posS].error.xmef = i; }

                curF = curFunc1(i);
                f1.list.Add(new PointPair(i, curF));
                if (curF < f1.yMin) f1.yMin = curF;
                else if (curF > f1.yMax) f1.yMax = curF;

                curS = sg[posS].f1(i);
                s1.list.Add(new PointPair(i, curS));
                if (curS < s1.yMin) s1.yMin = curS;
                else if (curS > s1.yMax) s1.yMax = curS;

                curE = Math.Abs(f1.list[pos].Y - s1.list[pos].Y);
                e1.list.Add(new PointPair(i, curE));
                if (curE < e1.yMin) e1.yMin = curE;
                else if (curE > e1.yMax) e1.yMax = curE;
                if (curE > sg[posS].error.maxErrorF1) { sg[posS].error.maxErrorF1 = curE; sg[posS].error.xmef1 = i; }

                curF = curFunc2(i);
                f2.list.Add(new PointPair(i, curF));
                if (curF < f2.yMin) f2.yMin = curF;
                else if (curF > f2.yMax) f2.yMax = curF;

                curS = sg[posS].f2(i);
                s2.list.Add(new PointPair(i, curS));
                if (curS < s2.yMin) s2.yMin = curS;
                else if (curS > s2.yMax) s2.yMax = curS;

                curE = Math.Abs(f2.list[pos].Y - s2.list[pos].Y);
                e2.list.Add(new PointPair(i, curE));
                if (curE < e2.yMin) e2.yMin = curE;
                else if (curE > e2.yMax) e2.yMax = curE;
                if (curE > sg[posS].error.maxErrorF2) { sg[posS].error.maxErrorF2 = curE; sg[posS].error.xmef2 = i; }


                pos = f.list.Count - 1;

                var list = new[] { f.list[pos].Y, s.list[pos].Y, e.list[pos].Y };
                if (zoom["Function"].yMin > list.Min()) zoom["Function"].yMin = list.Min();
                if (zoom["Function"].yMax < list.Max()) zoom["Function"].yMax = list.Max();

                list = new[] { f1.list[pos].Y, s1.list[pos].Y, e1.list[pos].Y };
                if (zoom["First derivative"].yMin > list.Min()) zoom["First derivative"].yMin = list.Min();
                if (zoom["First derivative"].yMax < list.Max()) zoom["First derivative"].yMax = list.Max();

                list = new[] { f2.list[pos].Y, s2.list[pos].Y, e2.list[pos].Y };
                if (zoom["Second derivative"].yMin > list.Min()) zoom["Second derivative"].yMin = list.Min();
                if (zoom["Second derivative"].yMax < list.Max()) zoom["Second derivative"].yMax = list.Max();
            }

            var rX = zoom["Function"].xMax - zoom["Function"].xMin;
            zoom["Function"].xMin = zoom["First derivative"].xMin = zoom["Second derivative"].xMin = zoom["Function"].xMin - rX * 0.1;
            zoom["Function"].xMax = zoom["First derivative"].xMax = zoom["Second derivative"].xMax = zoom["Function"].xMax + rX * 0.1;

            var rY = zoom["Function"].yMax - zoom["Function"].yMin;
            var rY1 = zoom["First derivative"].yMax - zoom["First derivative"].yMin;
            var rY2 = zoom["Second derivative"].yMax - zoom["Second derivative"].yMin;

            pane.YAxis.Min = zoom["Function"].yMin;
            pane.YAxis.Max = zoom["Function"].yMax;
           
            zoom["Function"].yMin -= rY * 0.1;
            zoom["Function"].yMax += rY * 0.1;

            zoom["First derivative"].yMin -= rY1 * 0.1;
            zoom["First derivative"].yMax += rY1 * 0.1;

            zoom["Second derivative"].yMin -= rY2 * 0.1;
            zoom["Second derivative"].yMax += rY2 * 0.1;

            lsgLast = sg;
        }

        List<SplineGraph> GetSpline(Func<double, double> func, BackgroundWorker worker)
        {
            List<SplineGraph> lsg = new List<SplineGraph>();
            List<double> delta = new List<double>();
            List<double> lambda = new List<double>();

            if (webCount > 2)
            {
                delta.Add(-0.25);
                var test1 = func(webX[2]) - 2 * func(webX[1]) + func(webX[0]);
                var test2 = test1 * 3;
                var test3 = test2 / (4 * webStep * webStep);
                lambda.Add((3 * (func(webX[2]) - 2 * func(webX[1]) + func(webX[0]))) / (4 * webStep * webStep));
            }

            for (var i = 1; i < webCount - 2; i++)
            {
                worker.ReportProgress((int)((double)i / (webCount - 2) * 15));
                delta.Add(-1 / (4 + delta[i - 1]));
                var test1 = func(webX[i + 2]) - 2 * func(webX[i + 1]) + func(webX[i]);
                var test2 = test1 * 3 / (webStep * webStep);
                var test3 = test2 - lambda[i - 1];
                var test4 = test3 / (4 + delta[i - 1]);
                lambda.Add((3 * (func(webX[i + 2]) - 2 * func(webX[i + 1]) + func(webX[i])) / (webStep * webStep) - lambda[i - 1]) / (4 + delta[i - 1]));
            }

            if (webCount > 2)
            {
                delta.Reverse();
                lambda.Reverse();
            }
                webX.Reverse();

            lsg.Add(new SplineGraph() { interval = new Interval() { left = webX[1], right = webX[0] }, param = new Params() { a = func(webX[0]), c = 0 } });
            for (var i = 0; i < webCount - 2; i++)
            {
                worker.ReportProgress(15 + (int)((double)i / (webCount - 2) * 15));
                var sg = new SplineGraph() { interval = new Interval(), param = new Params() };
                sg.interval.left = webX[i + 2];
                sg.interval.right = webX[i + 1];
                sg.param.c = delta[i] * lsg[i].param.c + lambda[i];
                lsg.Add(sg);
            }

            webX.Reverse();
            lsg.Reverse();

            for (var i = 0; i < webCount - 1; i++)
            {
                worker.ReportProgress(30 + (int)((double)i / (webCount - 1) * 20));
                lsg[i].param.a = func(lsg[i].interval.right);
                lsg[i].param.b = i == 0 ? (func(lsg[i].interval.right) - func(lsg[i].interval.left)) / webStep + webStep * (2 * lsg[i].param.c) / 3
                    : (func(lsg[i].interval.right) - func(lsg[i].interval.left)) / webStep + webStep * (2 * lsg[i].param.c + lsg[i - 1].param.c) / 3;
                lsg[i].param.d = i == 0 ? lsg[i].param.c / (3 * webStep) : (lsg[i].param.c - lsg[i - 1].param.c) / (3 * webStep);
            }

            return lsg;
        }
    }
}
