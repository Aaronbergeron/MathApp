using System;
using System.Collections.Generic;
using System.Text;

namespace MathFunctions
{
    class Subtraction
    {
        public void Subtract()
        {
            Console.Clear();
            string subtract = "Lets subtract some numbers!";
            Console.WriteLine(subtract);
            Console.WriteLine("Please enter your first number.");               //Reads the users two numbers and makes them strings
            string numOne = Console.ReadLine();
            Console.WriteLine("Please enter your second number.");
            string numTwo = Console.ReadLine();
            int numbOne = int.Parse(numOne);                                    //Parses the two strings into ints to do the subtraction
            int numbTwo = int.Parse(numTwo);
            int difference = numbOne - numbTwo;
            Console.WriteLine($"The difference of {numbOne} and {numbTwo} is {difference}");
            Console.ReadKey();
            Console.Clear();

        }

      
    }
       
    
}
