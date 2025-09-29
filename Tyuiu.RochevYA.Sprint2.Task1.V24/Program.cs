using Tyuiu.RochevYA.Sprint2.Task1.V24.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int a = 325;
        int b = 325;
        int c = 242;
        int d = 324;
        Console.WriteLine("(" + string.Join(", ", ds.GetLogicOperations(a, b, c, d)) + ")");
        Console.WriteLine("Сделал Рочев Ярослав Антонович | ИБКСб-25-1");
    }
}