using Tyuiu.DemchenkoAD.Sprint1.Task5.V2.Lib;
namespace Tyuiu.DemchenkoAD.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double temp = 68;
            DataService ds = new DataService();
            double res = ds.FahrenheitTo�elsius(temp);

            int result = Convert.ToInt32(res);

            int wait = 20;
            Assert.AreEqual(wait, result);

        }
    }
}