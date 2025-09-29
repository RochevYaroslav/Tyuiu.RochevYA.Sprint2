using Tyuiu.RochevYA.Sprint2.Task5.V2.Lib;
namespace Tyuiu.RochevYA.Sprint2.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Зима", ds.FindMonthSeason(1));
            Assert.AreEqual("Лето", ds.FindMonthSeason(7));
        }
    }
}
