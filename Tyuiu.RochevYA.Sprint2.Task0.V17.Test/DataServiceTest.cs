using Tyuiu.RochevYA.Sprint2.Task0.V17.Lib;
namespace Tyuiu.RochevYA.Sprint2.Task0.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            bool[] res = ds.GetCompareOperations(1065, 755);
            bool[] expected = { true, false, false, false, false, false };
            CollectionAssert.AreEqual(expected, res);
        }
    }
}
