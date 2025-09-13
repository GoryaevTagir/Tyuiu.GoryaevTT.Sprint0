using Tyuiu.GoryaevTT.Sprint0.Task5.lib;
namespace Tyuiu.GoryaevTT.Sprint0.Task5.test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }
        public void CheckedSubractionValid()
        {
            Assert.AreEqual(10, DataService.Subtraction(15, 5));
        }
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(10, DataService.Multiplication(2, 5));
        }
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}