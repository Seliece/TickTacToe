using System;

namespace TickTacToe
{
    class Program
    {
        #region Variables
        static char[] BoardList = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
        static int flag = 0;
        static int player = 1;
        static char playerSign;
        #endregion

        static void Main(string[] args) 
        {
            while (flag == 0)
            {
                //Choose player
                do {
                Found:     
                    Console.Clear();
                    Console.WriteLine("Player 1: \"X\" , Player 2: \"O\"");
                        if (player % 2 == 1) {
                            Console.WriteLine("Current Player: X");
                            playerSign = 'X';

                        } else {
                            Console.WriteLine("Current Player: O");
                            playerSign = 'O';
                        }

                        Board();
                    string RawInput = Console.ReadLine();
                    if (RawInput.Length != 1) {
                        Console.WriteLine("Use only 1 charachter");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey(true);
                        goto Found;
                    }

                    Char Input = Char.Parse(RawInput);

                    int ArrayList = Array.IndexOf(BoardList, Input);
                    
                    if ((ArrayList == -1) || (Input == 'X' || Input == 'O' || Input == '0')) {
                        Console.WriteLine("Not a valid option, please choose only one of the avaliable options");
                        Console.WriteLine("You can only use one of the remaining numbers");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey(true);
                        goto Found;
                    } else {
                        BoardList[ArrayList] = playerSign;
                        player++;
                    }

                    WhoWon();


                } while (true);



            }
        }

        //Board Fuction
        static void Board()
        {
            Console.WriteLine("     |     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  |  {3}  ", BoardList[1], BoardList[2], BoardList[3], BoardList[4]);
            Console.WriteLine("_____|_____|_____|_____");
            Console.WriteLine("     |     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  |  {3}  ", BoardList[5], BoardList[6], BoardList[7], BoardList[8]);
            Console.WriteLine("_____|_____|_____|_____");
            Console.WriteLine("     |     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  |  {3}  ", BoardList[9], BoardList[10], BoardList[11], BoardList[12]);
            Console.WriteLine("_____|_____|_____|_____");
            Console.WriteLine("     |     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  |  {3}  ", BoardList[13], BoardList[14], BoardList[15], BoardList[16]);
            Console.WriteLine("     |     |     |     ");
        }

        static void WhoWon() {
            #region WinCheck

            if (BoardList[1] == BoardList[2] && BoardList[2] == BoardList[3] && BoardList[3] == BoardList[4]) {
                Won();
                return;
            }
            
            if (BoardList[5] == BoardList[6] && BoardList[6] == BoardList[7] && BoardList[7] == BoardList[8]) {
                Won();
                return;
            }

            if (BoardList[9] == BoardList[10] && BoardList[10] == BoardList[11] && BoardList[11] == BoardList[12]) {
                Won();
                return;
            }

            if (BoardList[13] == BoardList[14] && BoardList[14] == BoardList[15] && BoardList[15] == BoardList[16]) {
                Won();
                return;
            }

            if (BoardList[1] == BoardList[5] && BoardList[5] == BoardList[9] && BoardList[9] == BoardList[13]) {
                Won();
                return;
            }

            if (BoardList[2] == BoardList[6] && BoardList[6] == BoardList[10] && BoardList[10] == BoardList[14]) {
                Won();
                return;
            }

            if (BoardList[3] == BoardList[7] && BoardList[7] == BoardList[11] && BoardList[11] == BoardList[15]) {
                Won();
                return;
            }

            if (BoardList[4] == BoardList[8] && BoardList[8] == BoardList[12] && BoardList[12] == BoardList[16]) {
                Won();
                return;
            }

            if (BoardList[1] == BoardList[6] && BoardList[6] == BoardList[11] && BoardList[11] == BoardList[16]) {
                Won();
                return;
            }

            if (BoardList[4] == BoardList[7] && BoardList[7] == BoardList[10] && BoardList[10] == BoardList[13]) {
                Won();
                return;
            }

            #endregion

            if (BoardList[1] != '1' && BoardList[2] != '2' && BoardList[3] != '3' && BoardList[4] != '4' && BoardList[5] != '5' && BoardList[6] != '6' && BoardList[7] != '7' && BoardList[8] != '8' && BoardList[9] != '9' && BoardList[10] != 'A' && BoardList[11] != 'B' && BoardList[12] != 'C' && BoardList[13] != 'D' && BoardList[14] != 'E' && BoardList[15] != 'F' && BoardList[16] != 'G') {
                Console.WriteLine("Its a tie");
                Environment.Exit(1);
            }
            



        }

        static void Won() {
            Console.Clear();
            Console.WriteLine("Player 1: \"X\" , Player 2: \"O\"");
            if (player % 2 == 0) {
                Console.WriteLine("Current Player: X");
                playerSign = 'X';

            } else {
                Console.WriteLine("Current Player: O");
                playerSign = 'O';
            }

            Board();
            Console.WriteLine("Player {0} Won!", playerSign);
            Environment.Exit(1);
        }

    }
}


