## Your Name: 


# CIDM 3312 Lab 1: Review of Lists and Methods

The goal of this lab exercise is to review your knowledge of lists and methods in C#. You will also practice using git and GitHub. Don't hesitate to ask questions. Read the instructions in this file, `README.md`, below. You can view them in VS Code by pressing Ctrl+Shift+V or Cmd+Shift+V.

Need Help? Don't hesitate to reach out -

- Join our slack channel. Details are on WTClass.
- Email or call me.

## Task 0
1. Watch the Week 1 videos and read the lecture notes on WTClass in our Week 1 folder. These explain how to setup this assignment, complete it, and submit it.
2. Accept the assignment invite link in GitHub.
3. Clone your repository in VS Code.

## Task 1
1. In the `Main` method, write C# code to create a new, empty list of strings.

## Task 2
1. Add 3 strings to your list using the List `.Add()` method.

## Task 3
1. Iterate or loop through your list with a `foreach` loop printing each element to the console with a `Console.WriteLine()` inside the loop.

## Task 4
1. Save your program and run it. At the terminal prompt, type `dotnet run`.
2. Setup git if you have not done so already (You only need to do this once per computer):
    ```
    git config --global user.name "Your Name"
    git config --global user.email youremail@example.com
    ```
3. Push your changes to GitHub using the VS Code GUI:
    - Click the source control icon in VS Code
    - Type in a commit message
    - Click the checkbox icon to commit. (Click yes on the message box to stage your commit)
    - Click the 3 dots icon (...) for more actions and click Push.
4. Or you can push your changes to GitHub using the Terminal:
    ```
    git add -A
    git commit -m "Your commit message"
    git push
    git status
    ```
5. Visit the URL of your GitHub repository in a web browser and verify that your changes are on GitHub.    

## Task 5 **Challenge Task**
1. Create a method called `RemoveFromList()`. Remember to create this method inside `Class Program` but outside of the `Main` method.
2. This method should check if your list contains a specific string. If it does, remove it from your list and return true. Otherwise return false.
3. Here are some details:
    - The first parameter for the method should be a List of strings: `List<string> myList`.
    - The second parameter should be the specific string you are checking: `string stringToRemove`.
    - It should return a `bool` which is `true` or `false`.
    - Next write the code inside the method. Make sure to use the `.Contains()` and `.Remove()` List methods.
4. In your `Main` method, you need to call `RemoveFromList()`, check its return value, and print an appropriate message:
    ```
    bool result = RemoveFromList(myList, "red");
    if (result == true)
    {
        Console.WriteLine("red was in the list and removed!");
    }
    else
    {
        Console.WriteLine("red was not in the list, RemoveFromList returned false.");
    }
    ```

## Task 6
1. Clear the list using the List `.Clear()` method.
2. Verify that it is empty by printing the `Count` property of the list out to the console.

## Task 7
Answer the following TWO questions by typing your answers right here in `README.md`.

1. What is the purpose of the `using` directive?

    Replace this text with your response.

2. What is the difference between a `for` loop and a `foreach` loop?

    Replace this text with your response.

## Task 8
1. Save your program and run it. At the terminal prompt, type `dotnet run`.
2. Edit `README.md` and put your name at the top.
3. Push your changes to GitHub by following the instructions in Task 4.
4. Verify that your changes are on GitHub.
6. Congratulations! You just completed your first CIDM 3312 assignment. I hope this helped you refresh your C# skills with Lists and Methods, as well as introduce you to GitHub. 