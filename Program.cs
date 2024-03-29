﻿using System;
using System.Collections.Generic; // Needed for Task 1 and Lists

// CIDM 3312 Lab 1: Review of Lists and Methods
// Read README.md for instructions. IN VS Code, press Ctrl+Shift+V or Cmd+Shift+V to preview the README.md file
namespace lab1_starter
{
    class Program
    {
        // Task 5 Hint: Put your method underneath this comment
        static bool RemoveFromList(List<string> myList, string stringToRemove)
        {
            if (myList.Contains(stringToRemove))
            {
                myList.Remove(stringToRemove);
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            // Task 1: Create a new, empty list of strings here.
            // Hint: Remember the using directive?
            List<string> myStrings = new List<string>();

            // Task 2: Add 3 strings to your list - their values can be anything.
            myStrings.Add("red");
            myStrings.Add("green");
            myStrings.Add("blue");

            // Task 3: Iterate or loop through your list with a foreach loop printing each element to the console.
            foreach(string s in myStrings)
            {
                Console.WriteLine(s);
            }


            // Task 4: Save and run your program with dotnet run.
            // Push your changes to github.
            // Check github.com and see if your changes are in the repository online


            // Challenge Task 5: Make a method called RemoveFromList()
            // This method should take 2 parameters - a list of strings and the specific string you want to remove.
            // It should return a bool (true or false).
            // The method should check if the list contains the specific element using an if statement and .Contains()
            // If the list contains the element, return true, otherwise return false

            // Call RemoveFromList() here in Main.
            bool result = RemoveFromList(myStrings, "red");
            if (result == true)
            {
                Console.WriteLine("red was in the list and removed!");
            }
            else
            {
                Console.WriteLine("red was NOT in the list, RemoveFromList returned false.");
            }

            // Task 6: Clear the list and verify that it is cleared by printing out its Count to the console
            myStrings.Clear();
            Console.WriteLine($"myStrings has {myStrings.Count} elements. It should be zero.");

            // Task 7: Save and run your program. Answer the questions in README.md. You can modify README.md directly
            // from inside VS Code. Put your name at the top of the README.md file


            // Task 8: Push your changes to GitHub and verify that they are uploaded


            // Congratulations. You just completed your first lab exercise and practiced lists, methods, and git. Good work.          
        }
    }
}