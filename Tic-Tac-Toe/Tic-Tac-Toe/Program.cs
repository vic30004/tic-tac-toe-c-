using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayBoard();   
        }

        static void DisplayBoard()
        {
            int[,] board = {{1,2,3},
                            { 4,5,6},
                            {7,8,9 }
            };

            foreach(int x in board)
            {
                Console.WriteLine( "\t{0}__|\n|",x);
            }
            
            
            
        }
    }
}
