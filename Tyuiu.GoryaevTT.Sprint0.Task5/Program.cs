using Tyuiu.GoryaevTT.Sprint0.Task5.lib;


namespace Tyuiu.GoryaevTT.Sprint0.Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(1, 5));
            Console.WriteLine("A - B = " + DataService.Subtraction(15, 5));
            Console.WriteLine("A * B = " + DataService.Multiplication(10, 10));
            Console.WriteLine("A / B = " + DataService.Division(10, 0));
        }
    }
}
