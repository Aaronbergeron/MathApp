using System;
using System.Collections.Generic;
using System.Text;

namespace MathFunctions
{
    class Division
    {
        public void Div()
        {
            Console.Clear();
            string div = "Lets divide some numbers!";
            Console.WriteLine(div);
            Console.WriteLine("Please enter your first number.");       //Reads the users first number and makes it string "numOne"
            string numOne = Console.ReadLine();
            Console.WriteLine("Please enter your second number");       //Reads the user's first number and makes it string "numTwo"
            string numTwo = Console.ReadLine();
            int numbOne = int.Parse(numOne);                            //Parses the two strings that the user input and makes them into ints to complete the division
            int numbTwo = int.Parse(numTwo);
            int quotient = numbOne / numbTwo;                           //Divides numbOne and numbTwo
            int remainder = numbOne % numbTwo;                          //Modulus of the two numbers to be shown as the remainder

            Console.WriteLine($"The quotient of {numbOne} and {numbTwo} is {quotient} with a remainder of {remainder}");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
