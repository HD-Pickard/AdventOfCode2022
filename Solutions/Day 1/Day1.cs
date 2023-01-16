using System.Net;
using System.Net.WebSockets;

namespace Solutions
{
    //Advent Link: https://adventofcode.com/2022/day/1
    public static class Day1{ 
    
        public static int GetPart1Result()
        {
            return GetTotalCaloriesPerElf().Max();
        }
        public static int GetPart2Result() 
        {
            var orderedCalories = GetTotalCaloriesPerElf().OrderByDescending(x=>x).ToList();
            return orderedCalories[0] + orderedCalories[1] + orderedCalories[2];
        }

        private static List<int> GetTotalCaloriesPerElf()
        {
            var calorieRows = File.ReadLines("Day 1/Day1Data.txt").ToList();

            List<int> totalCaloriesForEachElf = new List<int>();
            int currentElfCalories = 0;

            foreach (var item in calorieRows)
            {
                if (item != "")
                {
                    currentElfCalories += int.Parse(item);
                }
                else
                {
                    totalCaloriesForEachElf.Add(currentElfCalories);
                    currentElfCalories = 0;
                }
            }

            return totalCaloriesForEachElf;
        }
    }
}