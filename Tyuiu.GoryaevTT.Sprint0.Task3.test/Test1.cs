using Tyuiu.GoryaevTT.Sprint0.Task3.lib;
namespace Tyuiu.GoryaevTT.Sprint0.Task3.test;

[TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }

