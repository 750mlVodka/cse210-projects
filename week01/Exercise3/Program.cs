using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int magic_number = random.Next(1, 101);
        int guess = 0;

        Console.WriteLine($"What is the magic number? {magic_number}");

        while (guess != magic_number){
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magic_number){
                Console.WriteLine("Higher");
            }
            else if(guess > magic_number){
                Console.WriteLine("Lower");
            }

            else{
                Console.WriteLine("You guessed it!");
            }
        }
    }
}