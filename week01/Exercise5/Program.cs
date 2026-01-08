using System;
using System.Data;

DisplayWelcome();

string userName = PromptUserName();
int num = PromptUserNumber();

int squareNum = SquareNumber(num);
DisplayResult(userName, squareNum);

static void DisplayWelcome()
{
    Console.Write("Welcome to the program!");
}
static string PromptUserName()
{
    Console.Write("What is your name?");
    string userName = Console.ReadLine();
    return userName;
}

static int PromptUserNumber()
{
    Console.Write("Enter your favorite number: ");
    int num = int.Parse(Console.ReadLine());

    return num;
}

static int SquareNumber(int num)
{
    int square = num * num;
    return square;
}

static void DisplayResult(string userName, int square)
{
    Console.WriteLine($"{userName}, the square root of your number is: {square}");
}
