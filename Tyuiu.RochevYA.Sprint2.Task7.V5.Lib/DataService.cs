using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.RochevYA.Sprint2.Task7.V5.Lib
{
    public class DataService : ISprint2Task7V5
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            return (y<=Math.Pow(Math.E,x))&&(y<=Math.Pow(Math.E, -x))&&(y>=Math.Pow(x,2));
        }
    }
}
