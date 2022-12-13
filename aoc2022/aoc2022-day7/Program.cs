using aoc2022_day7;
using Microsoft.VisualBasic;

///<summary>Data Input</summary>
///
var input = File.ReadAllLines(@"..\..\..\..\inputs\day7.txt");
//var groups = input.GroupBy(x => x.StartsWith("$ cd"));
List<List<string>> filesystem = new List<List<string>>();

static void TraverseDirectoryTree(Dir root)
{
    // Recursively visit all subdirectories of the current directory
    foreach (var subdir in root.Subdirectories)
    {
        TraverseDirectoryTree(subdir);
    }

    // Calculate the total size of the current directory by summing the sizes of all of its files
    root.TotalSize = root.Files.Sum(file => file.Size);

    // Add the total sizes of the subdirectories of the current directory to the current directory's total size
    root.TotalSize += root.Subdirectories.Sum(subdir => subdir.TotalSize);
}

foreach (var line in input)
{
    if (line.StartsWith("$ cd"))
    {
        var dir = new Dir();
        dir.Name = line.Substring(4);
        dir.Subdirectories = new List<Dir>();
        dir.Files = new List<FileSys>();
        dir.TotalSize = 0;
    }
    if (line.StartsWith("dir"))
    {
        
    }


    //{
    //    filesystem.Add(new List<string>());
    //    filesystem[filesystem.Count - 1].Add(line);
    //}
    //filesystem[filesystem.Count - 1].Add(line);



}




Console.ReadKey();

///<summary>Part 1</summary>
///


///<summary>Part 2</summary>
///

