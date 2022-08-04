// CIDM 3312 Lab 1: Review of Lists and Methods
// Read README.md for instructions. IN VS Code, press Ctrl+Shift+V or Cmd+Shift+V to preview the README.md file

// Task 1: Create a new, empty list of strings here.
List<string> listOfStrings = new List<string>();

// Task 2: Add 3 strings to your list - their values can be anything.
listOfStrings.Add("red");
listOfStrings.Add("green");
listOfStrings.Add("blue");

// Task 3: Iterate or loop through your list with a foreach loop printing each element to the console.
foreach(string s in listOfStrings)
{
    Console.WriteLine(s);
}

// Task 4: Save and run your program with dotnet run.
// Push your changes to github.
// Check github.com and see if your changes are in the repository online

// Task 5: Write code that checks if your list contains a specific string. If it does, remove it from your list.
// Display a message to the console stating that the specific string was removed from the list 
// or it was not removed from the list.
// Test this code with a string that exists in your list and a string that does not exist in your list.
string strToRemove = "red"; // Test by changing this variable value to another
if (listOfStrings.Contains(strToRemove))
{
    listOfStrings.Remove(strToRemove);
    Console.WriteLine($"{strToRemove} was in your list and it has been removed.");
}
else
{
    Console.WriteLine($"{strToRemove} was not in your list.");
}

// Task 6: Clear the list and verify that it is cleared by printing out its Count to the console
listOfStrings.Clear();
Console.WriteLine($"myStrings has {listOfStrings.Count} elements. It should be zero.");

// Task 7: Save and run your program. Answer the questions in README.md. You can modify README.md directly
// from inside VS Code. Put your name at the top of the README.md file


// Task 8: Push your changes to GitHub and verify that they are uploaded


// Congratulations. You just completed your first lab exercise and practiced lists and git. Good work.   