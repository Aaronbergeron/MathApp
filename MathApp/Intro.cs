using System;
using System.Collections.Generic;
using System.Text;

namespace MathFunctions
{
    class Intro
    {
        public string Welcome()
        {
            string intro = "Welcome! This is just a simple math calculator where you can add, subtract, divide, and multiply numbers.";
            return intro;
           
        }
        public string Menu()
        {
            string menu = "Choose what type of problem you would like to solve.\n1. Addition\n2. Subtraction\n3. Division\n4. Multiplication\n5. Quit";
            return menu;
            
            
        }
            //Intro that will be called in the main method
    }
}
