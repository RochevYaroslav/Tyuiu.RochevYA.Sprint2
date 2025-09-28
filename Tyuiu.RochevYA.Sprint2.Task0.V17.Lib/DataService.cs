using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.RochevYA.Sprint2.Task0.V17.Lib
{
    public class DataService : ISprint2Task0V17
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] result = new bool[6];

            result[0] = (x - 310) == (y);
            result[1] = x-310 != y;
            result[2] = (x - 310) < y;
            result[3] = (y + 310) > x;
            result[4] = (x - 310) <= (y - 1);
            result[5] = (y + 309) >= x;

            return result;
        }
    }
}
