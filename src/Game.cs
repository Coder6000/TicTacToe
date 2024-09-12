using System;

namespace TicTacToe
{
    public class Game
    {
        GameGrid gameGrid = new GameGrid();

        int choice1;
        int choice2;
        int flag = 0;
        int plays = 0;
        bool draw = false;
        public bool playerOneTurn = true;
        public bool playerOneWon = false;
        public bool playerTwoTurn = false;
        public bool playerTwoWon = false;

        public void Run()
        {
            while(true)
            {
                void _playerOne()
                {
                    try
                    {
                        choice1 = Int32.Parse(Console.ReadLine());

                        if(choice1 == 1 && playerOneTurn == true)
                        {
                            CheckSpotP1(0,0);
                        }

                        if(choice1 == 2 && playerOneTurn)
                        {
                            CheckSpotP1(0,1);
                        }

                        if(choice1 == 3 && playerOneTurn)
                        {
                            CheckSpotP1(0,2);
                        }
                        if(choice1 == 4 && playerOneTurn)
                        {
                            CheckSpotP1(1,0);
                        }
                        if(choice1 == 5 && playerOneTurn)
                        {
                            CheckSpotP1(1,1);         
                        }            
                        if(choice1 == 6 && playerOneTurn)
                        {
                            CheckSpotP1(1,2);    
                        }

                        if(choice1 == 7 && playerOneTurn)
                        {
                            CheckSpotP1(2,0);       
                        }
                        if(choice1 == 8 && playerOneTurn)
                        {
                            CheckSpotP1(2,1);              
                        }         
                        if(choice1 == 9 && playerOneTurn)
                        {
                            CheckSpotP1(2,2);       
                        }
                    }
                    catch(Exception e)
                    {
                        System.Console.WriteLine(e.Message);
                    }
                }

                void _playerTwo()
                {   
                    try
                    {   
                        Random cpuchoice = new Random();

                        System.Threading.Thread.Sleep(300);
                        choice2 = cpuchoice.Next(0, 9);

                        if(choice2 == 1 && playerTwoTurn)
                        {
                            CheckSpotP2(0,0);
                        }
                        if(choice2 == 2 && playerTwoTurn)
                        {
                            CheckSpotP2(0,1);
                        }
                        if(choice2 == 3 && playerTwoTurn)
                        {
                            CheckSpotP2(0,2);          
                        }
                        if(choice2 == 4 && playerTwoTurn)
                        {
                            CheckSpotP2(1,0);         
                        }
                        if(choice2 == 5 && playerTwoTurn)
                        {
                            CheckSpotP2(1,1);            
                        }            
                        if(choice2 == 6 && playerTwoTurn)
                        {
                            CheckSpotP2(1,2);       
                        }

                        if(choice2 == 7 && playerTwoTurn)
                        {
                            CheckSpotP2(2,0);          
                        }
                        if(choice2 == 8 && playerTwoTurn)
                        {
                            CheckSpotP2(2,1);        
                        }         
                        if(choice2 == 9 && playerTwoTurn)
                        {
                            CheckSpotP2(2,2);          
                        }
                    }
                    catch(Exception e)
                    {
                        System.Console.WriteLine(e.Message);
                    }
                }

                    if(flag != 1)
                    {
                        Console.Clear();
                        gameGrid.PrintGrid();

                            if(playerOneTurn)
                            {   
                                playerOneTurn = true;
                                playerTwoTurn = false;
                                _playerOne();                   
                            }

                            if(playerTwoTurn)
                            {   

                                playerTwoTurn = true;
                                playerOneTurn = false;
                                _playerTwo();
                            }                
                    }

                    #region Player One Horizontal Win
                    if(gameGrid.gamegrid[0, 0] == "X" && gameGrid.gamegrid[0, 1] == "X" && gameGrid.gamegrid[0, 2] == "X")
                    {
                        flag = 1;
                        playerOneWon = true;
                        PlayerOneWinMessage();
                        break;
                    }
                    if(gameGrid.gamegrid[1, 0] == "X" && gameGrid.gamegrid[1, 1] == "X" && gameGrid.gamegrid[1, 2] == "X")
                    {
                        flag = 1;
                        playerOneWon = true;
                        PlayerOneWinMessage();
                        break;
                    }
                    if(gameGrid.gamegrid[2, 0] == "X" && gameGrid.gamegrid[2, 1] == "X" && gameGrid.gamegrid[2, 2] == "X")
                    {
                        flag = 1;
                        playerOneWon = true;
                        PlayerOneWinMessage();
                        break;
                    }
                    #endregion

                    #region Player One Vertical Win
                    if(gameGrid.gamegrid[0, 0] == "X" & gameGrid.gamegrid[1, 0] == "" & gameGrid.gamegrid[2, 0] == "")
                    {
                        flag = 1;
                        playerOneWon = true;
                        PlayerOneWinMessage();
                        break;
                    }

                    if(gameGrid.gamegrid[0, 1] == "X" & gameGrid.gamegrid[1, 1] == "X" & gameGrid.gamegrid[2, 1] == "X")
                    {
                        flag = 1;
                        playerOneWon = true;
                        PlayerOneWinMessage();
                        break;
                    }
                    if(gameGrid.gamegrid[0, 2] == "X" & gameGrid.gamegrid[2, 2] == "X" & gameGrid.gamegrid[2, 2] == "X")
                    {
                        flag = 1;
                        playerOneWon = true;
                        PlayerOneWinMessage();
                        break;
                    }
                    #endregion

                    #region Player One Diagonal Win
                    if(gameGrid.gamegrid[0, 0] == "X" & gameGrid.gamegrid[1, 1] == "X" & gameGrid.gamegrid[2, 2] == "X")
                    {
                        flag = 1;
                        playerOneWon = true;
                        PlayerOneWinMessage();
                        break;
                    }
                    if(gameGrid.gamegrid[2, 0] == "X" & gameGrid.gamegrid[1, 0] == "X" & gameGrid.gamegrid[0, 2] == "X")
                    {
                        flag = 1;
                        playerOneWon = true;
                        PlayerOneWinMessage();
                        break;
                    }
                    #endregion

                    // --------------------------------

                    #region Player Two Horizontal Win
                    if(gameGrid.gamegrid[0, 0] == "O" & gameGrid.gamegrid[0, 1] == "O" & gameGrid.gamegrid[0, 2] == "O")
                    {
                        flag = 1;
                        playerTwoWon = true;
                        PlayerTwoWinMessage();
                        break;
                    }
                    if(gameGrid.gamegrid[1, 0] == "O" & gameGrid.gamegrid[1, 1] == "O" & gameGrid.gamegrid[1, 2] == "O")
                    {
                        flag = 1;
                        playerTwoWon = true;
                        PlayerTwoWinMessage();
                        break;
                    }
                    if(gameGrid.gamegrid[2, 0] == "O" & gameGrid.gamegrid[2, 1] == "O" & gameGrid.gamegrid[2, 2] == "X")
                    {
                        flag = 1;
                        playerTwoWon = true;
                        PlayerTwoWinMessage();
                        break;
                    }
                    #endregion

                    #region Player Two Vertical Win
                    if(gameGrid.gamegrid[0, 0] == "O" & gameGrid.gamegrid[1, 0] == "O" & gameGrid.gamegrid[2, 0] == "O")
                    {
                        flag = 1;
                        playerTwoWon = true;
                        PlayerTwoWinMessage();
                        break;
                    }

                    if(gameGrid.gamegrid[0, 1] == "O" & gameGrid.gamegrid[1, 1] == "O" & gameGrid.gamegrid[2, 1] == "O")
                    {
                        flag = 1;
                        playerTwoWon = true;
                        PlayerTwoWinMessage();
                        break;
                    }
                    if(gameGrid.gamegrid[0, 2] == "O" & gameGrid.gamegrid[2, 2] == "O" & gameGrid.gamegrid[2, 2] == "O")
                    {
                        flag = 1;
                        playerTwoWon = true;
                        PlayerTwoWinMessage();
                        break;
                    }
                    #endregion

                    #region Player Two Diagonal Win
                    if(gameGrid.gamegrid[0, 0] == "O" & gameGrid.gamegrid[1, 1] == "O" & gameGrid.gamegrid[2, 2] == "O")
                    {
                        flag = 1;
                        playerTwoWon = true;
                        PlayerTwoWinMessage();
                        break;
                    }
                    if(gameGrid.gamegrid[2, 0] == "O" & gameGrid.gamegrid[1, 0] == "O" & gameGrid.gamegrid[0, 2] == "O")
                    {
                        flag = 1;
                        playerTwoWon = true;
                        PlayerTwoWinMessage();
                        break;
                    }
                    #endregion

                    #region Draw
                    
                    if(plays == 9)
                    {
                        draw = true;
                        DrawMessage();
                        break;
                    }



                    #endregion           
            }    
        }

        void PlayerOneWinMessage()
        {
            Console.Clear();
            gameGrid.PrintGrid();
            System.Console.WriteLine("Player One Won!");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Good bye!");
        }
        void PlayerTwoWinMessage()
        {
            Console.Clear();
            gameGrid.PrintGrid();
            System.Console.WriteLine("Player Two Won!");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Good bye!");
        }
        void DrawMessage()
        {
            Console.Clear();
            gameGrid.PrintGrid();
            System.Console.WriteLine("Nobody won, its a draw!");
            System.Console.WriteLine("---------------");
            System.Console.WriteLine("Good Bye!");
        }
        void CheckSpotP1(int x, int y)
        {
            if(gameGrid.gamegrid[x,y].Equals("X") || gameGrid.gamegrid[x,y].Equals("O"))
            {
                System.Console.WriteLine("This spot is already occupied, try again.");
                System.Threading.Thread.Sleep(800);
            }
            else
            {
                gameGrid.gamegrid[x, y] = "X";

                playerOneTurn = false;
                playerTwoTurn = true;
                plays++;
            }      
        }
        void CheckSpotP2(int x, int y)
        {
            if(gameGrid.gamegrid[x,y].Equals("X") || gameGrid.gamegrid[x,y].Equals("O"))
            {
                System.Console.WriteLine("This spot is already occupied, try again.");
                System.Threading.Thread.Sleep(800);
            }
            else
            {
                gameGrid.gamegrid[x, y] = "O";

                playerOneTurn = true;
                playerTwoTurn = false;
                plays++;
            }
        }
    }
}