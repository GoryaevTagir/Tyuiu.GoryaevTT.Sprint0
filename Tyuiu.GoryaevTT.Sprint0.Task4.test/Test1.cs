using Tyuiu.GoryaevTT.Sprint0.Task4.lib;
namespace Tyuiu.GoryaevTT.Sprint0.Task4.test;

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
        Assert.AreEqual(10, DataService.Division(100, 10));
    }
}
