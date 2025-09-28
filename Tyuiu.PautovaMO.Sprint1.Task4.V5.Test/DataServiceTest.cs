using Tyuiu.PautovaMO.Sprint1.Task4.V5.Lib;
namespace Tyuiu.PautovaMO.Sprint1.Task4.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 2;
            double y = 4;
            
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.25, res);

        }
    }
}