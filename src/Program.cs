using System;

namespace TicTacToe
{
    class Program
    {

        static void Main(string[] args)
        {
            GameGrid gameGrid = new GameGrid();
            Game game = new Game();

            gameGrid.PrintGrid();

            game.Run();

            Console.ReadKey();
        }
    }
}
