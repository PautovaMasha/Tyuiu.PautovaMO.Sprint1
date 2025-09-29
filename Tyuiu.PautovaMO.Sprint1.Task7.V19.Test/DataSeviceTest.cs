using Tyuiu.PautovaMO.Sprint1.Task7.V19.Lib;
namespace Tyuiu.PautovaMO.Sprint1.Task7.V19.Test
{
    [TestClass]
    public sealed class DataSeviceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 2;

            var res = ds.Calculate(x);
            Assert.AreEqual(15.409, res);

        }
    }
}
