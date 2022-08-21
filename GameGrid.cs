using System;

namespace TicTacToe
{
    public class GameGrid
    {
        public string[,] gamegrid =
        {
            {"1", "2", "3"},
            {"4", "5", "6"},
            {"7", "8", "9"}
        };

        public void PrintGrid()
        {
            for(int i = 0; i <= 2; i++)
            {
                for(int j = 0; j <= 2; j++)
                {
                    if(j != 2)
                        Console.Write(gamegrid[i, j] + " | ");
                    else
                    {
                        Console.Write(gamegrid[i, j]);
                    }
                }
                Console.WriteLine("\n---------");
            }
        }
    }
}