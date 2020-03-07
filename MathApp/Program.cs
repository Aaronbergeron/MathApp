using System;

namespace MathFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;                                                      //Declaring "master" int i which will determine how long the loop runs based off user choice
            Intro mathIntro = new Intro();                                  
            Console.WriteLine(mathIntro.Welcome());
            Console.ReadKey();
            Console.Clear();
           do
           { 
            Intro choose = new Intro(); 
            Console.WriteLine(choose.Menu());
            string choice = Console.ReadLine();           
                if (choice == "1")                                             //If statement with each of the options from the menu. Whatever the user inputs, it will bring them  
                {                                                              //to that seperate menu
                    Add addIt = new Add();                                      
                    addIt.Addition();
                    
                }
                else if (choice == "2")
                {
                    Subtraction subtractIt = new Subtraction();
                    subtractIt.Subtract();
                    
                }
                else if (choice == "3")
                {
                    Division divi = new Division();
                    divi.Div();
                    
                }
                else if (choice == "4")
                {
                    Multiplication multiply = new Multiplication();
                    multiply.Multip();
                    
                }
                else if (choice == "5")                                     //Option 5 is quit - The loop will run as long as i == 0, but if the user wants to quit this 
                {                                                           //incriment will make i == 1 which ends the program
                    i++;
                }
                else
                {
                    Console.WriteLine("You did not enter a correct option. Try again.");
                    Console.ReadLine();
                    Console.Clear();
                                                                                //If user enters something besides 1-5, it will display an error message and loop them
                }                                                               //back to the menu
           } while (i == 0);
        }       
    }
}
