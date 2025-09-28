using Tyuiu.RochevYA.Sprint2.Task0.V17.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int x = 1065;
        int y = 755;
        Console.WriteLine("(" + string.Join(", ", ds.GetCompareOperations(x, y)) + ")");
        Console.WriteLine("Сделал Рочев Ярослав Антонович | ИБКСб-25-1");
    }
}