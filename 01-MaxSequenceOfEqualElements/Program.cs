using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                .Split(' ').Select(int.Parse)
                .ToArray();

            Console.WriteLine(String.Join(" ", FindingTheLongestSequence(number)));
        }

         static int[] FindingTheLongestSequence(int[] number)
        {
            
            List<int> currentNumberSequence = new List<int>();
            List<int> longestSequence = new List<int>();

            currentNumberSequence.Add(number[0]);
            
            for (int i = 1; i < number.Length ; i++)
            {
                int previousNumber = currentNumberSequence[0];
                int currentNumber = number[i];

                if (currentNumber == previousNumber)
                {
                    currentNumberSequence.Add(currentNumber);
                }
                else
                { 
                    currentNumberSequence.Clear();
                    currentNumberSequence.Add(currentNumber);
                }
                if(currentNumberSequence.Count > longestSequence.Count)
                {
                    longestSequence = new List<int>(currentNumberSequence);
                }
                //previousNumber = currentNumber;
            }
           
            return longestSequence.ToArray();
        }
    }
}
 