using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggerDemo
{
    internal class Program
    {
        static List<int> numbers = new List<int>();
        static Random random = new Random(1234);

        static void Main(string[] args)
        {
            FillListWithRandomNumbers(1, 1000, 30);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            int max = FindMax();
            Console.WriteLine("\n" + max);
        }

        private static int FindMax()
        {
            int max = numbers[0];
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > max)
                {
                    Debug.WriteLine($"{max} -> {numbers[i]}");
                    max = numbers[i];
                }
            }
            return max;
        }

        private static void FillListWithRandomNumbers(int min, int max, int db)
        {
            for (int i = 0; i < db; i++)
            {
                int number = GenerateRandomNumber(min, max);
                numbers.Add(number);
            }
        }

        private static int GenerateRandomNumber(int min, int max)
        {
            return random.Next(min, max);
        }
    }
}
