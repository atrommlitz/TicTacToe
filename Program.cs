internal class Program
{
    private static void Driver()
    {
        Console.WriteLine("Welcome to our Tic Tac Toe Game!");

        print

        string[] gameBoard = new string[9];
        bool gameOver = false;
        int input = 0;

        for (int i = 0; i < gameBoard.Length; i++)
        {
            gameBoard[i] = "_";
        }

        for (int i = 0; i < gameBoard.Length; i++)
        {
            Console.WriteLine("X, it is your turn! Where would you like to go?");
            input = Console.ReadLine();
            gameBoard[input] = "X";
        }
    }
}