//A = Rock (Score = 1), B = Paper (2), C = Scissors (3)
//Strategy Guide: X = Rock, Y = Paper, Z = Scissors

//0 Points for losses, 3 for draws, 6 for wins


using System.ComponentModel;

public static class RPS
{
    private static string OpponentObject;
    private static string StrategyGuideObject;

    private static void useRealNames(string Opponent, string StrategyGuide)
    {
        if (Opponent == "A")
        {
            OpponentObject = "Rock";
        }
        else if (Opponent == "B")
        {
            OpponentObject = "Paper";
        }
        else if (Opponent == "C")
        {
            OpponentObject = "Scissors";
        }
        if (StrategyGuide == "X")
        {
            StrategyGuideObject = "Rock";
        }
        else if (StrategyGuide == "Y")
        {
            StrategyGuideObject = "Paper";
        }
        else if (StrategyGuide == "Z")
        {
            StrategyGuideObject = "Scissors";
        }
    }

    private static int calculateScoreForUsingObject(string YourChosenObject)
    {
        if (YourChosenObject == "Rock")
        {
            return 1;
        }
        if (YourChosenObject == "Paper")
        {
            return 2;
        }
        if (YourChosenObject == "Scissors")
        {
            return 3;
        }
        return 0;
    }
    public static int calculateScore(string Op1, string Str1)
    {
        useRealNames(Op1,Str1);
        int outcomeScore = 0;

        if (OpponentObject == StrategyGuideObject)
        {
            //Drawing outcomes
            outcomeScore = 3;
            outcomeScore += calculateScoreForUsingObject(StrategyGuideObject);
        } else if ((StrategyGuideObject == "Rock" && OpponentObject == "Paper") || (StrategyGuideObject == "Paper" && OpponentObject == "Scissors") || (StrategyGuideObject == "Scissors" && OpponentObject == "Rock")){
            //Losing outcomes
            outcomeScore = 0;
            outcomeScore += calculateScoreForUsingObject(StrategyGuideObject);
        } else if ((StrategyGuideObject == "Rock" && OpponentObject == "Scissors") || (StrategyGuideObject == "Paper" && OpponentObject == "Rock") || (StrategyGuideObject == "Scissors" && OpponentObject == "Paper")){
            //Winning outcomes
            outcomeScore = 6;
            outcomeScore += calculateScoreForUsingObject(StrategyGuideObject);
        }
        return outcomeScore;
    }
}