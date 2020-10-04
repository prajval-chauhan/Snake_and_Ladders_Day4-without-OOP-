using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace Snake_and_Ladders_
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNum = new Random();
            
            Console.WriteLine("------------------------------------\n       SNAKES AND LADDERS       \n------------------------------------");
            Console.WriteLine("GAME MODE \n" +" 1. Single Player \n" + " 2. Multiplayer \n Enter the number..." );
            int mode = Convert.ToInt16(Console.ReadLine());

            //Constants
            int START = 0;
            int FINAL = 100;

            // Variables

            int option = 0;
            int dice = 0;
            int turns = 0;

            switch (mode)
            {
                case 1:

                    //For Single Player
                    int player_pos = START;

                    for (int i = 0; ; i++)
                    {
                        if (player_pos == FINAL)
                            break;

                        turns = i;
                        Console.WriteLine("No. of turns played by the player : " + turns);
                        Console.WriteLine("\nPlayer's Position : " + player_pos);
                        dice = randomNum.Next(1, 7);
                        Console.WriteLine("Dice rolled number : " + dice);
                        option = randomNum.Next(0, 3);
                        switch (option)
                        {
                            case 0:
                                Console.WriteLine("No Play");
                                player_pos = player_pos + 0;
                                Console.WriteLine("Player position after this turn: " + player_pos);
                                break;
                            case 1:

                                player_pos = player_pos + dice;
                                if (player_pos > 100)
                                {
                                    Console.WriteLine("No Play");
                                    player_pos = player_pos - dice;
                                    Console.WriteLine("Player position after this turn: " + player_pos);
                                }
                                if (player_pos == FINAL)
                                {
                                    Console.WriteLine("Ladder");
                                    Console.WriteLine("Player position after this turn: " + player_pos + "\nYOU WON");
                                }
                                else
                                {
                                    Console.WriteLine("Ladder");
                                    Console.WriteLine("Player position after this turn: " + player_pos);
                                }
                                break;
                            case 2:
                                {
                                    Console.WriteLine("Snake");
                                    player_pos = player_pos - dice;
                                    if (player_pos >= 0)
                                    {
                                        Console.WriteLine("Player position after this turn: " + player_pos);
                                    }
                                    else
                                    {
                                        player_pos = 0;
                                        Console.WriteLine("Player position after this turn: " + player_pos);
                                    }
                                    break;
                                }
                        }



                    }
                    break;
                case 2:
                    {
                        int player1_pos = START;
                        int player2_pos = START;
                        for (int i = 0; ; i++)
                        {
                            // for player 1
                            do
                            {
                                dice = randomNum.Next(1, 7);
                                option = randomNum.Next(0, 3);
                                Console.WriteLine("\nPlayer 1 Position: " + player1_pos);
                                Console.WriteLine("The dice rolled : " + dice);
                                switch (option)
                                {
                                    case 0:
                                        {
                                            Console.WriteLine("Player 1 got NO PLAY");
                                            player1_pos = player1_pos + 0;
                                            Console.WriteLine("Player 1 position after this turn: " + player1_pos);
                                            break;
                                        }

                                    case 1:
                                        {
                                            Console.WriteLine("Player 1 got SNAKE");
                                            player1_pos = player1_pos - dice;
                                            if (player1_pos < 0)
                                            {
                                                player1_pos = START;
                                            }
                                            Console.WriteLine("Player 1 position after this turn: " + player1_pos);
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.WriteLine("Player 1 got LADDER");
                                            player1_pos = player1_pos + dice;
                                            if (player1_pos > 100)
                                            {
                                                player1_pos = player1_pos - dice;
                                                Console.WriteLine("Can't play more than 100");
                                            }
                                            Console.WriteLine("Player 1 position after this turn = " + player1_pos);
                                            break;
                                        }
                                }
                                if (player1_pos == 100)
                                {
                                    Console.WriteLine("Player 1 won");
                                    break;
                                }
                            } while (dice == 6);
                            if (player1_pos == 100)
                                break;


                            // for Player 2
                            do
                            {
                                dice = randomNum.Next(1, 7);
                                option = randomNum.Next(0, 3);
                                Console.WriteLine("\nPlayer 2 Position: " + player2_pos);
                                Console.WriteLine("The dice rolled : " + dice);
                                switch (option)
                                {
                                    case 0:
                                        {
                                            Console.WriteLine("Player 2 got NO PLAY");
                                            player2_pos = player2_pos + 0;
                                            Console.WriteLine("Player 2 position after this turn: " + player2_pos);
                                            break;
                                        }

                                    case 1:
                                        {
                                            Console.WriteLine("Player 2 got SNAKE");
                                            player2_pos = player2_pos - dice;
                                            if (player2_pos < 0)
                                            {
                                                player2_pos = START;
                                            }
                                            Console.WriteLine("Player 2 position after this turn: " + player2_pos);
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.WriteLine("Player 2 got LADDER");
                                            player2_pos = player2_pos + dice;
                                            if (player2_pos > 100)
                                            {
                                                player2_pos = player2_pos - dice;
                                                Console.WriteLine("Can't play more than 100");
                                            }
                                            Console.WriteLine("Player 2 position after this turn = " + player2_pos);
                                            break;
                                        }
                                }
                                if (player2_pos == 100)
                                {
                                    Console.WriteLine("Player 2 Won");
                                    break;
                                }
                            } while (dice == 6);
                            if (player1_pos==100 || player1_pos==100)
                            {
                                Console.WriteLine("Game Over");
                                break;
                            }
                        }

                        break;
                    }
            }
           



        }
    }
}
