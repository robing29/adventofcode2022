// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

List<string> strings= new List<string>();
strings = System.IO.File.ReadAllText(@"C:\Users\rgude\source\repos\adventofcode2022\aoc2022\inputs\day1.txt").Split(@"\n\n").ToList();

int maximumCalories = 0;
int thisElfsCalories = 0;

foreach (string s in strings)
{
    
    if (String.IsNullOrEmpty(s))
    {
        if (thisElfsCalories >= maximumCalories)
        {
            maximumCalories = thisElfsCalories;
        }        
        thisElfsCalories = 0;

    } else
    {
        int sInt = int.Parse(s);
        thisElfsCalories += sInt;
    }
    

}

//Part1


Console.ReadLine();

