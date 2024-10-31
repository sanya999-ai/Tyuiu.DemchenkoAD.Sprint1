using Tyuiu.DemchenkoAD.Sprint1.Task7.V15.Lib;
namespace Tyuiu.DemchenkoAD.Sprint1.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double wait = 0.539;
            double result = ds.Calculate(x);
            Assert.AreEqual(wait, result);
        }
    }
}