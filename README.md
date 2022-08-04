## Your Name: Kareem Dana Lab 1 - Solution


# CIDM 3312 Lab 1: Review of Lists

The goal of this lab exercise is to review your knowledge of lists in C#. You will also practice using git and GitHub. Don't hesitate to ask questions. Read the instructions in this file, `README.md`, below. You can view them in VS Code by pressing Ctrl+Shift+V or Cmd+Shift+V.

Need Help? Don't hesitate to reach out -

- Join our slack channel. Details are on WTClass.
- Email or call me.

## Task 0
1. Watch the Week 1 videos and read the lecture notes on WTClass in our Week 1 folder. These explain how to setup this assignment, complete it, and submit it.
2. Accept the assignment invite link in GitHub.
3. Clone your repository in VS Code.

## Task 1
1. In `Program.cs`, write C# code to create a new, empty list of strings. Review https://aka.ms/new-console-template to better understand the top-level statement coding style new in .NET 6.0.

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

## Task 5 
1. Write code that checks if your list contains a specific string. If it does, remove it from your list.
2. Display a message to the console stating that the specific string was removed from the list or it was not removed from the list.
3. Test this code with a string that exists in your list and a string that does not exist in your list.

## Task 6
1. Clear the list using the List `.Clear()` method.
2. Verify that it is empty by printing the `Count` property of the list out to the console.

## Task 7
Answer the following question by typing your answers right here in `README.md`.

1. What is the difference between a `for` loop and a `foreach` loop?

    **Both iterate over collections (arrays, lists). The foreach loop is a simpler, cleaner syntax but is read only. You cannot modify the list while you are looping through it. The for loop uses the array square bracket syntax and is more powerful in that you can modify a list as you are looping**

## Task 8
1. Save your program and run it. At the terminal prompt, type `dotnet run`.
2. Edit `README.md` and put your name at the top.
3. Push your changes to GitHub by following the instructions in Task 4.
4. Verify that your changes are on GitHub.
6. Congratulations! You just completed your first CIDM 3312 assignment. I hope this helped you refresh your C# skills with Lists and Methods, as well as introduce you to GitHub. 