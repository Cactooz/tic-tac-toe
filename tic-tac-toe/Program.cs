using System;

namespace tic_tac_toe
{
    class Program
    {
        static void Main(string[] args)
{
            Console.WriteLine("Tic Tac Toe");
            char[,] gameboard = new char[,] {
                {'█', '█', '█' },
                {'█', '█', '█' },
                {'█', '█', '█' }
            };

            gameboard[0, 1] = 'X';
            gameboard[1, 1] = 'O';
            gameboard[1, 2] = 'X';

            Print(gameboard);

        }
        static void Print(char[,] board)
        {
            //Rensa konsollen
            Console.Clear();
            //Skriver ut brädet
            for (int x = 0; x < board.GetLength(0); x++)
            {
                for (int y = 0; y < board.GetLength(1); y++)
                {
                    Console.Write($"{board[x, y]} ");
                }
                Console.WriteLine();
            }
        }
    }
}