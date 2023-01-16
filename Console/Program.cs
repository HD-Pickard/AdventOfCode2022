// See https://aka.ms/new-console-template for more information
using Solutions;

Console.WriteLine("Hello, Advent Of Code 2022");

int selectedDay = ShowMenu();

switch (selectedDay)
{
    case 1:
        SolveDay(new Day1());
        break;
    case 2:
        SolveDay(new Day2());
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

static void SolveDay(IAdventSolver daySolver)
{
    Console.WriteLine("--- Solving Selected Day ---");
    Console.WriteLine($"Part 1: {daySolver.GetPart1Result()}");
    Console.WriteLine($"Part 2: {daySolver.GetPart2Result()}");
}