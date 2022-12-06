//Data Input & Preparation

List<string> list = new List<string>();
list = File.ReadAllLines(@"..\..\..\..\inputs\day3.txt").ToList();

Dictionary<char, int> itemPriorities = new Dictionary<char, int>();

//Capital letters
int bigalphabet = 27;
int ascii = 65;

while (ascii <= 90 && bigalphabet <= 52)
{
    itemPriorities.Add((char)ascii, bigalphabet);
    bigalphabet++;
    ascii++;
}


//Small letters
int smallalphabet = 1;
ascii = 97;

while (ascii <= 122 && smallalphabet <= 26)
{
    itemPriorities.Add((char)ascii, smallalphabet);
    smallalphabet++;
    ascii++;
}

int sumOfItemPriorities = 0;

bool checkCommon(string part1, string part2, char item)
{
    for (int counter = 0; counter < part1.Length; counter++)
    {
        char test1 = part1[counter];
        for (int counter2 = 0; counter2 < part1.Length; counter2++)
        {
            char test2 = part2[counter2];
            if (part1[counter].Equals(part2[counter2]) == true)
            {
                item = part1[counter];
                Console.WriteLine(item);
                sumOfItemPriorities += itemPriorities[item];
                Console.WriteLine(sumOfItemPriorities);
                return true;
            }
        }
    }
    return false;
}

foreach (string line in list)
{
    string firstpart = line.Substring(0, line.Length / 2);
    string secondpart = line.Substring(line.Length / 2);

    char item = 'a';

    checkCommon(firstpart, secondpart, item);

}

Console.WriteLine("Insgesamt: " + sumOfItemPriorities);
Console.WriteLine("Durchschnitt pro line: " + sumOfItemPriorities / list.Count);

List<List<string>> listoflists = new List<List<string>>();

//Part2
int groupsum = 0;
for (int groupCounter = 0; groupCounter < list.Count; groupCounter += 3)
{
    var a = list.GetRange(groupCounter, 3);
    Console.WriteLine(a[0]);
    Console.WriteLine(a[1]);
    Console.WriteLine(a[2]);
    List<char> chars = new List<char>();
    for (int i = 0; i < a[1].Length; i++)
    {
        if (a[0].Contains(a[1][i]))
        {
            chars.Add(a[1][i]);
        }
    }
    char uniqueChar = '0';
    bool test = false;

    for (int counter = 0; counter < chars.Count; counter++)
    {

        if (a[2].Contains(chars[counter]))
        {
            uniqueChar = chars[counter];
            Console.WriteLine(uniqueChar + " its value " + itemPriorities[uniqueChar]);
            groupsum += itemPriorities[uniqueChar];
            break;
        }
    }

    //listoflists.Add(a);    
}

Console.WriteLine("Summe aller Gruppenprios: " + groupsum);
//foreach (List<string> sublist in listoflists)
//{
//    Console.WriteLine("Gruppe");
//    foreach (string s in sublist)
//    {
//        Console.WriteLine(s);
//    }
//}
//list.Distinct
//CompareTo() potenziell wertvoll?
//.Contains() sinnvoll. Ein For-Loop, mit dem jeder Buchstabe mit dem anderen String verglichen wird. Alle wahren Werte werden in eine Liste geschrieben. In dieser Liste wird dann erneut iteriert, ob Schnittmenge mit Part 3 übereinstimmt.
//Schnittmenge aus 1 und 2 bilden, diese Schnittmenge dann mit 3 vergleichen.


Console.ReadKey();