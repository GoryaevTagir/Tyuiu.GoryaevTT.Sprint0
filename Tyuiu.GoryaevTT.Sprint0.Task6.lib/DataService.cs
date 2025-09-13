using System.Globalization;

namespace Tyuiu.GoryaevTT.Sprint0.Task6.lib
{
    public class DataService
    {
        public static object AdditionArray(int[] Number)
        {
            var total = 0;
            for (var i = 0; i < Number.Length; i++)
            {
                total += Number[i];
            }
            return total;
        }

        public static object SubstractionArray(int[] Number)
        {
            var total = 0;
            int index = 0;

            while (index < Number.Length)
            { 
                total= total - Number[index];
                index++;
            }
            return total;
        }

        public static object MultiplicationArray(int[] Number)
        {
            var total = 1;
            int index = 0;

            do
            {
                total = total * Number[index];
                index++;
            }
            while (index < Number.Length);
            return total;
        }
    }
}
