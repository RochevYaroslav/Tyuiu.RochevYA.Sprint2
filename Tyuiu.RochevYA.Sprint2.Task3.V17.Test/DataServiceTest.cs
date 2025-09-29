using Tyuiu.RochevYA.Sprint2.Task3.V17.Lib;
namespace Tyuiu.RochevYA.Sprint2.Task3.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual(-0.286, ds.Calculate(0));
            Assert.AreEqual(50.629, ds.Calculate(5));
            Assert.AreEqual(-549.98, ds.Calculate(-50));
        }
    }
}
