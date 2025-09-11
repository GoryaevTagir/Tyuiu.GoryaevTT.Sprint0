using Tyuiu.GoryaevTT.Sprint0.Task2.lib;

namespace Tyuiu.GoryaevTT.Sprint0.Task2.test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetMessageValid()
        {
            var name = "Tagir";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Tagir", res);
        }
    }
}