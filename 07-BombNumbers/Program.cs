using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int[] commands = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int bomb = commands[0];
            int power = commands[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb)
                {
                    int index = i;
                    int leftBombDemage = Math.Max(index  - power, 0);
                    int rightBombDemage = Math.Min(index + power, numbers.Count - 1);

                    int removeNumbers = rightBombDemage - leftBombDemage + 1;
                    numbers.RemoveRange(leftBombDemage, removeNumbers);

                    i = -1;
                }
            }
            int sum = numbers.Sum();
            Console.WriteLine(sum);
        }
    }
}
