﻿using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static char[,] board = {
            {'1','2','3'},
                            
            { '4','5','6'},
                            
            {'7','8','9' } 
        };



        static int turns = 0;

        static void Main(string[] args)
        {
            int player = 2;
            int input = 0;
            bool checkIfCorrect = true;
            

            

            do {

             

                if (player == 2)
                {
                    player = 1;
                    EnterXorO(player, input);

                }
                else if(player==1)
                {
                    player = 2;
                    EnterXorO(player, input);
                }
                DisplayBoard();

                //check winning condition

                char[] playerChars = { 'x', 'O' };

                foreach( char playerChar in playerChars)
                {
                    if((board[0,0] == playerChar && board[0,1]==playerChar && board[0, 2] == playerChar) 
                        || (board[0, 0] == playerChar && board[1, 0] == playerChar && board[2, 0] == playerChar) 
                        || (board[0, 2] == playerChar && board[1, 2] == playerChar && board[2, 2] == playerChar) 
                        |(board[0, 1] == playerChar && board[1, 1] == playerChar && board[2, 1] == playerChar) 
                        || (board[0, 1] == playerChar && board[1, 1] == playerChar && board[2, 1] == playerChar)
                        || (board[0, 0] == playerChar && board[1, 1] == playerChar && board[2, 2] == playerChar)
                        || (board[0, 2] == playerChar && board[1, 1] == playerChar && board[2, 0] == playerChar))
                    {
                        if (playerChar == 'x')
                        {
                            Console.WriteLine("\nPlayer 2 has won!");
                        }
                        else
                        {
                            Console.WriteLine("\nPlayer 1 has won!");
                        }
                        Console.WriteLine("Please press any key to reset the game");
                        Console.ReadKey();
                        ResetField();
                    }
                    else if(turns == 10)
                    {
                        Console.WriteLine("Draw");
                        Console.WriteLine("Please press any key to reset the game");
                        Console.ReadKey();
                        ResetField();
                        break;
                    }
                   

                }



                do
                {
                    Console.Write("\nPlayer {0} Choose your field!", player);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a number!");
                    }

                    if ((input == 1) && (board[0, 0] == '1'))
                        checkIfCorrect = true;
                    else if ((input == 2) && (board[0, 1] == '2'))
                        checkIfCorrect = true;
                    else if ((input == 3) && (board[0, 2] == '3'))
                        checkIfCorrect = true;
                    else if ((input == 4) && (board[1, 0] == '4'))
                        checkIfCorrect = true;
                    else if ((input == 5) && (board[1, 1] == '5'))
                        checkIfCorrect = true;
                    else if ((input == 6) && (board[1, 2] == '6'))
                        checkIfCorrect = true;
                    else if ((input == 7) && (board[2, 0] == '7'))
                        checkIfCorrect = true;
                    else if ((input == 8) && (board[2, 1] == '8'))
                        checkIfCorrect = true;
                    else if ((input == 9) && (board[2, 2] == '9'))
                        checkIfCorrect = true;
                    else
                    {
                        Console.WriteLine("\nincorrect input. Please use another field");
                        checkIfCorrect = false;
                    }

                }
                while (!checkIfCorrect);

            }

            while( true );
        }

        public static void DisplayBoard()
        {

            Console.Clear();
                Console.WriteLine( "{0}|{1}|{2}\n{3}|{4}|{5}\n{6}|{7}|{8}",board[0,0], board[0,1],board[0,2],board[1,0],board[1,1],board[1,2], board[2,0],board[2,1],board[2,2] );
            turns++;
       
            }
        public static void ResetField()
        {

           char[,] boardInitial = {
            {'1','2','3'},

            { '4','5','6'},

            {'7','8','9' }
        };
            board = boardInitial;
            turns = 0;
            DisplayBoard();
            
        }
        
        public static void EnterXorO(int player, int input) {

            char playerSign = ' ';

            if (player == 1)
                playerSign = 'x';
            else if (player == 2)
                playerSign = 'O';
            switch (input)
            {
                case 1: board[0, 0] = playerSign; break;
                case 2: board[0, 1] = playerSign; break;
                case 3: board[0, 2] = playerSign; break;
                case 4: board[1, 0] = playerSign; break;
                case 5: board[1, 1] = playerSign; break;
                case 6: board[1, 2] = playerSign; break;
                case 7: board[2, 0] = playerSign; break;
                case 8: board[2, 1] = playerSign; break;
                case 9: board[2, 2] = playerSign; break;
            }
        }
                        
        
        }

        
    
}
