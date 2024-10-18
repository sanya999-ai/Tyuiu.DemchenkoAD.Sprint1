using Tyuiu.DemchenkoAD.Sprint1.Task1.V3.Lib;
namespace Tyuiu.DemchenkoAD.Sprint1.Task1.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(3.2, res);
        }
    }
}