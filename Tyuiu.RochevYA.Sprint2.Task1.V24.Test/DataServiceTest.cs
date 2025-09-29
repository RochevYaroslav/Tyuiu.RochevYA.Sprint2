using Tyuiu.RochevYA.Sprint2.Task1.V24.Lib;
namespace Tyuiu.RochevYA.Sprint2.Task1.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            bool[] res = ds.GetLogicOperations(325,325,242, 324);
            bool[] expected = { true, false, true, false, true, false };
            CollectionAssert.AreEqual(expected, res);
        }
    }
}
