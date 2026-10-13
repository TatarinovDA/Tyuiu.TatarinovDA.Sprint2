using Tyuiu.TatarinovDA.Sprint2.Task4.V26.Lib;
namespace Tyuiu.TatarinovDA.Sprint2.Task4.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CalculateValidation()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double expected = 1157.625;
            double result = ds.Calculate(x, y);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void CalculateValidationFalseCondition()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 1;
            double expected = 24;
            double result = ds.Calculate(x, y);
            Assert.AreEqual(expected, result);
        }
    }
}
