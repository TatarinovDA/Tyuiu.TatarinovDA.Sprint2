using Tyuiu.TatarinovDA.Sprint2.Task3.V12.Lib;
namespace Tyuiu.TatarinovDA.Sprint2.Task3.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CalculateValidation()
        {
            DataService ds = new DataService();
            Assert.AreEqual(11.0, ds.Calculate(2.0));
            Assert.AreEqual(10.817, ds.Calculate(2.5));
            Assert.AreEqual(0.036, ds.Calculate(-1.5));
            Assert.AreEqual(-219.95, ds.Calculate(-20.0));
        }
    }
}
