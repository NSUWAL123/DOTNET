// See https://aka.ms/new-console-template for more information

//using Year3ConsoleApp.Basics;
using Year3ConsoleApp.week3;

//getting input from users
// Declare variables and then initialize to zero.
int num1 = 0; int num2 = 0;


// Ask the user to type the first number.
Console.WriteLine("Type a number, and then press Enter");
num1 = Convert.ToInt32(Console.ReadLine());

// Ask the user to type the second number.
Console.WriteLine("Type another number, and then press Enter");
num2 = Convert.ToInt32(Console.ReadLine());

// Ask the user to choose an option.
Console.WriteLine("Choose an option from the following list:");
Console.WriteLine("Press 1 for SwitchStatement");
Console.WriteLine("Press 2 for IfStatement");
Console.WriteLine("Press 3 for WhileLoop");
Console.WriteLine("Press 4 for DoWhile");
Console.WriteLine("Press 5 for ForLoop");
Console.WriteLine("Press 6 for ForEachLoop");

Console.Write("Your option? ");

var a = Console.ReadLine();
// Use a switch statement to do the math.
switch (a)
{
    case "1":
        SelectStatement.SwitchStatement();
        break;
    case "2":
        SelectStatement.ElseIfStatement(num1, num2);
        break;
    case "3":
        ItterationStatement.whileLoop(num1);
        break;
    case "4":
        ItterationStatement.doWhileLoop(num1);
        break;
    case "5":
        ItterationStatement.forLoop(num1);
        break;
    case "6":
        ItterationStatement.forEachLoop(num1);
        break;   
}

// Wait for the user to respond before closing.
Console.Write("Press any key to close the console app...");
Console.ReadKey();
