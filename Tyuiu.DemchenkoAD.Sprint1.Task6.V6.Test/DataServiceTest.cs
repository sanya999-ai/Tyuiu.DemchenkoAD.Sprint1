using Tyuiu.DemchenkoAD.Sprint1.Task6.V6.Lib;
namespace Tyuiu.DemchenkoAD.Sprint1.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string strTest = "���������� ��� �����, ������ �� ��� ������ �����";
            DataService ds = new DataService();
            string res = ds.DeleteFirstLetter(strTest);
            string wait = "��������� �� ����, ����� � �� ����� ����";
            Assert.AreEqual(wait, res);

        }
    }
}