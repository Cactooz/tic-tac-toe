using System;

namespace tic_tac_toe
{
    class Program
    {
        static void Main(string[] args)
{
            Console.WriteLine("Tic Tac Toe");
            char[] gameboard = { '█', '█', '█', '█', '█', '█', '█', '█', '█' };

            gameboard[0] = 'X';
            gameboard[1] = 'O';
            gameboard[2] = 'X';

            Print(gameboard);

        }
        static void Print(char[] board)
        {
            //Rensa konsollen
            Console.Clear();
            //Skriver ut brädet
            Console.WriteLine($"{board[0]} | {board[1]} | {board[2]}");
            Console.WriteLine("——————————");
            Console.WriteLine($"{board[3]} | {board[4]} | {board[5]}");
            Console.WriteLine("——————————");
            Console.WriteLine($"{board[6]} | {board[7]} | {board[8]}");
        }
    }
}