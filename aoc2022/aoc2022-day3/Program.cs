//Data Input

using System.Runtime.InteropServices;

List<string> list = new List<string>();
list = File.ReadAllLines(@"..\..\..\..\inputs\day3.txt").ToList();

Dictionary<char, int> itemPriorities = new Dictionary<char, int>();

//Großbuchstaben
int bigalphabet = 27;
int ascii = 65;

while (ascii <= 90 && bigalphabet <= 52)
{
    itemPriorities.Add((char)ascii, bigalphabet);
    bigalphabet++;
    ascii++;
}


//Kleinbuchstaben
int smallalphabet = 1;
ascii = 97;

while (ascii <= 122 && smallalphabet <= 26)
{
    itemPriorities.Add((char)ascii, smallalphabet);
    smallalphabet++;
    ascii++;
}

//foreach (KeyValuePair<char,int> kvp in itemPriorities)
//{
//    Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
//}

//Part1

//Create Dictionary with values for characters


//Step1: Define length of string
//Step2: Split strings in middle
int sumOfItemPriorities = 0;

foreach (string line in list)
{
    string firstpart = line.Substring(0,line.Length/2-1);
    string secondpart = line.Substring(line.Length/2);

    //length = 44, /2 = 22, -1 = startindex

    char item;


    
    for (int counter = 0; counter <= firstpart.Length-1; counter++)
    {
        for (int counter2 = 0; counter2 <= secondpart.Length-1; counter2++)
        {
            char test2 = secondpart[counter2];
            if (firstpart[counter].Equals(secondpart[counter2]) == true)
            {
                item = firstpart[counter];
                sumOfItemPriorities += itemPriorities[item];
                Console.WriteLine(sumOfItemPriorities);
            }            
        }
    }
    
}

Console.WriteLine("Insgesamt: " + sumOfItemPriorities);

//Step3: See if letter is contained in second part (For Loop with index and asking whether "equals"?)
//Step4: Add Value of this letter to variable
//Step5: Map a-z to 1 to 26 and A-Z to 27 to 52 (ANSI Code?)
//Step6: Output the value



//Part2