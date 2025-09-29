using Tyuiu.RochevYA.Sprint2.Task4.V10.Lib;
namespace Tyuiu.RochevYA.Sprint2.Task4.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual(8, ds.Calculate(1,3));
            Assert.AreEqual(1.027, ds.Calculate(2,15));
        }
    }
}
