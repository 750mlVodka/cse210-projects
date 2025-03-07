using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int ResultNumber = SquareNumber(number);
        DisplayResult(name, ResultNumber);
    }

    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName(){
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber(){
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number){
        return number * number;
    }

    static void DisplayResult(string name, int ResultNumber){
        Console.WriteLine($"Brtoher {name}, the square of your number is {ResultNumber}");
    }
}
