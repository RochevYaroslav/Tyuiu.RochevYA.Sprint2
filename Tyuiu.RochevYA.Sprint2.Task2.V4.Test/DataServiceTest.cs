using Tyuiu.RochevYA.Sprint2.Task2.V4.Lib;
namespace Tyuiu.RochevYA.Sprint2.Task2.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual(true, ds.CheckDotInShadedArea(3, 3));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(1, 1));
            Assert.AreEqual(true, ds.CheckDotInShadedArea(8, 8));
        }
    }
}
