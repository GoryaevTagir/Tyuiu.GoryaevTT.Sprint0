using Tyuiu.GoryaevTT.Sprint0.Task6.lib;

namespace Tyuiu.GoryaevTT.Sprint0.Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            var arraynums = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Сумма элементов списка:" + DataService.AdditionArray(arraynums));
            Console.WriteLine("Разность элементов списка:" + DataService.SubstractionArray(arraynums));
            Console.WriteLine("Произведение элементов списка:" + DataService.MultiplicationArray(arraynums));
            Console.ReadKey();
        }
    }
}