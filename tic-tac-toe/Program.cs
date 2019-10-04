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

            for (int x = 0; x < gameboard.GetLength(0); x++) {
                for (int y = 0; y < gameboard.GetLength(1); y++) {
                    Console.Write(gameboard[x, y]);
                }
                Console.WriteLine();
            }
        }
    }
}