using Tyuiu.RochevYA.Sprint2.Task2.V4.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("X: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Y: ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(ds.CheckDotInShadedArea(x, y));
        Console.WriteLine("Сделал Рочев Ярослав Антонович | ИБКСб-25-1");
    }
}