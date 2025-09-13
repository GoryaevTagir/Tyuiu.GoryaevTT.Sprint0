using Tyuiu.GoryaevTT.Sprint0.Task7.lib;
namespace Tyuiu.GoryaevTT.Sprint0.Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт №0 | Выполнил: Горяев Т. Т. | ПИНб-25-1";
            Console.WriteLine("Тема: Создание итоговогорешения по спринту");
            Console.WriteLine("Задание №7");
            Console.WriteLine("Вариант №0");
            Console.WriteLine("УСЛОВИЕ:");
            Console.WriteLine("Написать консольную программу на C#, которая суммирует значения двух одинаковых по длинне массивов.");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:");
            var arrayNums1 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значение элементов массива 1:");

            for (int i = 0; i < arrayNums1.Length; i++)
            {
                Console.WriteLine(arrayNums1[i] + ", ");
            }
            Console.WriteLine();
            var arrayNums2 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значение элементов массива 2:");

            for (int i = 0; i < arrayNums2.Length; i++)
            {
                Console.WriteLine(arrayNums2[i] + ", ");
            }
            Console.WriteLine("РЕЗУЛЬТАТ:");

            if (arrayNums1.Length == arrayNums2.Length)
            {
                int[] resultArray = DataService.AdditionArrays(arrayNums1, arrayNums2);
                Console.WriteLine("Сумма элементов равна:");
                for (int i = 0; i < arrayNums1.Length; i++)
                {
                    Console.WriteLine(resultArray[i] + ", ");
                }
                Console.ReadKey();
            }
        }
    }
}