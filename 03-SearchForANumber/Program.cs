using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

                int[] commands = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            int element = commands[0];
            int deleteElement = commands[1];
            int searchNum = commands[2];

            List<int> takenNumbers = new List<int>();
            for (int i = 0; i < element; i++)
            {
                takenNumbers.Add(numbers[i]);
            }

            for (int j = 0; j < deleteElement; j++)
            {
                takenNumbers.Remove(numbers[j]);
            }
            if (takenNumbers.Contains(searchNum))
            {
                Console.WriteLine("YES!");
            }
            else if (!takenNumbers.Contains(searchNum))
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
