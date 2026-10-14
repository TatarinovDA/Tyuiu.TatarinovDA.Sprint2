using Tyuiu.TatarinovDA.Sprint2.Task5.V15.Lib;
namespace Tyuiu.TatarinovDA.Sprint2.Task5.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayNameMon()
        {
            DataService ds = new DataService();
            int k = 1;
            string wait = "Понедельник";
            string res = ds.FindDayName(k);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidFindDayNameSun()
        {
            DataService ds = new DataService();
            int k = 7;
            string wait = "Воскресенье";
            string res = ds.FindDayName(k);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidFindDayNameMon2()
        {
            DataService ds = new DataService();
            int k = 8;
            string wait = "Понедельник";
            string res = ds.FindDayName(k);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidFindDayNameMon3()
        {
            DataService ds = new DataService();
            int k = 365;
            string wait = "Понедельник";
            string res = ds.FindDayName(k);
            Assert.AreEqual(wait, res);
        }
    }
}
