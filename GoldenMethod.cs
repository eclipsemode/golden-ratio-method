using System;

namespace Golden_ratio_method
{
    public class GoldenMethod
    {
        public double ApproxError { get; private set; }
        public double Optimal { get; private set; }
        public double Steps { get; private set; } = 0;
        
        private double _goldenRatio = (Math.Sqrt(5.0) - 1) / 2;
        public void Search(Func<double, double> func, double a, double b, double eps)
        {
            double ea = 100; int i = 1;
            double D = _goldenRatio * (b - a);
            double x1 = a + D;
            double x2 = b - D;
            double f1 = func(x1);
            double f2 = func(x2);
            double xopt = 0;
            
            while (ea > eps)
            {
                if (f1 < f2)
                {
                    a = x2;
                    x2 = x1;
                    f2 = f1;
                    x1 = a + _goldenRatio * (b - a);
                    f1 = func(x1);
                }
                else
                {
                    b = x1;
                    x1 = x2;
                    f1 = f2;
                    x2 = b - _goldenRatio * (b - a);
                    f2 = func(x2);
                }
                
                if (f1 < f2)
                    xopt = x1;
                else
                    xopt = x2;
        
                ea = (1 - _goldenRatio) * Math.Abs((b - a) / xopt) * 100;
                i++;
            }
            Steps = i - 1;
            ApproxError = ea;
            Optimal = xopt;
        }
    }
}