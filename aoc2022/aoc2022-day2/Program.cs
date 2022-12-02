//Data Entry

List<string> strings = new List<string>();
strings = System.IO.File.ReadAllLines(@"..\..\..\..\inputs\day2.txt").ToList();

//Part1
//A = Rock (Score = 1), B = Paper (2), C = Scissors (3)
//Strategy Guide: X = Rock, Y = Paper, Z = Scissors

string[] matchup = { "", "" };

int totalScore = 0;
foreach(string s in strings)
{
    matchup = s.Split(null);
    totalScore += RPS.calculateScore(matchup[0], matchup[1]);
}

Console.WriteLine("Total Score = " + totalScore);


//Part2

Console.ReadKey();
