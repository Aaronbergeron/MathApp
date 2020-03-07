using System;
using System.Collections.Generic;
using System.Text;

namespace MathFunctions
{
    class Add
    {
        
        public void Addition()
        {
                Console.Clear();
                string letsGo = "Lets add some numbers!";
                Console.WriteLine(letsGo);
                Console.WriteLine("Please enter your first number.");               //Accepts two user inputs as strings
                string numOne = Console.ReadLine();
                Console.WriteLine("Please enter your second number.");
                string numTwo = Console.ReadLine();
                int one = int.Parse(numOne);                                        //Parses the two strings into ints to complete the addition
                int two = int.Parse(numTwo);
                int sum = one + two;
                Console.WriteLine($"The sum of {one} and {two} is {sum}!");         //Displays answer tto the user
                Console.ReadKey();
                Console.Clear();
            
        }
       
    }
}
