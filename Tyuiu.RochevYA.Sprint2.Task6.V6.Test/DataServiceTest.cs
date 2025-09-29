using Tyuiu.RochevYA.Sprint2.Task6.V6.Lib;
namespace Tyuiu.RochevYA.Sprint2.Task6.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Восьмерка пики", ds.FindCardNameAndValue(1,8));
            Assert.AreEqual("Туз бубны", ds.FindCardNameAndValue(3,14));
        }
    }
}
