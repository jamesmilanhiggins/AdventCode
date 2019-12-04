using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;

namespace AdventCode
{
    class Day2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day 2");
            StreamReader file = new StreamReader("../../../../dayTwoInput.txt");
            string line = null;

            while (null != (line = file.ReadLine()))
            {
                string[] values = line.Split(',');

                List<int> intValues = values.Select(int.Parse).ToList();
                for (int i = 0; i < intValues.Count; i += 4)
                {
                    if (intValues[i] == 99)
                    {
                        break;
                    }

                    if (intValues[i] == 1)
                    {
                        Console.WriteLine("OpCode: 1");

                        int positionOneValue = intValues[i + 1];
                        int lookedUpValuePositionOne = intValues[positionOneValue];
                        int positionTwoValue = intValues[i + 2];
                        int lookedUpValuePositionTwo = intValues[positionTwoValue];
                        int positionThreeValue = intValues[i + 3];

                        intValues[positionThreeValue] = lookedUpValuePositionOne + lookedUpValuePositionTwo;
                    }

                    if (intValues[i] == 2)
                    {
                        Console.WriteLine("OpCode: 2:");
                        int positionOneValue = intValues[i + 1];
                        int lookedUpValuePositionOne = intValues[positionOneValue];
                        int positionTwoValue = intValues[i + 2];
                        int lookedUpValuePositionTwo = intValues[positionTwoValue];
                        int positionThreeValue = intValues[i + 3];

                        intValues[positionThreeValue] = (lookedUpValuePositionOne * lookedUpValuePositionTwo);
                    }
                }

                Console.WriteLine("Ending Position 0: " + intValues[0]);
            }
        }
    }
}