using Tyuiu.PautovaMO.Sprint1.Task3.V8.Lib;
namespace Tyuiu.PautovaMO.Sprint1.Task3.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2500;
            double y = 20;
            double z = 30;
            var res = Math.Round(ds.IncomeAmount(x, y, z),3);
            Assert.AreEqual(2541.096, res);

        }
    }
}
