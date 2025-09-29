using System;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.RochevYA.Sprint2.Task3.V17.Lib
{
    public class DataService : ISprint2Task3V17
    {
        public double Calculate(double x)
        {
            if (x > 1)
            {
                double y =Math.Pow(x,2)+Math.Pow(((x+1)/(x-1)),8);
                return Math.Round(y, 3);
            } else if (x == 0)
            {
                double y =((2+x-3*x)/(x-7));
                return Math.Round(y, 3);
            } else if (-21 < x & x < 2)
            {
                double y = Math.Pow(1+(1/Math.Pow(x,2)),4);
                return Math.Round(y, 3);
            } else if (x < -21)
            {
                double y = x + 10*x - (1/x);
                return Math.Round(y, 3);
            } else
            {
                return 0;
            }
        }
    }
}
