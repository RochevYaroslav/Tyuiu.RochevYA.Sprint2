using tyuiu.cources.programming.interfaces.Sprint2;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.RochevYA.Sprint2.Task6.V6.Lib
{
    public class DataService : ISprint2Task6V6
    {
        public string FindCardNameAndValue(int m, int k)
        {
            string mast, number;

            switch (m)
            {
                case 1:
                    mast = "пики";
                    break;
                case 2:
                    mast = "трефы";
                    break;
                case 3:
                    mast = "бубны";
                    break;
                case 4:
                    mast = "червы";
                    break;
                default:
                    mast = "";
                    break;
            }

            switch (k)
            {
                case 6:
                    number = "шестерка";
                    break;
                case 7:
                    number = "семерка";
                    break;
                case 8:
                    number = "восьмерка";
                    break;
                case 9:
                    number = "девятка";
                    break;
                case 10:
                    number = "десятка";
                    break;
                case 11:
                    number = "валет";
                    break;
                case 12:
                    number = "дама";
                    break;
                case 13:
                    number = "король";
                    break;
                case 14:
                    number = "туз";
                    break;
                default:
                    number = "";
                    break;
            }

            return number + " " + mast;
        }
    }
}
