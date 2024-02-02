using TicTacToe;

internal class Program
{
    private static void Main(string[] args)
    {
        Driver();
    }

    private static void Driver()
    {

        Support sp = new Support();
        Console.WriteLine("Welcome to our Tic Tac Toe Game!");

        List<string> gameBoard = new List<string>(new string[9]);
        int input = 0;
        int movesCount = 0;
        bool gameOver = false; // Flag to indicate the game should end.

        for (int i = 0; i < 9; i++)
        {
            gameBoard[i] = "_";
        }

        while (movesCount < 9 && !gameOver && sp.GameWinner(gameBoard) == "noWinner") // Check gameOver flag in loop condition.
        {

            bool isValidInput = false;

            while (!isValidInput)
            {
                sp.PrintBoard(gameBoard);

                Console.WriteLine("X, it is your turn! Where would you like to go?");
                bool isNumeric = int.TryParse(Console.ReadLine(), out input);

                if (!isNumeric || input < 0 || input > 8)
                {
                    Console.WriteLine("Please enter a valid spot on the board.");
                    continue;
                }
                else if (gameBoard[input] != "_") // Check if the spot is taken.
                {
                    Console.WriteLine("Please enter a spot that hasn't been used.");
                    continue;
                }

                isValidInput = true;
                gameBoard[input] = "x";
                movesCount++;

                //sp.GameWinner(gameBoard);

                if (movesCount >= 9)
                {
                    gameOver = true; // End the game if board is full
                }
            }

            if (gameOver || sp.GameWinner(gameBoard) != "noWinner") break; // Break out of the loop if the game is over after X's turn.

            bool isValidInput2 = false;

            if (!gameOver && sp.GameWinner(gameBoard) == "noWinner") // Only proceed with O's turn if the game isn't over.
            {
                while (!isValidInput2)
                {
                    sp.PrintBoard(gameBoard);

                    Console.WriteLine("O, it is your turn! Where would you like to go?");
                    bool isNumeric = int.TryParse(Console.ReadLine(), out input);

                    if (!isNumeric || input < 0 || input > 8)
                    {
                        Console.WriteLine("Please enter a valid spot on the board.");
                        continue;
                    }
                    else if (gameBoard[input] != "_") // Check if the spot is taken.
                    {
                        Console.WriteLine("Please enter a spot that hasn't been used.");
                        continue;
                    }

                    isValidInput2 = true;
                    gameBoard[input] = "o";
                    movesCount++;
                    

                    if (movesCount >= 9)
                    {
                        gameOver = true; // End the game if board is full or a win condition is met.
                    }
                }
            }
        }
        Console.WriteLine("Thanks for playing!");
    }
}