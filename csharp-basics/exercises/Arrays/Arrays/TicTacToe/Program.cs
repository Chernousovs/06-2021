using System;

namespace TicTacToe
{
    public class Program
    {
        private static char[,] board = new char[3, 3];

        private static void Main(string[] args)
        {
            InitBoard();

            bool isFirstPlayerTurn = true;
            TicTacToeGame possibleGame = new TicTacToeGame();
            Console.WriteLine("TIC TAC TOE\n" +
                              "Game started, good luck!");

            do
            {
                Console.WriteLine(isFirstPlayerTurn ? "It's player X turn" : "It's player O turn");
                int row, col;
                string rowIndex = Console.ReadLine();
                string colIndex = Console.ReadLine();

                if (!int.TryParse(rowIndex, out row) || !int.TryParse(colIndex, out col))
                {
                    Console.WriteLine("Please enter numeric value 0 -> 2");
                    continue;
                }

                if (board[row, col] != ' ')
                {
                    Console.WriteLine("This place is already taken, enter please another coordinates");
                    continue;
                }

                board[row, col] = isFirstPlayerTurn ? 'X' : 'O';

                DisplayBoard();

                possibleGame = CheckIfWinnerExists();
                isFirstPlayerTurn = !isFirstPlayerTurn;

            } while (!possibleGame.IsGameFinished);

            if (possibleGame.IsWinnerDefined)
            {
                Console.WriteLine($"{possibleGame.Winner} is Winner");
            }
            else
            {
                Console.WriteLine("It's DRAW");
            }

            Console.ReadKey();
        }

        private static void InitBoard()
        {
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
            }
        }

        private static void DisplayBoard()
        {
            Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
        }

        private static TicTacToeGame CheckIfWinnerExists()
        {
            var game = new TicTacToeGame
            {
                IsWinnerDefined = false, 
                IsGameFinished = false
            };

            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 0] == board[i, 2] && board[i, 0] != ' ')
                {
                    game.IsWinnerDefined = true;
                    game.IsGameFinished = true;
                    game.Winner = board[i, 0];
                    break;
                } 
                
                if (board[0, i] == board[1, i] && board[0, i] == board[2, i] && board[0, i] != ' ')
                {
                    game.IsWinnerDefined = true;
                    game.IsGameFinished = true;
                    game.Winner = board[0, i];
                    break;
                }
            }

            if (!game.IsGameFinished)
            {
                if (board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2] && board[0, 0] != ' ')
                {
                    game.IsWinnerDefined = true;
                    game.IsGameFinished = true;
                    game.Winner = board[0, 0];
                } 
                else if (board[0, 2] == board[1, 1] && board[0, 2] == board[2, 0] && board[0, 2] != ' ')
                {
                    game.IsWinnerDefined = true;
                    game.IsGameFinished = true;
                    game.Winner = board[0, 2];
                }
            }

            if (!game.IsGameFinished 
                && board[0, 0] != ' ' && board[0, 1] != ' ' && board[0, 2] != ' ' 
                && board[1, 0] != ' ' && board[1, 1] != ' ' && board[1, 2] != ' ' 
                && board[2, 0] != ' ' && board[2, 1] != ' ' && board[2, 2] != ' ')
            {
                game.IsGameFinished = true;
            }

            return game;
        }
    }
}
