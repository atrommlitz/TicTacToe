using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace TicTacToe
{
    internal class Support
    {
        //The supporting class (with whichever name you choose) will:
        //Receive the “board” array from the driver class
        //Contain a method that prints the board based on the information passed to it
        //Contain a method that receives the game board array as input and returns if there is a
        //winner and who it was

        public void PrintBoard(List<string> board)
        {
            string legend = "0 1 2 \n3 4 5 \n6 7 8";
            for (int i = 0; i < board.Count; i++) 
            {
                Console.Write(board[i]);
                Console.Write(" ");
                if (i == 2 || i == 5 || i == 8)
                {
                    Console.Write("\n");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Legend:");
            Console.WriteLine(legend);
            Console.WriteLine();
        }

        // method
        public string GameWinner(List<string> board)
        {
            bool gameOver = false;
            int spotToCheck = 0;
            string winner = "noWinner";

            for (int i = 0; i < 3; i++)
            {
                // Check rows if the first spot in row isnt a dash
                if (board[i * 3] != "_")
                {
                    if (board[i * 3] == board[i * 3 + 1] && board[i * 3 + 1] == board[i * 3 + 2])
                    {
                        gameOver = true;
                        spotToCheck = i * 3;
                    }
                }

                // Check columns if the first spot in the column isnt a dash
                if (board[i] != "_")
                {
                    if (board[i] == board[i + 3] && board[i + 3] == board[i + 6])
                    {
                        gameOver = true;
                        spotToCheck = i;
                    }
                }
            }

            // Check diagonals if the first spot isnt a dash
            if (board[0] != "_")
            {
                if (board[0] == board[4] && board[4] == board[8])
                {
                    gameOver = true;
                    spotToCheck = 0;
                }
            }

            if (board[2] != "_")
            {
                if (board[2] == board[4] && board[4] == board[6])
                {
                    gameOver = true;
                    spotToCheck = 2;
                }
            }

            // check which player won
            if (gameOver == true)
            {
                if (board[spotToCheck] == "x")
                {
                    Console.WriteLine("Congrats Player X, that's a dub.");
                    for (int i = 0; i < board.Count; i++)
                    {
                        Console.Write(board[i]);
                        Console.Write(" ");
                        if (i == 2 || i == 5 || i == 8)
                        {
                            Console.Write("\n");
                        }
                    }
                    winner = "PlayerX";
                }
                else if (board[spotToCheck] == "o")
                {
                    Console.WriteLine("Congrats Player O, that's a dub.");
                    for (int i = 0; i < board.Count; i++)
                    {
                        Console.Write(board[i]);
                        Console.Write(" ");
                        if (i == 2 || i == 5 || i == 8)
                        {
                            Console.Write("\n");
                        }
                    }
                    winner = "PlayerO";
                }
            }
            return winner;
        }
    }
}
