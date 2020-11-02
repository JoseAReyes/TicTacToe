using System;
using System.Security.Cryptography.X509Certificates;

namespace TicTacToe
{
   class Program
   {
      public static void Main(string[] args)
      {
         char[,] board = new char[3, 3] { { ' ', ' ', ' ' },
                                          { ' ', ' ', ' ' },
                                          { ' ', ' ', ' ' } };
         Console.WriteLine("Let' play Tic Tac Toe!");
         PrintArr(board);

         for (int i = 0; i < board.Length; i++)
         {
            if (i % 2 == 0)
            {
               playerTurn("Player1", 'X', board);
               bool player1Won = CheckForWin(board, 'X', "Player1");
               if (player1Won == true)
                  break;
               else
                  continue;
            }
            else
            {
               playerTurn("Player2", 'O', board);
               bool player2Won = CheckForWin(board, 'O', "Player2");
               if (player2Won == true)
                  break;
               else
                  continue;
            }
         }
      }
      static bool CheckForWin(char[,] board, char c, string player)
      {
         bool playerWins = false;
         if ((board[0, 0] == c && board[1, 0] == c && board[2, 0] == c) ||
             (board[0, 0] == c && board[0, 1] == c && board[0, 2] == c) ||
             (board[0, 2] == c && board[1, 2] == c && board[2, 2] == c) ||
             (board[2, 0] == c && board[2, 1] == c && board[2, 2] == c) ||
             (board[2, 0] == c && board[1, 1] == c && board[0, 2] == c) ||
             (board[0, 0] == c && board[1, 1] == c && board[2, 2] == c) ||
             (board[0, 1] == c && board[1, 1] == c && board[2, 1] == c) ||
             (board[1, 0] == c && board[1, 1] == c && board[1, 2] == c))
         {
            Console.WriteLine(player + " Wins!");
            playerWins = true;
         }
         return playerWins;
      }
      static void playerTurn(string player, char c, char[,] board)
      {
         bool spaceTaken = true;
         while (spaceTaken == true)
         {
            Console.Write("\n" + player + ", Where would you like to move? ");
            string location = Console.ReadLine();
            spaceTaken = LocationAssig(board, location, c);
            PrintArr(board);
         }
      }
      static void PrintArr(char[,] arr)
      {
         Console.WriteLine(" ");
         Console.WriteLine("\t  1  2  3");
         Console.WriteLine("\ta" + "[" + arr[0, 0] + "]" + "[" + arr[0, 1] + "]" + "[" + arr[0, 2] + "]");
         Console.WriteLine("\tb" + "[" + arr[1, 0] + "]" + "[" + arr[1, 1] + "]" + "[" + arr[1, 2] + "]");
         Console.WriteLine("\tc" + "[" + arr[2, 0] + "]" + "[" + arr[2, 1] + "]" + "[" + arr[2, 2] + "]\n");
      }
      static bool LocationAssig(char[,] arr, string location, char c)
      {
         bool spaceTaken = false;
         if (location == "a1" || location == "1a")
         {
            if (arr[0, 0] == ' ')
               arr[0, 0] = c;
            else
            {
               Console.WriteLine("\nThis space is filled, choose another.");
               spaceTaken = true;
            }
         }
         else if (location == "a2" || location == "2a")
         {
            if (arr[0, 1] == ' ')
               arr[0, 1] = c;
            else
            {
               Console.WriteLine("\nThis space is filled, choose another.");
               spaceTaken = true;
            }
         }
         else if (location == "a3" || location == "3a")
         {
            if (arr[0, 2] == ' ')
               arr[0, 2] = c;
            else
            {
               Console.WriteLine("\nThis space is filled, choose another.");
               spaceTaken = true;
            }
         }
         else if (location == "b1" || location == "1b")
         {
            if (arr[1, 0] == ' ')
               arr[1, 0] = c;
            else
            {
               Console.WriteLine("\nThis space is filled, choose another.");
               spaceTaken = true;
            }
         }
         else if (location == "b2" || location == "2b")
         {
            if (arr[1, 1] == ' ')
               arr[1, 1] = c;
            else
            {
               Console.WriteLine("\nThis space is filled, choose another.");
               spaceTaken = true;
            }
         }
         else if (location == "b3" || location == "3b")
         {
            if (arr[1, 2] == ' ')
               arr[1, 2] = c;
            else
            {
               Console.WriteLine("\nThis space is filled, choose another.");
               spaceTaken = true;
            }
         }
         else if (location == "c1" || location == "1c")
         {
            if (arr[2, 0] == ' ')
               arr[2, 0] = c;
            else
            {
               Console.WriteLine("\nThis space is filled, choose another.");
               spaceTaken = true;
            }
         }
         else if (location == "c2" || location == "2c")
         {
            if (arr[2, 1] == ' ')
               arr[2, 1] = c;
            else
            {
               Console.WriteLine("\nThis space is filled, choose another.");
               spaceTaken = true;
            }
         }
         else if (location == "c3" || location == "3c")
         {
            if (arr[2, 2] == ' ')
               arr[2, 2] = c;
            else
            {
               Console.WriteLine("\nThis space is filled, choose another.");
               spaceTaken = true;
            }
         }
         else
         {
            Console.WriteLine("\nNot a valid entry.\nKey the letter of the desired row: a, b, or c \n" +
               "followed by the number of the desired column: 1, 2 or 3 \nwith no space in between. " +
               "For example, row \"a\" and column \"1\" is: a1 .");
            spaceTaken = true;
         }
         return spaceTaken;
      }
   }
}
