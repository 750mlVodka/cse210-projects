using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int list_number = -1;
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (list_number != 0){
            Console.Write("Enter number: ");
            list_number = int.Parse(Console.ReadLine());

            if (list_number !=0){
                numbers.Add(list_number);
            }
        }

        int sum = 0;
        foreach (int number in numbers){
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = int.MinValue;
        foreach (int number in numbers)
        {
            if (number > max){
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
    }
}