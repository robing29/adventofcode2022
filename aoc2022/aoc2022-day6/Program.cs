using Microsoft.VisualBasic;
using System.Text;

///<summary>Data Input</summary>
///
string main = File.ReadAllText(@"..\..\..\..\inputs\day6.txt");

///<summary>Part 1</summary>
///

for(int index = 0; index < main.Length; index++)
{
    var groupOfFour = main.Substring(index, Math.Min(4, main.Length-index)).Distinct();
    if (groupOfFour.Count() == 4)
    {
        string distinctSequence = string.Join("", groupOfFour);
        Console.WriteLine(index+4 + " " + distinctSequence);
        break;
    }
}


///<summary>Part 2</summary>
///

for (int index = 0; index < main.Length; index++)
{
    var groupOfFour = main.Substring(index, Math.Min(14, main.Length - index)).Distinct();
    if (groupOfFour.Count() == 14)
    {
        string distinctSequence = string.Join("", groupOfFour);
        Console.WriteLine(index + 14 + " " + distinctSequence);
        break;
    }
}

Console.ReadLine();
