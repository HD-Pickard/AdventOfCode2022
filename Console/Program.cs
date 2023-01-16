// See https://aka.ms/new-console-template for more information
using Solutions;

Console.WriteLine("Hello, Advent Of Code 2022");

int selectedDay = ShowMenu();

switch (selectedDay)
{
    case 1:
        Console.WriteLine("Solving Day 1");
        Console.WriteLine($"Part 1: {Day1.GetPart1Result()}");
        Console.WriteLine($"Part 2: {Day1.GetPart2Result()}");
        break;


    default:
        break;
}

Console.WriteLine("Reached the end of the solver, bye");
Console.ReadLine();


static int ShowMenu()
{
    Console.WriteLine("Please input the number of the day that you would like to solve...");

    if (int.TryParse(Console.ReadLine(), out int result))
    {
        return result;
    }

    Console.WriteLine("Input not recognised, please try again :(");
    Console.WriteLine();
    return ShowMenu();
}

