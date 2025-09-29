using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.RochevYA.Sprint2.Task1.V24.Lib
{
    public class DataService : ISprint2Task1V24
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d) // 325 325 242 324
        {
            // ==, !=, <, >, <=, >=
            // |, &, ||, &&, !, ^
            bool[] result = new bool[6]; //(True, False, True, False, True, False)

            result[0] = (a == b) | (c + 82 == d);
            result[1] = (a != b + 1) & (c > d);
            result[2] = (c < d) || (a == b);
            result[3] = (d > a) && (c != 242);
            result[4] = (a <= b) ^ (c >= d + 1);
            result[5] = !(d+1 == a);

            return result;
        }
    }
}
