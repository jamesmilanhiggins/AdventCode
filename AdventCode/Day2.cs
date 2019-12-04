using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;

namespace AdventCode
{
    class Day2
    {
       
         private static int Calculate(int[] intValues)
            {
              
                for (var i = 0; i < intValues.Length; i += 4)
                {
                    if (intValues[i] == 99)
                    {
                        break;
                    }
                    
                    if (intValues[i] == 1)
                    {
                        Console.WriteLine("OpCode: 1");

                        var positionOneValue = intValues[i + 1];
                        var lookedUpValuePositionOne = intValues[positionOneValue];
                        var positionTwoValue = intValues[i + 2];
                        var lookedUpValuePositionTwo = intValues[positionTwoValue];
                        var positionThreeValue = intValues[i + 3];

                        intValues[positionThreeValue] = lookedUpValuePositionOne + lookedUpValuePositionTwo;
                    }

                    if (intValues[i] != 2) continue;
                    {
                        Console.WriteLine("OpCode: 2:");
                        var positionOneValue = intValues[i + 1];
                        var lookedUpValuePositionOne = intValues[positionOneValue];
                        var positionTwoValue = intValues[i + 2];
                        var lookedUpValuePositionTwo = intValues[positionTwoValue];
                        var positionThreeValue = intValues[i + 3];

                        intValues[positionThreeValue] = (lookedUpValuePositionOne * lookedUpValuePositionTwo);
                    }
                }

                Console.WriteLine("Ending Position 0: " + intValues[0]);
                return intValues[0];
            }

         private static void Main(string[] args)
        {
            Console.WriteLine("Day 2");
            var file = new StreamReader("../../../../dayTwoInput.txt");

            string line = null;
            while (null != (line = file.ReadLine()))
            {
                var values = line.Split(',');
                var intValues = values.Select(int.Parse).ToList();

                var answer = Calculate(intValues.ToArray());
                    
                Console.WriteLine(answer + " = answer");
            }
        }
    }
}