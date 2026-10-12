using Tyuiu.TatarinovDA.Sprint2.Task1.V2.Lib;
namespace Tyuiu.TatarinovDA.Sprint2.Task1.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            int a = 135, b = 156, c = 154, d = 174;
            bool[] expected = { true, true, true, true, true, false };
            DataService ds = new DataService();
            bool[] actual = ds.GetLogicOperations(a, b, c, d);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
