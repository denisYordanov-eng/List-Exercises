using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();

            var revesedString = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                string str = input[i];
                string reveresedInput = new string(str.Reverse().ToArray());
                revesedString.Add(reveresedInput);
            }
            var reversedNumbers = new List<int>();
            for (int i = 0; i < revesedString.Count; i++)
            {
                reversedNumbers.Add(int.Parse(revesedString[i]));
            }
            int sum = reversedNumbers.Sum();
            Console.WriteLine(sum);
        }
    }
}
