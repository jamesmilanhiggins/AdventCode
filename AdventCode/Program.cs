using System;
using System.Collections.Generic;
using System.IO;

namespace AdventCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day 1");
            System.IO.StreamReader file = new System.IO.StreamReader("../../../../dayOneInput.txt");  
            
            int fuelRequirements = 0;  
            string line;

            while((line = file.ReadLine()) != null)
            {
                int intLine = int.Parse(line);
                FuelCalculation(intLine);
            }  
            Console.WriteLine("Fuel Requirements = " + fuelRequirements);
            

            void FuelCalculation(int mass)
            {
                int num = mass;
                while (DivideByThreeAndSubtractTwo(num) > 0)
                {
                    int newNum = DivideByThreeAndSubtractTwo(num);
                    fuelRequirements += newNum;
                    num = newNum;
                }
            }
            
            int DivideByThreeAndSubtractTwo(int inputNumber)
            {    
                
                int massDivThree = inputNumber / 3; 
                int numberAfterCalculation = massDivThree - 2;
                
                return numberAfterCalculation;
            }

        }
    }
}