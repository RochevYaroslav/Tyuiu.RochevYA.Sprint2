using Tyuiu.RochevYA.Sprint2.Task5.V2.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("Month: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(ds.FindMonthSeason(x));
        Console.WriteLine("Сделал Рочев Ярослав Антонович | ИБКСб-25-1");
    }
}