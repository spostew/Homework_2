/*
    Part!: This program will take a standard name and convert it to pig latin
    Name: Spencer Unitt
    Module: Homework 2, Part1
    Problem Statement: Use pig latin to alter your first and last name
    Algorithm:
        1. Create two strings named first and last and set them = to your name
        2. Move the first char from the first string and last string to the back
        3. In a new string named full, concatinate the strings together and set the
           first char to uppercase
        4. Write the result to the console.
        
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Strings used in program
            string first_name = "spencer";
            string last_name = "unitt";
            string pig = "ay";
            string full_name;

            // Moves the first char in the names to the back and adds ay to the end
            first_name = first_name.Substring(1, 6) + first_name.Substring(0, 1) + pig;
            last_name = last_name.Substring(1, 4) + last_name.Substring(0, 1) + pig;

            // Combines the strings together and converts the first char to uppercase
            full_name = char.ToUpper(first_name[0]) + first_name.Substring(1) + " " + char.ToUpper(last_name[0]) + last_name.Substring(1);
           
            // Sends the results to the console
            Console.WriteLine(full_name);
            Console.ReadLine();


        }
    }
}
