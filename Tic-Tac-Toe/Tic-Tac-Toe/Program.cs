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
        static void Main(string[] args)
        {
            int player = 2;
            int input = 0;
            bool checkIfCorrect = true;
            DisplayBoard();

            

            do {

                if (player == 2)
                {
                    player = 1;
                }else
                {
                    player = 2;
                }
            
                switch (player)
                {
                    case 1:
                        {
                            switch (input)
                            {
                                case 1: board[0, 0] = 'x';break;
                                case 2: board[0,1] = 'x';break;
                                case 3: board[0, 2] = 'x';break;
                                case 4: board[1, 0] = 'x';break;
                                case 5: board[1, 1] = 'x';break;
                                case 6: board[1, 2] = 'x';break;
                                case 7: board[2, 0] = 'x';break;
                                case 8: board[2, 1] = 'x';break;
                                case 9: board[2, 2] = 'x';break;

                            }
                        }

                        break;
                    case 2:
                        {
                            switch(input)
                            {
                                case 1: board[0, 0] = 'o'; break;
                                case 2: board[0, 1] = 'o'; break;
                                case 3: board[0, 2] = 'o'; break;
                                case 4: board[1, 0] = 'o'; break;
                                case 5: board[1, 1] = 'o'; break;
                                case 6: board[1, 2] = 'o'; break;
                                case 7: board[2, 0] = 'o'; break;
                                case 8: board[2, 1] = 'o'; break;
                                case 9: board[2, 2] = 'o'; break;
                            }
                        }
                        break;
                }


            }

            while( true );
        }

        public static void DisplayBoard()
        {
 

                Console.WriteLine( "{0}|{1}|{2}\n{3}|{4}|{5}\n{6}|{7}|{8}",board[0,0], board[0,1],board[0,2],board[1,0],board[1,1],board[1,2], board[2,0],board[2,1],board[2,2] );
       
            }
        }

        
    
}
