using Tyuiu.RochevYA.Sprint2.Task7.V5.Lib;
namespace Tyuiu.RochevYA.Sprint2.Task7.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual(true, ds.CheckDotInShadedArea(0, 1));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(100, 5));
        }
    }
}
