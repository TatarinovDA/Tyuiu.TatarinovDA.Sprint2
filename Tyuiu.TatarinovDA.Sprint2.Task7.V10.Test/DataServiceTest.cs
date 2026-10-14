using Tyuiu.TatarinovDA.Sprint2.Task7.V10.Lib;
namespace Tyuiu.TatarinovDA.Sprint2.Task7.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            Assert.IsTrue(ds.CheckDotInShadedArea(0, -1));
            Assert.IsTrue(ds.CheckDotInShadedArea(0, -2));
            Assert.IsTrue(ds.CheckDotInShadedArea(2, 2));
            Assert.IsFalse(ds.CheckDotInShadedArea(0, 1));
            Assert.IsFalse(ds.CheckDotInShadedArea(0, -3));
            Assert.IsFalse(ds.CheckDotInShadedArea(3, 0));
        }
    }
}
