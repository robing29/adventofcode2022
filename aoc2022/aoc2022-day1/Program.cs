using System.Collections.Generic;

//Data Entry

List<string> strings= new List<string>();
strings = System.IO.File.ReadAllLines(@"..\..\..\..\inputs\day1.txt").ToList();


//Part1

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
Console.WriteLine("Maximum calories carried by one elf: " + maximumCalories);

//Part2
int[] topThreeElves = { 0, 0, 0 };

thisElfsCalories = 0;

foreach (string s in strings)
{
    if (String.IsNullOrEmpty(s))
    {
        if (thisElfsCalories >= topThreeElves[0])
        {
            topThreeElves[2] = topThreeElves[1];
            topThreeElves[1] = topThreeElves[0];
            topThreeElves[0] = thisElfsCalories;
        }
        else if (thisElfsCalories >= topThreeElves[1])
        {
            topThreeElves[2] = topThreeElves[1];
            topThreeElves[1] = thisElfsCalories;
        }
        else if (thisElfsCalories >= topThreeElves[2])
        {
            topThreeElves[2] = thisElfsCalories;
        }
        Console.WriteLine("Log: " + thisElfsCalories);
        thisElfsCalories = 0;

    }
    else
    {
        int sInt = int.Parse(s);
        thisElfsCalories += sInt;
    }
}

Console.WriteLine("Top1: " + topThreeElves[0]);
Console.WriteLine("Top2: " + topThreeElves[1]);
Console.WriteLine("Top3: " + topThreeElves[2]);
Console.WriteLine("Top3 together: " + topThreeElves.Sum());

Console.ReadLine();

