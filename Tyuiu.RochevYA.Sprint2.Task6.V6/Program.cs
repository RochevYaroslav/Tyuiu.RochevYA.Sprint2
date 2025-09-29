using Tyuiu.RochevYA.Sprint2.Task6.V6.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("Масть: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Достоинство: ");
        int k = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(ds.FindCardNameAndValue(m,k));
        Console.WriteLine("Сделал Рочев Ярослав Антонович | ИБКСб-25-1");
    }
}