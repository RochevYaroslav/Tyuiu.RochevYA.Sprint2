using Tyuiu.RochevYA.Sprint2.Task7.V5.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("X: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Y: ");
        double y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(ds.CheckDotInShadedArea(x, y));
        Console.WriteLine("Сделал Рочев Ярослав Антонович | ИБКСб-25-1");
    }
}