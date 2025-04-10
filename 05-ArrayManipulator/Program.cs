using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _05_ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse).ToList();

            while (true)
            {
                string[] commands = Console.ReadLine()
                    .Split(' ').ToArray();
               
                if (commands[0] == "print")
                {
                    break;
                }
                if (commands[0] == "add")
                {
                    int index = int.Parse(commands[1]);
                    int element = int.Parse(commands[2]);

                    numbers.Insert(index, element);
                }
                else if (commands[0] == "addMany")
                {
                    int position = int.Parse(commands[1]);
                    var addedNumbers = new List<int>();
                    for (int j = 2; j < commands.Length; j++)
                    {
                        addedNumbers.Add(int.Parse(commands[j]));

                    }
                    numbers.InsertRange(position,addedNumbers);
                }
                else if (commands[0] == "contains")
                {
                    int number = int.Parse(commands[1]);
                    if (numbers.Contains(number))
                    {
                        int index = numbers.IndexOf(number);
                        Console.WriteLine(index);
                    }
                    else
                    {
                        Console.WriteLine(-1);
                    }
                }
                else if (commands[0] == "remove") 
                {
                    int removeIndex = int.Parse(commands[1]);
                    numbers.RemoveAt(removeIndex);
                }
                else if(commands[0] == "shift")
                {
                    int rotatinon = int.Parse(commands[1]) % numbers.Count;
                    for (int m = 0; m < rotatinon; m++)
                    {
                        numbers.Add(numbers[0]);
                        numbers.RemoveAt(0);
                    }
                }
                else if(commands[0] == "sumPairs")
                {
                    var sum = new List<int>();
                    for (int l = 0; l < numbers.Count ; l += 2)
                    {
                        int currentNumber = numbers[l];
                        int nextNumber = 0;
                        if (l < numbers.Count - 1)
                        {
                            nextNumber = numbers[l + 1];
                        }
                        int sumNumbers = currentNumber + nextNumber;
                        sum.Add(sumNumbers);
                    }
                    numbers = sum;
                }
            }
            Console.WriteLine($"[{String.Join(", ", numbers)}]");
        }
    }
}
