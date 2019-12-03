using System;
using System.IO;

namespace AdventCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day 1");
            System.IO.StreamReader file = new System.IO.StreamReader("../../../../input.txt");  
            
            int fuelRequirements = 0;  
            string line;

            while((line = file.ReadLine()) != null)  
            {
                DayOneMath(line);
                
            }  
            Console.WriteLine ("fuelRequirements = " + fuelRequirements);


            int DayOneMath(string inputNumberString)
            {
                int intMass = int.Parse(inputNumberString);
                int intMassDivThree = intMass / 3; 

                int intMassDivThreeMinus2 = intMassDivThree - 2;
                
                return fuelRequirements += intMassDivThreeMinus2;

            }

        }
    }
}