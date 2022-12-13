using Microsoft.VisualBasic;

///<summary>Data Input</summary>
///
var input = File.ReadAllLines(@"..\..\..\..\inputs\day7.txt");
//var groups = input.GroupBy(x => x.StartsWith("$ cd"));
List<List<string>> filesystem = new List<List<string>>();


foreach (var line in input)
{
    if (line.StartsWith("$ cd"))
    {
        filesystem.Add(new List<string>());
        filesystem[filesystem.Count-1].Add(line);
        
    }
    else
    {
        filesystem[filesystem.Count - 1].Add(line);
    }
}

foreach (List<string> test in filesystem)
{
    foreach (string str in test)
    {
        Console.WriteLine(str);
    }
}
Console.ReadKey();

///<summary>Part 1</summary>
///


///<summary>Part 2</summary>
///

