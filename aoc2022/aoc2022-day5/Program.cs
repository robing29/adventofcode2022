using aoc2022_day5;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
///<summary>Data Input</summary>
///
List<string> uneditedList = File.ReadAllLines(@"..\..\..\..\inputs\day5.txt").ToList();

List<List<string>> grid = new List<List<string>>();
var commands = uneditedList.Where(x => x.StartsWith("move"));

int columnCounter = 0;

for (int substringCounter = 0; substringCounter < uneditedList[0].Length; substringCounter += 4)
{
    grid.Add(new List<string>());
    for (int rowCounter = 0; rowCounter < 8; rowCounter++)
    {
        grid[columnCounter].Add(uneditedList[rowCounter].Substring(substringCounter, 3).Trim());
    }
    columnCounter++;
}
grid = grid.Select(x => x.Where(s => !string.IsNullOrEmpty(s)).ToList()).ToList();


///<summary>Part 1</summary>
///

//foreach (string s in commands)
//{

//    Command.MoveStack(grid, s);
//}
//Console.WriteLine(Command.EndStack(grid));

///<summary>Part 2</summary>
///

foreach (string s in commands)
{

    Command.MoveStack9001(grid, s);
}
Console.WriteLine(Command.EndStack(grid));

