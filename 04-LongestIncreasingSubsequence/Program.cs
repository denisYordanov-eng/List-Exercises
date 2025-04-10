using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var longestIncreasingSequence = FindLongestIncreasingSequence(inputArr);

            Console.WriteLine(String.Join(" ", longestIncreasingSequence));
        }

        static int[] FindLongestIncreasingSequence(int[] arr)
        {
            int[] lengths = new int[arr.Length];
            int[] previous = new int[arr.Length];

            int bestLength = 0;
            int lastIndex = -1;

            for (int anchor = 0; anchor < arr.Length; anchor++)
            {
                lengths[anchor] = 1;
                previous[anchor] = -1;
                var anchorNum = arr[anchor];
                for (int i = 0; i < anchor; i++)
                {
                    int currentNum = arr[i];
                    if (currentNum < anchorNum && lengths[i] + 1 > lengths[anchor])
                    {
                        lengths[anchor] = lengths[i] + 1;
                        previous[anchor] = i;
                    }
                }
                if (lengths[anchor] > bestLength)
                {
                    bestLength = lengths[anchor];
                    lastIndex = anchor;
                }
            }
            var longestIncreasingSequence = new List<int>();
            while(lastIndex != -1)
            {
                longestIncreasingSequence.Add(arr[lastIndex]);
                lastIndex = previous[lastIndex];
            }
            longestIncreasingSequence.Reverse();
            return longestIncreasingSequence.ToArray();
        }
    }
}
