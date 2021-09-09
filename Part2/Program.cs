/*
    Part2: This program will convert the temp the user enters from F to C
    Name: Spencer Unitt
    Module: Homework 2, Part2
    Problem Statement: Show how to convert tempurature by using user input.
    Algorithm:
        1. Declare a double variable named degreeC
        2. Create a welcome message for user and prompt for a tempuarature
        3. Set a string called temp to the next line displayed in the console
        4. Use the equation degreeC = 5 * (double.Parse(temp) - 32) / 9 to convert
        5. Send the results back to the user
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
        
            double degreeC;
            // Prompts user for some input
            Console.WriteLine("Enter in a tempurature below: ");
            // Takes the input entered from the user
            string temp = Console.ReadLine();
            
            // converts the int the user entered into a double
            degreeC = 5 * (double.Parse(temp) - 32) / 9;

            // displays the message to the user to 1 decimal place
            Console.WriteLine("The tempurature in Celsius is: " + Math.Round(degreeC, 1));
            Console.ReadLine();

        }
    }
}
