/*******************************************************************************************************
Explain the rules of the game of sticks: players will take turns choosing at least 1 and no more than 3*
of the remaining sticks until the sticks are gone.  The player that takes the last stick loses.        *
Set the number of sticks left to 20.                                                                   *
Set the current player to be player 1.                                                                 *
Set the maximum number of sticks that can be taken to be equal to 3.                                   *
If the number of sticks left is less than 3, then set the maximum number of sticks that can be taken to*
be equal to the number of sticks left.
Ask the current player to choose a number of sticks between 1 and the maximum number of sticks that can be taken on this turn.
If the number of sticks chosen is not in the allowed range, print an error message and then go back to step 6; otherwise go on to step 8.
Decrease the number of sticks by the number of sticks chosen.
If the current player is player 1, set current player to be player 2; otherwise set current player to be player 1.
If the number of sticks left is equal to 0, then print that the current player won; otherwise, go back to step 4.
********************************************************************************************************/
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello Players! This is the game sticks you will be allowed to play!");
        rules();
        playGame(playerNames());
    }
    /************************************************************************************************************************
    *rules() will describe the rules to the player
    *
    ************************************************************************************************************************/
    public static void rules()
    {
        Console.WriteLine("The games will go like this, there are 20 sticks on each players turn they will take "+
        "1-3 sticks and in the event there are less then 3 sticks then the number of sticks is the maximum, the player who " +
        "takes the last stick loses");
    }
    /************************************************************************************************************************
    *playerNames() will take the players name and set it to a variable for it to be called later on
    *
    ************************************************************************************************************************/
    public static List<string> playerNames()
    {
        List<string> names = new List<string>{};
        Console.WriteLine("Player one please put in your name.");
        string playerOne = Console.ReadLine();
        Console.WriteLine("Player two please put in your name");
        string playerTwo = Console.ReadLine();
        names.Add(playerOne);
        names.Add(playerTwo);
        return names;
    }
    /************************************************************************************************************************
    *playGame() this is where majority of the code for the game will be, player one will go first followed by player 2.
    *
    ************************************************************************************************************************/
    public static void playGame(List<string> playerName)
    {
        string p1 = playerName[0];
        string p2 = playerName[1];
        //try again is the while loop for if there is an invalid answer
        bool tryAgain = true;
        //continueGame is for if the game hasn't ended yet
        bool continueGame = true;
        //stickCount will be a counter for the number of sticks left
        int stickCount = 20;
        while(continueGame){
            while(tryAgain)
            {
                Console.WriteLine($"{p1} please pick a valid number of sticks to take");
                string p1Answer = Console.ReadLine();
                int p1Int = Convert.ToInt16(p1Answer);
                if(p1Int >= 1 && p1Int <= 3)
                {
                    tryAgain = false;
                    stickCount = stickCount - p1Int;
                }
                else{
                    tryAgain = true;
                    Console.WriteLine("Invalid answer");
                }
            }
            tryAgain = true;
            while(tryAgain)
            {
                Console.WriteLine($"{p2} please pick a valid number of sticks to take");
                string p2Answer = Console.ReadLine();
                int p2Int = Convert.ToInt16(p2Answer);
                if(p2Int >= 1 && p2Int <= 3)
                {
                    tryAgain = false;
                    stickCount = stickCount - p2Int;
                }
                else{
                    tryAgain = true;
                    Console.WriteLine("Invalid answer");
                }
            }
        }
    }
}