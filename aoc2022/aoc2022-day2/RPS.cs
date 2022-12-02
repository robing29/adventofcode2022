//A = Rock (Score = 1), B = Paper (2), C = Scissors (3)
//Strategy Guide: X = Rock, Y = Paper, Z = Scissors

//0 Points for losses, 3 for draws, 6 for wins
//Strategy Guide: X = Lose, Y = Draw, Z = Win


using System.ComponentModel;

public static class RPS
{
    private static string OpponentObject;
    private static string StrategyGuideObject;

    private static string useRealNamesForObjects(string codedObject)
    {
        if (codedObject == "A" || codedObject == "X")
        {
            return "Rock";
        }
        else if (codedObject == "B" || codedObject == "Y")
        {
            return "Paper";
        }
        else if (codedObject == "C" || codedObject == "Z")
        {
            return "Scissors";
        }
        return ("Fehler");
    }
    private static string useRealNamesForOutcomes(string codedOutcomes)
    {
        if (codedOutcomes == "X")
        {
            return "Loss";
        }
        else if (codedOutcomes == "Y")
        {
            return "Draw";
        }
        else if (codedOutcomes == "Z")
        {
            return "Win";
        }
        return ("Fehler");
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
    public static int calculateScore(string OpponentsChoice, string StrategyGuidesChoice)
    {
        OpponentObject = useRealNamesForObjects(OpponentsChoice);
        StrategyGuideObject = useRealNamesForObjects(StrategyGuidesChoice);
        int outcomeScore = 0;

        if (OpponentObject == StrategyGuideObject)
        {
            //Drawing outcomes
            outcomeScore = 3;
            outcomeScore += calculateScoreForUsingObject(StrategyGuideObject);
        }
        else if ((StrategyGuideObject == "Rock" && OpponentObject == "Paper") || (StrategyGuideObject == "Paper" && OpponentObject == "Scissors") || (StrategyGuideObject == "Scissors" && OpponentObject == "Rock"))
        {
            //Losing outcomes
            outcomeScore = 0;
            outcomeScore += calculateScoreForUsingObject(StrategyGuideObject);
        }
        else if ((StrategyGuideObject == "Rock" && OpponentObject == "Scissors") || (StrategyGuideObject == "Paper" && OpponentObject == "Rock") || (StrategyGuideObject == "Scissors" && OpponentObject == "Paper"))
        {
            //Winning outcomes
            outcomeScore = 6;
            outcomeScore += calculateScoreForUsingObject(StrategyGuideObject);
        }
        return outcomeScore;
    }

    public static int calculateScoreBasedOnDesiredOutcome(string SecretStrategyGuidesChoice)
    {
        int desiredOutcomescore = 0;
        if (SecretStrategyGuidesChoice == "X")
        {
            //Loss
            return desiredOutcomescore = 0;
        } else if (SecretStrategyGuidesChoice == "Y")
        {
            return desiredOutcomescore = 3;
        } else if (SecretStrategyGuidesChoice == "Z")
        {
            return desiredOutcomescore = 6;
        }
         
        return 0;
    }
    public static string whichObjectBasedOnOutcome(string OpponentsChoice, string SecretStrategyGuidesChoice)
    {
        OpponentObject = useRealNamesForObjects(OpponentsChoice);
        string outcome = useRealNamesForOutcomes(SecretStrategyGuidesChoice);
        string returnValue = "";
        if((OpponentObject == "Rock" && outcome == "Draw") || (OpponentObject == "Scissors" && outcome == "Win") || (OpponentObject == "Paper" && outcome == "Loss"))
        {
            //All Rock returns
            returnValue = "X";
        } else if ((OpponentObject == "Paper" && outcome == "Draw") || (OpponentObject == "Rock" && outcome == "Win") || (OpponentObject == "Scissors" && outcome == "Loss"))
        {
            //All Paper returns
            returnValue = "Y";
        }
        else if ((OpponentObject == "Scissors" && outcome == "Draw") || (OpponentObject == "Paper" && outcome == "Win") || (OpponentObject == "Rock" && outcome == "Loss"))
        {
            //All Scissors returns
            returnValue = "Z";
        }
        return returnValue;
    }

    public static int calculateSuperSecretScore(string OpponentsChoice, string SecretStrategyGuidesChoice)
    {
        int superSecretscore = 0;
        superSecretscore += calculateScoreBasedOnDesiredOutcome(SecretStrategyGuidesChoice);


        return 0;
    }
}