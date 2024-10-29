using Tyuiu.DemchenkoAD.Sprint1.Task6.V6.Lib;
namespace Tyuiu.DemchenkoAD.Sprint1.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string strTest = "Напечатать все слова, удалив из них первую букву";
            DataService ds = new DataService();
            string res = ds.DeleteFirstLetter(strTest);
            string wait = "апечатать се лова, далив з их ервую укву";
            Assert.AreEqual(wait, res);

        }
    }
}