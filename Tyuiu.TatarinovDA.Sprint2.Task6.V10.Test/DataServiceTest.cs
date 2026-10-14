using Tyuiu.TatarinovDA.Sprint2.Task6.V10.Lib;
namespace Tyuiu.TatarinovDA.Sprint2.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetPreviousDate()
        {
            DataService ds = new DataService();
            Assert.AreEqual("14.06.2023", ds.FindDateOfPreviousDay(2023,6,15));
            Assert.AreEqual("30.06.2023", ds.FindDateOfPreviousDay(2023,7,1));
            Assert.AreEqual("30.04.2023", ds.FindDateOfPreviousDay(2023,5,1));
            Assert.AreEqual("28.02.2023", ds.FindDateOfPreviousDay(2023,3,1));
            Assert.AreEqual("31.12.2022", ds.FindDateOfPreviousDay(2023,1,1));
        }
    }
}
