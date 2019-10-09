using System;

namespace tic_tac_toe
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] mainBoard = { '█', '█', '█', '█', '█', '█', '█', '█', '█' };

            Menu(mainBoard);
        }

        //Main menu
        static void Menu(char[] menuBoard)
        {
            Reset(menuBoard);
            Console.Clear();
            Console.WriteLine("Tic Tac Toe\n");
            Console.WriteLine("To start playing type PLAY\nTo see the tutorial type TUTORIAL");
            string startStatus = "";
            while (startStatus != "play" || startStatus != "tutorial") {
                string start = Console.ReadLine();
                startStatus = start.ToLower();
                    if (startStatus == "play")
                        Game(menuBoard);
                    else if (startStatus == "tutorial")
                        Tutorial(menuBoard);
                    else if (startStatus == "exit")
                        Environment.Exit(0);
            }
        }

        //Runs the game
        static void Game(char[] gameBoard)
        {
            char player = 'X';
            int turn = 0;
            while (turn < 9) {
                if (turn % 2 == 0)
                    player = 'X';
                else
                    player = 'O';
                turn++;
                Print(gameBoard);
                Console.WriteLine($"Turn: {turn}");
                Console.WriteLine($"It's {player}'s turn\n");
                Console.Write("Place: ");
                int location = int.Parse(Console.ReadLine());
                if (location < 10) {
                    if (gameBoard[location-1] != 'O' && gameBoard[location-1] != 'X') {
                        gameBoard[location-1] = player;
                        Print(gameBoard);
                    }
                    else {
                        Console.WriteLine("This place is already taken.");
                        System.Threading.Thread.Sleep(3000); //Wait for 3 seconds
                        turn--;
                    }
                }
                else {
                    Console.WriteLine("You can only choose between 1-9!");
                    System.Threading.Thread.Sleep(3000); //Wait for 3 seconds
                    turn--;
                }
                if (turn >= 5) {
                    CheckWin(gameBoard);
                    if (CheckWin(gameBoard) > 0) {
                        Console.WriteLine($"Player {player} has won the game!\n");
                        Console.WriteLine(CheckWin(gameBoard));
                        Console.WriteLine("Write MENU to get back to main menu.");
                        string answer = Console.ReadLine();
                        string menu = answer.ToLower();
                        if (menu == "menu")
                            Menu(gameBoard);
                    }
                }
            }
            Console.WriteLine("It's a DRAW...");
            System.Threading.Thread.Sleep(3000); //Wait for 3 seconds
            Menu(gameBoard);
        }

        //Tutorial
        static void Tutorial(char[] tutorialBoard)
        {
            Console.Clear();
            Console.WriteLine("Welcome to Tic Tac Toe!");
            Console.WriteLine("This is a two player game where you plays X's or O's.");
            Console.WriteLine("This is the game board:\n");
            Console.WriteLine("1 | 2 | 3");
            Console.WriteLine("—————————");
            Console.WriteLine("4 | 5 | 6");
            Console.WriteLine("—————————");
            Console.WriteLine("7 | 8 | 9\n");
            Console.WriteLine("When playing type the number where you want to place your X or O.\n");
            Console.WriteLine("Done reading? Type DONE to get back to the main menu!");
            string done = "";
            while (done != "done") {
                string answer = Console.ReadLine();
                done = answer.ToLower();
                if (done == "done")
                    Menu(tutorialBoard);
            }
        }

        //Prints the gameboard
        static void Print(char[] printBoard)
        {
            //Clear the console
            Console.Clear();
            //Write out the gameboard
            Console.WriteLine("Tic Tac Toe\n");
            Console.WriteLine($"{printBoard[0]} | {printBoard[1]} | {printBoard[2]}");
            Console.WriteLine("—————————");
            Console.WriteLine($"{printBoard[3]} | {printBoard[4]} | {printBoard[5]}");
            Console.WriteLine("—————————");
            Console.WriteLine($"{printBoard[6]} | {printBoard[7]} | {printBoard[8]}\n");
        }

        //Check if someone has won
        static int CheckWin(char[] resultBoard)
        {
            //Check for top horizontal row
            if (resultBoard[0] == resultBoard[1] && resultBoard[1] == resultBoard[2] && resultBoard[0] == resultBoard[2])
                return 1;
            //Check for middle horizontal row
            else if (resultBoard[3] == resultBoard[4] && resultBoard[4] == resultBoard[5] && resultBoard[3] == resultBoard[5])
                return 2;
            //Check for bottom horizontal row
            /*else if (resultBoard[6] == resultBoard[7] && resultBoard[7] == resultBoard[8] && resultBoard[6] == resultBoard[8])
                return 3;*/
            //Check for left vertical row
            else if (resultBoard[0] == resultBoard[3] && resultBoard[3] == resultBoard[6] && resultBoard[0] == resultBoard[6])
                return 4;
            //Check for middle vertical row
            else if (resultBoard[1] == resultBoard[4] && resultBoard[4] == resultBoard[7] && resultBoard[1] == resultBoard[7])
                return 5;
            //Check for right vertical row
            /*else if (resultBoard[2] == resultBoard[5] && resultBoard[5] == resultBoard[8] && resultBoard[2] == resultBoard[8])
                return 6;*/
            //Check for diagonal top left to bottom right \
            else if (resultBoard[0] == resultBoard[4] && resultBoard[4] == resultBoard[8] && resultBoard[0] == resultBoard[8])
                return 7;
            //Check for diagonal top right to bottom left /
            else if (resultBoard[2] == resultBoard[4] && resultBoard[4] == resultBoard[6] && resultBoard[2] == resultBoard[6])
                return 8;
            else
                return 0;
        }

        //Reset board to normal characters
        static void Reset(char[] resetBoard)
        {
            for (int i = 0; i<resetBoard.Length; i++)
                resetBoard[i] = '█';
        }
    }
}
