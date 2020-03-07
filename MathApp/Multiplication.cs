using System;
using System.Collections.Generic;
using System.Text;

namespace MathFunctions
{
    class Multiplication
    { public void Multip()
        {
            Console.Clear();
            string mult = "Lets multiply some numbers!";
            Console.WriteLine(mult);
            Console.WriteLine("Please enter your first number.");
            string numOne = Console.ReadLine();                         //This reads what the user inputs and stores it as a string "numOne"
            Console.WriteLine("Please enter your second number.");
            string numTwo = Console.ReadLine();                         //This reads what the user inputs and stores it as a string "numTwo"
            int numbOne = int.Parse(numOne);                            //This turns the users string input into ints to complete the multiplication problem
            int numbTwo = int.Parse(numTwo);
            int product = numbOne * numbTwo;
            Console.WriteLine($"The product of {numbOne} and {numbTwo} is {product}.");
            Console.ReadKey();
            Console.Clear();
        }
        
    }
}
