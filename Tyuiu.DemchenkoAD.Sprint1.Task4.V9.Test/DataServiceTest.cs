using Tyuiu.DemchenkoAD.Sprint1.Task4.V9.Lib;
namespace Tyuiu.DemchenkoAD.Sprint1.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(-0.561, res);

        }
    }
}