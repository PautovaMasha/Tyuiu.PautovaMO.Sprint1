using Tyuiu.PautovaMO.Sprint1.Task6.V15.Lib;
namespace Tyuiu.PautovaMO.Sprint1.Task6.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string value = "Hello World !---";
            var wait = true;
            DataService ds = new DataService();
            var res = ds.CheckLettersCount(value);
            Assert.AreEqual(wait, res);
        }
    }
}
