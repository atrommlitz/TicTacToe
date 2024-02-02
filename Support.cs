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

            string legend = "1 2 3 \n 4 5 6 \n 7 8 9";

            for (int i = 0; i < board.Count; i++) 
            {
                Console.WriteLine(board[i]);
                if(i == 2 || i == 5)
                {
                    Console.WriteLine("/n");
                }
            }

            Console.WriteLine(legend);

        }

        public void GameWinner()
        {

            for (int i = 0; i < 3; i++)
            {
                // Check rows
                if (board[i * 3] == board[i * 3 + 1] && board[i * 3 + 1] == board[i * 3 + 2])
                {
                    return board[i * 3];
                }

                // Check columns
                if (board[i] == board[i + 3] && board[i + 3] == board[i + 6])
                {
                    return board[i];
                }
            }

            // Check diagonals
            if (board[0] == board[4] && board[4] == board[8])
            {
                return board[0];
            }

            if (board[2] == board[4] && board[4] == board[6])
            {
                return board[2];
            }

            return -1; // No winner yet
            Console.WriteLine();

        }
    }
}
