//Data Entry
using aoc2022_day4;

List<string> strings= new List<string>();
strings = File.ReadAllLines(@"..\..\..\..\inputs\day4.txt").ToList();

int counterForContainment = 0;
int counterForOverlap = 0;
foreach (string line in strings)
{
    var a = line.Split(',');
    var firsthalf = a[0].Split('-');
    int.TryParse(firsthalf[0], out int result1);
    int.TryParse(firsthalf[1], out int result2);
    int[] firstpart = { result1, result2 };

    var secondhalf = a[1].Split('-');
    int.TryParse(secondhalf[0], out int result3);
    int.TryParse(secondhalf[1], out int result4);
    int[] secondpart = { result3, result4};

    

    if(Cleanup.CheckRange(secondpart, firstpart)){
        counterForContainment++;
    }
    if(Cleanup.CheckOverlap(secondpart, firstpart))
    {
        counterForOverlap++;
    }

}

Console.WriteLine("Task 1: " + counterForContainment);
Console.WriteLine("Task 2: " + counterForOverlap);
//2-4,6-8
//2 - 3,4 - 5
//5 - 7,7 - 9
//2 - 8,3 - 7
//6 - 6,4 - 6
//2 - 6,4 - 8
Console.ReadLine();