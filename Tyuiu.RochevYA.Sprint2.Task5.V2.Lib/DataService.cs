using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.RochevYA.Sprint2.Task5.V2.Lib
{
    public class DataService : ISprint2Task5V2
    {
        public string FindMonthSeason(int x)
        {
            switch (x)
            {
                case 0:
                case 1:
                case 11:
                    return "Зима";
                case 2:
                case 3:
                case 4:
                    return "Весна";
                case 5:
                case 6:
                case 7:
                    return "Лето";
                case 8:
                case 9:
                case 10:
                    return "Осень";
                default:
                    return "None";
            }
        }
    }
}
