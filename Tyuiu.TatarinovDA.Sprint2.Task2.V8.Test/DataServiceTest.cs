using Tyuiu.TatarinovDA.Sprint2.Task2.V8.Lib;
namespace Tyuiu.TatarinovDA.Sprint2.Task2.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckPoint_InsideArea()
        {
            DataService ds = new DataService();
            Assert.IsTrue(ds.CheckDotInShadedArea(5, 5));
            Assert.IsTrue(ds.CheckDotInShadedArea(6, 12));
            Assert.IsTrue(ds.CheckDotInShadedArea(11, 7));
        }
        [TestMethod]
        public void CheckPoint_OutsideArea()
        {
            DataService ds = new DataService();
            Assert.IsFalse(ds.CheckDotInShadedArea(1, 1));
            Assert.IsFalse(ds.CheckDotInShadedArea(9, 9));
            Assert.IsFalse(ds.CheckDotInShadedArea(2, 5));
            Assert.IsFalse(ds.CheckDotInShadedArea(13, 5));
        }
    }
}
