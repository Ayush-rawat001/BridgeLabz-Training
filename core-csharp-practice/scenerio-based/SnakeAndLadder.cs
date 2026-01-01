using System;

class SimpleSnakeLadderGame
{
    // Function to get a dice number between 1 and 6
    public static int GetDiceNumber()
    {
        Random randomObj = new Random(); // Making object of Random class
        return randomObj.Next(1, 7); // Giving random value from 1 to 6
    }

    // Function to check if player is on a snake position
    public static int[] VerifySnakeBite(int[,] snakeBoard, int[] playerPoints, int currentTurn)
    {
        for (int index = 0; index < snakeBoard.GetLength(0); index++)
        {
            if (playerPoints[currentTurn] == snakeBoard[index, 0]) // If snake head matches player score
            {
                Console.WriteLine("Oops! Snake caught you at " + snakeBoard[index, 0] + " and dropped to " + snakeBoard[index, 1]);
                playerPoints[currentTurn] = snakeBoard[index, 1]; // Updating score after snake attack
            }
        }
        return playerPoints;
    }

    // Function to check if player got a ladder boost
    public static int[] VerifyLadderClimb(int[,] ladderBoard, int[] playerPoints, int currentTurn)
    {
        for (int index = 0; index < ladderBoard.GetLength(0); index++)
        {
            if (playerPoints[currentTurn] == ladderBoard[index, 0]) // If ladder start matches player score
            {
                Console.WriteLine("Wow! You found ladder at " + ladderBoard[index, 0] + " and reached to " + ladderBoard[index, 1]);
                playerPoints[currentTurn] = ladderBoard[index, 1]; // Updating score after climbing ladder
            }
        }
        return playerPoints;
    }

    // Function to move player based on dice value
    public static int[] UpdatePlayerPosition(int currentTurn, int diceValue, int[] playerPoints)
    {
        if (playerPoints[currentTurn] + diceValue > 100) // If score goes above 100, don't move
        {
            return playerPoints; // Return score without adding dice
        }
        else
        {
            playerPoints[currentTurn] += diceValue; // Adding dice value to score
        }
        return playerPoints;
    }

    // Main starting point of program
    public static void Main(string[] arguments)
    {
        Console.WriteLine("How many players want to play?");
        int totalPlayers = Convert.ToInt32(Console.ReadLine());

        if (totalPlayers < 2 || totalPlayers > 4) // Checking valid number of players
        {
            Console.Error.WriteLine("Only 2 to 4 players are allowed!");
            Environment.Exit(0); // Closing game if input is wrong
        }

        BeginGame(totalPlayers); // Calling function to begin game
    }

    // Function where game runs
    public static void BeginGame(int totalPlayers)
    {
        string[] playerNames = new string[totalPlayers];
        for (int index = 0; index < totalPlayers; index++)
        {
            Console.WriteLine("Write player " + (index + 1) + " name:");
            playerNames[index] = Console.ReadLine();
        }

        int[] playerPoints = new int[totalPlayers]; // Array for player scores

        // Ladder 
        int[,] ladderBoard = {
            {5, 27},
            {9, 51},
            {22, 60},
            {53, 69},
            {44, 78}
        };

        // Snake 
        int[,] snakeBoard = {
            {99, 4},
            {89, 43},
            {13, 7},
            {91, 52},
            {80, 33}
        };

        int currentTurn = 0;

        while (true) // Infinite loop 
        {
            Console.WriteLine(playerNames[currentTurn] + " type 1 to roll dice");
            int inputChoice = Convert.ToInt32(Console.ReadLine());

            if (inputChoice == 1)
            {
                int diceValue = GetDiceNumber(); // Getting dice number
                Console.WriteLine("Dice shows: " + diceValue);

                int previousScore = playerPoints[currentTurn]; // Storing old score

                playerPoints = UpdatePlayerPosition(currentTurn, diceValue, playerPoints); // Moving player
                playerPoints = VerifySnakeBite(snakeBoard, playerPoints, currentTurn); // Checking snake
                playerPoints = VerifyLadderClimb(ladderBoard, playerPoints, currentTurn); // Checking ladder

                int updatedScore = playerPoints[currentTurn];
                Console.WriteLine(previousScore + " --> " + updatedScore);
                Console.WriteLine(playerNames[currentTurn] + " new score is: " + playerPoints[currentTurn]);

                // Checking win condition
                for (int index = 0; index < playerPoints.Length; index++)
                {
                    if (playerPoints[index] >= 100)
                    {
                        Console.WriteLine(playerNames[index] + " won the match!");
                        Environment.Exit(0); // Exiting game after win
                    }
                }

                currentTurn++; // Changing turn
                if (currentTurn > (totalPlayers - 1))
                {
                    currentTurn = 0; // Resetting turn to first player
                }
            }
            else
            {
                Console.WriteLine("Wrong input! Press only 1");
            }
        }
    }
}
