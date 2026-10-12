using Tyuiu.TatarinovDA.Sprint2.Task0.V29.Lib;

namespace Tyuiu.TatarinovDA.Sprint2.Task0.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 105;
            int y = 735;

            bool[] expected = { false, false, true, true, false, false };
            bool[] actual = ds.GetCompareOperations(x, y);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
